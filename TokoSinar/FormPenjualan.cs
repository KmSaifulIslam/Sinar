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
    public partial class FormPenjualan : Form
    {
        TokoSinarDB db = new TokoSinarDB();
        List<tbDetailPenjualan> ListDetailPenjualanUbah = new List<tbDetailPenjualan>();
        string Username;
        string ID_Penjualan;
        string statusPenjualan;

        public FormPenjualan()
        {
            InitializeComponent();
        }

        public FormPenjualan(string username)
        {
            InitializeComponent();
            Username = username;
            tbHargaKhusus.Text = "0";
            tbHarga.Text = "0";
            listBoxBarang.DataSource = db.tbBarangs.Select(x => x.Nama_Barang);
        }

        public FormPenjualan(string username, string id_penjualan, string status)
        {
            InitializeComponent();
            Username = username;
            statusPenjualan = status;
            ID_Penjualan = id_penjualan;

            listBoxBarang.DataSource = db.tbBarangs.Select(x => x.Nama_Barang);

            if (status == "Ubah")
            {
                dgvDetailPenjualan.DataSource = db.tbDetailPenjualans.Where(x=>x.ID_Penjualan == ID_Penjualan).Select(x=> new { Nama_Barang = x.tbBarang.Nama_Barang, Jumlah_Jual = x.Jumlah_Jual, Harga_Jual = x.Harga_Jual, Sub_Total = x.Sub_Total }).ToList();
            }

            tbIdPenjualan.Text = ID_Penjualan;
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tbDetailPenjualan newDetail = new tbDetailPenjualan();
            var queryBarang = db.tbBarangs.Where(x => x.Nama_Barang == listBoxBarang.SelectedItem.ToString()).FirstOrDefault();


            if (queryBarang != null)
            {
                if (queryBarang.Stok - (int)nudQty.Value > 0)
                {
                    if (tbHargaKhusus.Text != "0" && tbHargaKhusus.Text != string.Empty)
                    {
                        decimal hargakhusus = decimal.Parse(tbHargaKhusus.Text);
                        decimal hargabeli = decimal.Parse(tbHargaBeli.Text);

                        if (hargakhusus >= hargabeli)
                        {
                            newDetail.Harga_Jual = decimal.Parse(tbHargaKhusus.Text);
                            newDetail.Sub_Total = decimal.Parse(tbHargaKhusus.Text) * (int)nudQty.Value;
                            newDetail.ID_Penjualan = tbIdPenjualan.Text;
                            newDetail.Jumlah_Jual = (int)nudQty.Value;
                            newDetail.ID_Barang = queryBarang.ID_Barang;

                            if (statusPenjualan == "Baru")
                            {
                                db.tbDetailPenjualans.InsertOnSubmit(newDetail);
                                db.SubmitChanges();
                            }
                            else
                            {
                                ListDetailPenjualanUbah.Add(newDetail);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Harga khusus HARUS lebih besar dari harga beli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        newDetail.Harga_Jual = decimal.Parse(tbHarga.Text);
                        newDetail.Sub_Total = (decimal)(queryBarang.Harga_Jual * (int)nudQty.Value);
                        newDetail.ID_Penjualan = tbIdPenjualan.Text;
                        newDetail.Jumlah_Jual = (int)nudQty.Value;
                        newDetail.ID_Barang = queryBarang.ID_Barang;

                        db.tbDetailPenjualans.InsertOnSubmit(newDetail);
                        db.SubmitChanges();
                    }

                    decimal TotalHarga = 0;

                    foreach (var item in db.tbDetailPenjualans.Where(x => x.ID_Penjualan == ID_Penjualan).Select(x => x.Sub_Total).ToList())
                    {
                        TotalHarga += (decimal)item;
                    }

                    labelTotalPenjualan.Text = TotalHarga.ToString("n0");

                }
                else
                {
                    if (queryBarang.Stok == null)
                    {
                        MessageBox.Show("Harap lakukan pembelian terhadap barang yang dipilih terlebih dahulu, dikarenakan stok tidak mencukupi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mohon maaf jumlah barang yang tersedia tidak mencukupi, sisa barang = " + queryBarang.Stok.ToString(), "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            RefreshDetail();
        }

        private void RefreshDetail()
        {
            db = new TokoSinarDB();
            dgvDetailPenjualan.DataSource = db.tbDetailPenjualans.Where(x => x.ID_Penjualan == tbIdPenjualan.Text).Select(x => new { Nama_Barang = x.tbBarang.Nama_Barang, Jumlah_Jual = x.Jumlah_Jual, Harga_Jual = x.Harga_Jual, Sub_Total = x.Sub_Total }).ToList(); ;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah anda yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                if (dgvDetailPenjualan.SelectedRows.Count > 0)
                {
                    string NamaBarang = dgvDetailPenjualan.SelectedRows[0].Cells["Nama_Barang"].Value.ToString();
                    tbDetailPenjualan dataDelete = db.tbDetailPenjualans.Where(x => x.tbBarang.Nama_Barang == NamaBarang).FirstOrDefault();

                    if (dataDelete != null)
                    {
                        db.tbDetailPenjualans.DeleteOnSubmit(dataDelete);
                        db.SubmitChanges();
                        MessageBox.Show("Data penjualan berhasil di hapus.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data penjualan gagal di hapus.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            RefreshDetail();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (statusPenjualan == "Baru")
            {
                MessageBox.Show("Data penjualan baru telah ditambahkan.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                db.tbDetailPenjualans.InsertAllOnSubmit(ListDetailPenjualanUbah);
                db.SubmitChanges();
                MessageBox.Show("Data penjualan berhasil diubah.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (statusPenjualan == "Baru")
            {
                var DataDetailPenjualan = db.tbDetailPenjualans.Where(x => x.ID_Penjualan == tbIdPenjualan.Text).ToList();
                if (DataDetailPenjualan != null)
                {
                    foreach (var item in DataDetailPenjualan)
                    {
                        tbDetailPenjualan dataDelete = db.tbDetailPenjualans.Where(x => x.ID_DetailPenjualan == item.ID_DetailPenjualan).FirstOrDefault();

                        if (dataDelete != null)
                        {
                            db.tbDetailPenjualans.DeleteOnSubmit(dataDelete);
                            db.SubmitChanges();
                        }
                    }
                }

                tbPenjualan datadeletePenjualan = db.tbPenjualans.Where(x => x.ID_Penjualan == tbIdPenjualan.Text).FirstOrDefault();

                if (datadeletePenjualan != null)
                {
                    db.tbPenjualans.DeleteOnSubmit(datadeletePenjualan);
                    db.SubmitChanges();
                }
                MessageBox.Show("Data Penjualan batal dimasukan.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Data Penjualan batal dimasukan.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void tbCariBarang_TextChanged(object sender, EventArgs e)
        {
            var barang = db.tbBarangs.Where(x => x.Nama_Barang.Contains(tbCariBarang.Text)).Select(x => x.Nama_Barang);

            listBoxBarang.DataSource = barang.ToList();
        }

        private void dgvDetailPenjualan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPenjualan.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("harga_jual") || dgvDetailPenjualan.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("sub_total"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void tbHargaKhusus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void listBoxBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNamaBarang.Text = listBoxBarang.SelectedItem.ToString();

            var detailBarang = db.tbBarangs.Where(x => x.Nama_Barang == listBoxBarang.SelectedItem.ToString()).Select(x => x).FirstOrDefault();

            decimal harga_beli = (decimal)detailBarang.Harga_Beli;
            decimal harga_jual = (decimal)detailBarang.Harga_Jual;

            tbHarga.Text = harga_jual.ToString("n0");
            tbHargaBeli.Text = harga_beli.ToString("n0");
        }

        private void tbHargaKhusus_Leave(object sender, EventArgs e)
        {
            if (tbHargaKhusus.Text != "0" && tbHargaKhusus.Text != string.Empty)
            {
                double harga = double.Parse(tbHargaKhusus.Text);
                tbHargaKhusus.Text = harga.ToString("n0");
            }
            else if (tbHargaKhusus.Text == string.Empty)
            {
                tbHargaKhusus.Text = "0"; 
            }
        }
    }
}
