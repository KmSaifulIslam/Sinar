using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSinar
{
    public partial class FormPembelian : Form
    {
        TokoSinarDB db = new TokoSinarDB();
        string Username;
        string Status;
        string NoFaktur;
        tbSupplier idSupSelect;
        List<ClassListDetailPembelian> ListDetailPembelian = new List<ClassListDetailPembelian>();
        int IDBARANG;
        string IDBarang;
        string SatuanBarang;

        public FormPembelian()
        {
            InitializeComponent();
        }

        public FormPembelian(string username, string noFaktur, string status)
        {
            InitializeComponent();
            Username = username;
            NoFaktur = noFaktur;
            Status = status;
            tbSubTotal.Text = "0";
            labelTotalPembelian.Text = "0";

            foreach (var item in db.tbSuppliers.Where(x=>x.Status == "Aktif").Select(x => x).ToList())
            {
                cbNamaSupplier.Items.Add(item.Nama_Supplier);
            }

            if (Status == "Baru")
            {
                cbNamaSupplier.SelectedIndex = 0;

                groupBoxDetailPembelian.Enabled = false;
                tbNoFaktur.Enabled = true;
                cbNamaSupplier.Enabled = true;
                btnBuatPembelianBaru.Visible = true;
                cbCaraBayar.SelectedIndex = 0;
                IDBARANG = 0;
            }
            else
            {
                IDBARANG = 0;
                listBoxNamaBarang.Items.Clear();
                cbNamaSupplier.Enabled = false;
                var dataUbahPembelian = db.tbPembelians.Where(x => x.No_Faktur == NoFaktur).Select(x => x).FirstOrDefault();
                tbNoFaktur.Text = dataUbahPembelian.No_Faktur;
                cbNamaSupplier.Text = dataUbahPembelian.tbSupplier.Nama_Supplier;
                dtpTanggalPembelian.Value = (DateTime)dataUbahPembelian.Tanggal_Pembelian;
                dtpJatuhTempo.Value = (DateTime)dataUbahPembelian.JatuhTempo;
                tbSalesman.Text = dataUbahPembelian.Salesman;

                decimal subtotaldecimal = decimal.Parse(dataUbahPembelian.Sub_Total.ToString());
                tbSubTotal.Text = subtotaldecimal.ToString("n0");

                nudPPN.Value = (decimal)dataUbahPembelian.PPN;

                decimal totalpembeliandecimal = decimal.Parse(dataUbahPembelian.Total_Pembelian.ToString());
                labelTotalPembelian.Text = totalpembeliandecimal.ToString("n0");
                cbCaraBayar.SelectedItem = dataUbahPembelian.CaraBayar;


                if (listBoxNamaBarang.Items.Count > 0)
                {
                    listBoxNamaBarang.SelectedIndex = 0;
                }

                groupBoxDetailPembelian.Enabled = true;
                tbNoFaktur.Enabled = false;
                cbNamaSupplier.Enabled = false;
                btnBuatPembelianBaru.Visible = false;

                var listDetailPembelianUbah = db.tbDetailPembelians.Where(x => x.No_Faktur == NoFaktur).Select(x => new { ID_DetailPembelian = x.ID_DetailPembelian, Nama_Barang = x.Nama_Barang, Harga_Beli = x.Harga_Beli, Jumlah_Beli = x.Jumlah_Beli, Satuan = x.tbBarang.Satuan, Diskon = x.Diskon, Sub_Total = x.Sub_Total }).ToList();
                dgvDetailPembelian.DataSource = listDetailPembelianUbah;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle |= 0x200;
                return myCp;
            }
        }

        private void cbNamaSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxNamaBarang.Items.Clear();

            idSupSelect = db.tbSuppliers.Where(x => x.Nama_Supplier == cbNamaSupplier.Text && x.Status == "Aktif").FirstOrDefault();

            List<string> listbarang = db.tbBarangs.Where(x => x.ID_Supplier == idSupSelect.ID_Supplier).Select(x => x.Nama_Barang).ToList();

            foreach (var item in listbarang)
            {
                listBoxNamaBarang.Items.Add(item);
            }
        }
        

        private void btnHapusDetail_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah anda yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                if (Status == "Baru")
                {
                    if (dgvDetailPembelian.SelectedRows.Count > 0)
                    {
                        string NamaBarangDelete = dgvDetailPembelian.SelectedRows[0].Cells["Nama_Barang"].Value.ToString();

                        int index = -1;
                        foreach (var item in ListDetailPembelian)
                        {
                            index++;
                            if (item.Nama_Barang == NamaBarangDelete)
                            {
                                break;
                            }
                        }
                        ListDetailPembelian.RemoveAt(index);
                        RefreshDetail();
                    }
                }
                else
                {
                    int detailPembelianUbah = (int)dgvDetailPembelian.SelectedRows[0].Cells["ID_DetailPembelian"].Value;

                    var deletedetailPembelian = db.tbDetailPembelians.Where(x => x.ID_DetailPembelian == detailPembelianUbah).Select(x => x).FirstOrDefault();
                    db.tbDetailPembelians.DeleteOnSubmit(deletedetailPembelian);
                    db.SubmitChanges();
                    RefreshDetail();
                }
            }
        }

        private void RefreshDetail()
        {
            //dgvDetailPembelian.DataSource = "";
            //dgvDetailPembelian.DataSource = ListDetailPembelian;

            db = new TokoSinarDB();
            if (Status == "Baru")
            {
                dgvDetailPembelian.DataSource = ListDetailPembelian.Select(x => new { Nama_Barang = x.Nama_Barang, Harga_Beli = x.Harga_Beli, Jumlah_Beli = x.Jumlah_Beli, Satuan = x.Satuan, Diskon = x.Diskon, Sub_Total = x.Sub_Total }).ToList() ;
            }
            else
            {
                var listDetailPembelianUbah = db.tbDetailPembelians.Where(x => x.No_Faktur == NoFaktur).Select(x => new { Nama_Barang = x.Nama_Barang, Harga_Beli = x.Harga_Beli, Jumlah_Beli = x.Jumlah_Beli, Satuan = x.tbBarang.Satuan, Diskon = x.Diskon, Sub_Total = x.Sub_Total }).ToList();
                //var listDetailPembelianUbah = db.tbDetailPembelians.Where(x => x.No_Faktur == NoFaktur).Select(x => x).ToList();
                dgvDetailPembelian.DataSource = listDetailPembelianUbah;
            }
            //if (dgvDetailPembelian.Columns["Harga_Beli"] != null)
            //{
            //    dgvDetailPembelian.Columns["Harga_Beli"].HeaderText = "Harga Beli";
            //}

            //if (dgvDetailPembelian.Columns["ID_DetailPembelian"] != null)
            //{
            //    dgvDetailPembelian.Columns["ID_DetailPembelian"].Visible = false;
            //}

            //if (dgvDetailPembelian.Columns["tbBarang"] != null)
            //{
            //    dgvDetailPembelian.Columns["tbBarang"].Visible = false;
            //}

            //if (dgvDetailPembelian.Columns["tbPembelian"] != null)
            //{
            //    dgvDetailPembelian.Columns["tbPembelian"].Visible = false;
            //}

            //if (dgvDetailPembelian.Columns["ID_Barang"] != null)
            //{
            //    dgvDetailPembelian.Columns["ID_Barang"].Visible = false;
            //}

            //if (dgvDetailPembelian.Columns["No_Faktur"] != null)
            //{
            //    dgvDetailPembelian.Columns["No_Faktur"].Visible = false;
            //}
        }

        private void btnTambahDetail_Click(object sender, EventArgs e)
        {
            if (tbHargaBeli.Text != "0" && tbHargaBeli.Text != string.Empty)
            {
                if (Status == "Baru")
                {
                    dgvDetailPembelian.DataSource = "";

                    if (db.tbBarangs.Where(x => x.Nama_Barang == tbNamaBarang.Text).Select(x => x.ID_Barang).Count() > 0)
                    {
                        IDBarang = db.tbBarangs.Where(x => x.Nama_Barang == tbNamaBarang.Text).Select(x => x.ID_Barang).FirstOrDefault();
                        SatuanBarang = db.tbBarangs.Where(x => x.Nama_Barang == tbNamaBarang.Text).Select(x => x.Satuan).FirstOrDefault();
                    }
                    else
                    {
                        bool cek1 = true;
                        foreach (var item in ListDetailPembelian)
                        {
                            if (tbNamaBarang.Text == item.Nama_Barang)
                            {
                                cek1 = false;
                                break;
                            }
                        }

                        if (cek1 == true)
                        {
                            IDBARANG++;
                            if (IDBARANG >= 2)
                            {
                                IDBarang = db.FC_AutoIDBarang();
                                string angkaUrut = IDBarang.ToString().Substring(2);
                                int angkaBaru = int.Parse(angkaUrut) + IDBARANG - 1;
                                string angkaBaru2 = "00000000" + angkaBaru;
                                IDBarang = "B-" + angkaBaru2.Substring(angkaBaru2.Length - 8);
                            }
                            else
                            {
                                IDBarang = db.FC_AutoIDBarang();
                            }
                            SatuanBarang = tbSatuan.Text;
                        }
                        SatuanBarang = tbSatuan.Text;
                    }

                    ClassListDetailPembelian detailPembelian = new ClassListDetailPembelian();
                    detailPembelian.Nama_Barang = tbNamaBarang.Text;
                    detailPembelian.Harga_Beli = decimal.Parse(tbHargaBeli.Text);
                    detailPembelian.Jumlah_Beli = (int)nudJumlah.Value + (int)nudBonus.Value;
                    detailPembelian.Diskon = double.Parse(nudDiskon.Value.ToString());
                    detailPembelian.Sub_Total = decimal.Parse(tbSubTotalDetailPembelian.Text);
                    detailPembelian.ID_Barang = IDBarang;
                    detailPembelian.No_Faktur = tbNoFaktur.Text;
                    detailPembelian.Satuan = SatuanBarang;

                    //bool cek = true;
                    ////int jumlahbeli = 0;

                    //foreach (var item in ListDetailPembelian)
                    //{
                    //    if (item.Nama_Barang == tbNamaBarang.Text)
                    //    {
                    //        cek = false;
                    //    }
                    //}

                    //if (cek == true)
                    //{
                        ListDetailPembelian.Add(detailPembelian);

                        decimal TotalPembelian = 0;
                        foreach (var item in ListDetailPembelian)
                        {
                            TotalPembelian += (decimal)item.Sub_Total;
                        }
                        tbSubTotal.Text = TotalPembelian.ToString("n0");
                        labelTotalPembelian.Text = (decimal.Parse(tbSubTotal.Text) + ((nudPPN.Value / 100) * decimal.Parse(tbSubTotal.Text))).ToString("n0");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Barang sudah ada, silahkan edit pada tabel dibawah ^_^");
                    //    jumlahbeli = (int)ListDetailPembelian.Where(x => x.Nama_Barang == tbNamaBarang.Text).Select(x => x.Jumlah_Beli).FirstOrDefault();

                    //    var updatelist = ListDetailPembelian.Where(x => x.Nama_Barang == tbNamaBarang.Text).FirstOrDefault();

                    //    updatelist.Jumlah_Beli = (int)nudQty.Value + jumlahbeli;
                    //    updatelist.Sub_Total = ((int)nudQty.Value + jumlahbeli) * decimal.Parse(tbHargaBeli.Text);
                    //}

                    RefreshDetail();
                }
                else
                {
                    string IDPembelianEdit = tbNoFaktur.Text;

                    var dataDetailPembelian = db.tbDetailPembelians.Where(x => x.No_Faktur == IDPembelianEdit).Select(x => x).ToList();

                    //bool cekDetail = true;
                    //foreach (var item in dataDetailPembelian)
                    //{
                    //    if (item.Nama_Barang == tbNamaBarang.Text)
                    //    {
                    //        cekDetail = false;
                    //        break;
                    //    }
                    //}

                    //if (cekDetail == true)
                    //{
                    dgvDetailPembelian.DataSource = "";

                        if (db.tbBarangs.Where(x => x.Nama_Barang == tbNamaBarang.Text).Select(x => x.ID_Barang).Count() > 0)
                        {
                            IDBarang = db.tbBarangs.Where(x => x.Nama_Barang == tbNamaBarang.Text).Select(x => x.ID_Barang).FirstOrDefault();
                            SatuanBarang = db.tbBarangs.Where(x => x.Nama_Barang == tbNamaBarang.Text).Select(x => x.Satuan).FirstOrDefault();

                            var barangBaru = db.tbBarangs.Where(x => x.Nama_Barang == tbNamaBarang.Text).FirstOrDefault();
                            barangBaru.ID_Barang = IDBarang;
                            barangBaru.Nama_Barang = tbNamaBarang.Text;
                            barangBaru.Satuan = tbSatuan.Text;
                            barangBaru.Harga_Beli = decimal.Parse(tbHargaBeli.Text);
                            barangBaru.Harga_Jual = 0;
                            string idSup = db.tbSuppliers.Where(x => x.Nama_Supplier == cbNamaSupplier.Text).Select(x => x.ID_Supplier).FirstOrDefault();
                            barangBaru.ID_Supplier = idSup;
                            db.SubmitChanges();
                        }
                        else
                        {
                            bool cek1 = true;
                            foreach (var item in ListDetailPembelian)
                            {
                                if (tbNamaBarang.Text == item.Nama_Barang)
                                {
                                    cek1 = false;
                                    break;
                                }
                            }

                            if (cek1 == true)
                            {
                                IDBarang = db.FC_AutoIDBarang();
                                SatuanBarang = tbSatuan.Text;
                            }

                            tbBarang barangbaru = new tbBarang();
                            barangbaru.ID_Barang = IDBarang;
                            barangbaru.Satuan = SatuanBarang;
                            barangbaru.Nama_Barang = tbNamaBarang.Text;
                            //barangbaru.Satuan = tbSatuan.Text;
                            //barangbaru.Stok = item.Jumlah_Beli;
                            barangbaru.Harga_Beli = decimal.Parse(tbHargaBeli.Text);
                            barangbaru.Harga_Jual = 0;
                            //barangbaru.Tanggal_Kadaluarsa = item.Tanggal_Kadaluarsa;
                            string idSup = db.tbSuppliers.Where(x => x.Nama_Supplier == cbNamaSupplier.Text).Select(x => x.ID_Supplier).FirstOrDefault();
                            barangbaru.ID_Supplier = idSup;

                            db.tbBarangs.InsertOnSubmit(barangbaru);
                            db.SubmitChanges();
                        }

                        

                        tbDetailPembelian detailPembelian = new tbDetailPembelian();
                        detailPembelian.Nama_Barang = tbNamaBarang.Text;
                        detailPembelian.Harga_Beli = decimal.Parse(tbHargaBeli.Text);
                        detailPembelian.Jumlah_Beli = (int)nudJumlah.Value + (int)nudBonus.Value;
                        //detailPembelian.Satuan = db.tbBarangs.Where(x => x.ID_Barang == IDBarang).Select(x => x.Satuan).FirstOrDefault();
                        detailPembelian.Diskon = double.Parse(nudDiskon.Value.ToString());
                        detailPembelian.Sub_Total = decimal.Parse(tbSubTotalDetailPembelian.Text);
                        detailPembelian.ID_Barang = IDBarang;
                        detailPembelian.No_Faktur = tbNoFaktur.Text;

                        db.tbDetailPembelians.InsertOnSubmit(detailPembelian);
                        db.SubmitChanges();

                        var detailPembelianyangDiubah = db.tbDetailPembelians.Where(x => x.No_Faktur == IDPembelianEdit).Select(x => x).ToList();

                        decimal TotalPembelian = 0;
                        foreach (var item in detailPembelianyangDiubah)
                        {
                            TotalPembelian += (decimal)item.Sub_Total;
                        }
                        tbSubTotal.Text = TotalPembelian.ToString("n0");
                        labelTotalPembelian.Text = (decimal.Parse(tbSubTotal.Text) + ((nudPPN.Value / 100) * decimal.Parse(tbSubTotal.Text))).ToString("n0");

                        RefreshDetail();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Barang sudah ada, silahkan edit pada tabel dibawah ^_^");
                    //}
                }
            }
            else
            {
                MessageBox.Show("Harga Beli tidak boleh 0", "Peringatan");
            }
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            var barang = db.tbBarangs.Where(x => x.Nama_Barang.Contains(tbCari.Text) && x.ID_Supplier == idSupSelect.ID_Supplier).Select(x => x.Nama_Barang);

            listBoxNamaBarang.DataSource = barang.ToList();
        }

        private void btnBuatPembelianBaru_Click(object sender, EventArgs e)
        {
            if (tbNoFaktur.Text != string.Empty && tbSalesman.Text != string.Empty)
            {
                groupBoxDetailPembelian.Enabled = true;
                groupBoxPembelian.Enabled = false;
            }
            else
            {
                MessageBox.Show("Harap isi No Faktur atau Salesman terlebih dahulu.","Pemberitahuan");
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah anda yakin akan menambah data pembelian?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                if (Status == "Baru")
                {
                    tbPembelian newPembelian = new tbPembelian();

                    newPembelian.No_Faktur = tbNoFaktur.Text;
                    newPembelian.Tanggal_Pembelian = dtpTanggalPembelian.Value;
                    newPembelian.JatuhTempo = dtpJatuhTempo.Value;
                    newPembelian.CaraBayar = cbCaraBayar.Text;
                    newPembelian.Salesman = tbSalesman.Text;
                    newPembelian.Sub_Total = decimal.Parse(tbSubTotal.Text);
                    newPembelian.PPN = double.Parse(nudPPN.Value.ToString());
                    newPembelian.Total_Pembelian = decimal.Parse(labelTotalPembelian.Text);
                    newPembelian.Username = Username;
                    if (cbCaraBayar.Text == "Tunai")
                    {
                        newPembelian.Status = true;
                    }
                    else
                    {
                        newPembelian.Status = false;
                    }
                    string idSupplier = db.tbSuppliers.Where(x => x.Nama_Supplier == cbNamaSupplier.Text).Select(x => x.ID_Supplier).FirstOrDefault();
                    newPembelian.ID_Supplier = idSupplier;

                    db.tbPembelians.InsertOnSubmit(newPembelian);
                    db.SubmitChanges();

                    foreach (var item in ListDetailPembelian)
                    {
                        tbDetailPembelian newDetailPembelian = new tbDetailPembelian();
                        if (db.tbBarangs.Where(x => x.Nama_Barang == item.Nama_Barang).Select(x => x).Count() <= 0)
                        {
                            string idSupplierPembelian = db.tbSuppliers.Where(x => x.Nama_Supplier == cbNamaSupplier.Text).Select(x => x.ID_Supplier).FirstOrDefault();
                            string ID_BarangBaru = item.ID_Barang;

                            tbBarang barangbaru = new tbBarang();
                            barangbaru.ID_Barang = ID_BarangBaru;
                            barangbaru.Nama_Barang = item.Nama_Barang;
                            //barangbaru.Satuan = tbSatuan.Text;
                            barangbaru.Stok = 0;
                            barangbaru.Harga_Beli = item.Harga_Beli;
                            barangbaru.Harga_Jual = 0;
                            //barangbaru.Tanggal_Kadaluarsa = item.Tanggal_Kadaluarsa;
                            barangbaru.ID_Supplier = idSupplierPembelian;
                            barangbaru.Satuan = SatuanBarang;

                            db.tbBarangs.InsertOnSubmit(barangbaru);
                            db.SubmitChanges();
                        }

                        newDetailPembelian.ID_DetailPembelian = item.ID_DetailPembelian;
                        newDetailPembelian.Nama_Barang = item.Nama_Barang;
                        newDetailPembelian.Harga_Beli = (decimal)item.Harga_Beli;
                        newDetailPembelian.Jumlah_Beli = (int)item.Jumlah_Beli;
                        newDetailPembelian.Diskon = (double)item.Diskon;
                        newDetailPembelian.Sub_Total = (decimal)item.Sub_Total;
                        newDetailPembelian.ID_Barang = item.ID_Barang;
                        newDetailPembelian.No_Faktur = item.No_Faktur;

                        db.tbDetailPembelians.InsertOnSubmit(newDetailPembelian);
                        db.SubmitChanges();
                    }
                    MessageBox.Show("Data Pembelian berhasil ditambahkan","Pemberitahuan");
                    this.Close();
                }
                else
                {
                    string IDPembelian = tbNoFaktur.Text;
                    string satuanBarang = tbSatuan.Text;

                    var pembelianUbah = db.tbPembelians.Where(x => x.No_Faktur == IDPembelian).FirstOrDefault();
                    pembelianUbah.Total_Pembelian = decimal.Parse(labelTotalPembelian.Text);
                    pembelianUbah.Sub_Total = decimal.Parse(tbSubTotal.Text);
                    pembelianUbah.Tanggal_Pembelian = dtpTanggalPembelian.Value;
                    pembelianUbah.JatuhTempo = dtpJatuhTempo.Value;
                    pembelianUbah.CaraBayar = cbCaraBayar.Text;
                    pembelianUbah.Salesman = tbSalesman.Text;
                    pembelianUbah.PPN = double.Parse(nudPPN.Value.ToString());
                    pembelianUbah.Username = Username;
                    if (cbCaraBayar.Text == "Tunai")
                    {
                        pembelianUbah.Status = true;
                    }
                    else
                    {
                        pembelianUbah.Status = false;
                    }

                    var barangUbah = db.tbBarangs.Where(x => x.Nama_Barang == tbNamaBarang.Text).FirstOrDefault();
                    barangUbah.Satuan = satuanBarang;

                    db.SubmitChanges();
                    this.Close();
                }
            }
        }

        private void nudJumlah_ValueChanged(object sender, EventArgs e)
        {
            if (tbHargaBeli.Text != string.Empty)
            {
                tbSubTotalDetailPembelian.Text = (nudJumlah.Value * decimal.Parse(tbHargaBeli.Text) - ((nudDiskon.Value / 100) * (nudJumlah.Value * decimal.Parse(tbHargaBeli.Text)))).ToString("n0");
            }
        }

        private void tbHargaBeli_TextChanged(object sender, EventArgs e)
        {
            if (tbHargaBeli.Text != string.Empty)
            {
                tbSubTotalDetailPembelian.Text = (nudJumlah.Value * decimal.Parse(tbHargaBeli.Text) - ((nudDiskon.Value / 100) * (nudJumlah.Value * decimal.Parse(tbHargaBeli.Text)))).ToString("n0");
            }
        }

        private void listBoxNamaBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNamaBarang.SelectedItem != null)
            {
                tbNamaBarang.Text = listBoxNamaBarang.SelectedItem.ToString();
                tbSatuan.Text = db.tbBarangs.Where(x => x.Nama_Barang == listBoxNamaBarang.SelectedItem.ToString()).Select(x => x.Satuan).FirstOrDefault();
                
                tbHargaBeli.Text = db.tbBarangs.Where(x => x.Nama_Barang == listBoxNamaBarang.SelectedItem.ToString()).Select(x => x.Harga_Beli).FirstOrDefault().ToString();
                
                double harga = double.Parse(tbHargaBeli.Text);
                tbHargaBeli.Text = harga.ToString("n0");
            }
        }

        private void nudDiskon_ValueChanged(object sender, EventArgs e)
        {
            if (tbHargaBeli.Text != string.Empty)
            {
                tbSubTotalDetailPembelian.Text = (nudJumlah.Value * decimal.Parse(tbHargaBeli.Text) - ((nudDiskon.Value / 100) * (nudJumlah.Value * decimal.Parse(tbHargaBeli.Text)))).ToString("n0");
            }
        }

        private void dgvDetailPembelian_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Status == "Baru")
            {
                if (dgvDetailPembelian.SelectedCells.Count > 0)
                {
                    //MessageBox.Show(dgvDetailPembelian.SelectedRows[0].Cells[3].OwningColumn.ToString());
                    //ClassListDetailPembelian updatelist;
                    if (ListDetailPembelian.Count() > 0)
                    {
                        var updatelist = ListDetailPembelian.Where(x => x.Nama_Barang == tbNamaBarang.Text).FirstOrDefault();

                        if (dgvDetailPembelian.SelectedRows[0].Cells[3].OwningColumn.Name == "Jumlah Beli")
                        {
                            updatelist.Jumlah_Beli = (int)dgvDetailPembelian.SelectedRows[0].Cells["Jumlah Beli"].Value;
                        }
                        if (dgvDetailPembelian.SelectedRows[0].Cells[2].OwningColumn.Name == "Harga Beli")
                        {
                            updatelist.Harga_Beli = (int)dgvDetailPembelian.SelectedRows[0].Cells["Harga Beli"].Value;
                        }

                        updatelist.Sub_Total = (int)dgvDetailPembelian.SelectedRows[0].Cells["Jumlah_Beli"].Value * (decimal)dgvDetailPembelian.SelectedRows[0].Cells["Harga_Beli"].Value;

                        decimal SubPembelian = 0;
                        foreach (var item in ListDetailPembelian)
                        {
                            SubPembelian += (decimal)item.Sub_Total;
                        }
                        tbSubTotal.Text = SubPembelian.ToString();
                        labelTotalPembelian.Text = (decimal.Parse(tbSubTotal.Text) + ((nudPPN.Value / 100) * decimal.Parse(tbSubTotal.Text))).ToString("0");

                        //int ID_DetailPembelian = (int)dgvDetailPembelian.SelectedRows[0].Cells["ID_DetailPembelian"].Value;
                        //tbDetailPembelian detailPembelian = new tbDetailPembelian();
                        ////dgvDetailPenjualan.SelectedRows[0].Cells["Jumlah Jual"].ReadOnly = false;
                        //detailPembelian = db.tbDetailPembelians.Where(x => x.ID_DetailPembelian == ID_DetailPembelian).FirstOrDefault();
                        //detailPembelian.Sub_Total = (int)dgvDetailPembelian.SelectedRows[0].Cells["Jumlah_Beli"].Value * (decimal)dgvDetailPembelian.SelectedRows[0].Cells["Harga_Jual"].Value;
                        //detailPembelian.Jumlah_Beli = (int)dgvDetailPembelian.SelectedRows[0].Cells["Jumlah_Beli"].Value;
                        //db.SubmitChanges();
                        RefreshDetail();
                    }
                }
            }
            else
            {
                if (dgvDetailPembelian.SelectedRows.Count > 0)
                {
                    int detailPembelianUbah = (int)dgvDetailPembelian.SelectedRows[0].Cells["ID_DetailPembelian"].Value;

                    tbDetailPembelian DetailPembelianUbah = new tbDetailPembelian();
                    DetailPembelianUbah.ID_DetailPembelian = (int)dgvDetailPembelian.SelectedRows[0].Cells["ID_DetailPembelian"].Value;
                    DetailPembelianUbah.Nama_Barang = dgvDetailPembelian.SelectedRows[0].Cells["Nama_Barang"].Value.ToString();
                    DetailPembelianUbah.Harga_Beli = (decimal)dgvDetailPembelian.SelectedRows[0].Cells["Harga_Beli"].Value;
                    DetailPembelianUbah.Jumlah_Beli = (int)dgvDetailPembelian.SelectedRows[0].Cells["Jumlah_Beli"].Value;
                    DetailPembelianUbah.Diskon = double.Parse(dgvDetailPembelian.SelectedRows[0].Cells["Diskon"].Value.ToString());
                    DetailPembelianUbah.Sub_Total = (decimal)dgvDetailPembelian.SelectedRows[0].Cells["Sub_Total"].Value;
                    DetailPembelianUbah.No_Faktur = dgvDetailPembelian.SelectedRows[0].Cells["No_Faktur"].Value.ToString();
                    DetailPembelianUbah.ID_Barang = dgvDetailPembelian.SelectedRows[0].Cells["ID_Barang"].Value.ToString();

                    string satuan = (dgvDetailPembelian.SelectedRows[0].Cells["Satuan"].Value == null) ? "" : dgvDetailPembelian.SelectedRows[0].Cells["Satuan"].Value.ToString();

                    var BarangUbahSatuan = db.tbBarangs.Where(x => x.ID_Barang == DetailPembelianUbah.ID_Barang).Select(x => x).FirstOrDefault();
                    BarangUbahSatuan.Satuan = satuan;
                    db.SubmitChanges();

                    var DetailPembelianUbah2nd = db.tbDetailPembelians.Where(x => x.ID_DetailPembelian == DetailPembelianUbah.ID_DetailPembelian).Select(x => x).FirstOrDefault();

                    DetailPembelianUbah2nd.ID_DetailPembelian = DetailPembelianUbah.ID_DetailPembelian;
                    DetailPembelianUbah2nd.Nama_Barang = DetailPembelianUbah.Nama_Barang;
                    DetailPembelianUbah2nd.Harga_Beli = DetailPembelianUbah.Harga_Beli;
                    DetailPembelianUbah2nd.Jumlah_Beli = DetailPembelianUbah.Jumlah_Beli;
                    DetailPembelianUbah2nd.Diskon = DetailPembelianUbah.Diskon;
                    DetailPembelianUbah2nd.Sub_Total = DetailPembelianUbah.Harga_Beli * DetailPembelianUbah.Jumlah_Beli;
                    DetailPembelianUbah2nd.ID_Barang = DetailPembelianUbah.ID_Barang;

                    db.SubmitChanges();
                    dgvDetailPembelian.Refresh();
                }
            }
        }

        private void tbHargaBeli_Leave(object sender, EventArgs e)
        {
            double harga = double.Parse(tbHargaBeli.Text);
            tbHargaBeli.Text = harga.ToString("n0");
        }

        private void tbHargaBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dgvDetailPembelian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("harga beli") || dgvDetailPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("sub total") || dgvDetailPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("harga_beli") || dgvDetailPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("sub_total"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }
    }
}
