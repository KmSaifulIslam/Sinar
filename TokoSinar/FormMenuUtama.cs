using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TokoSinar
{
    public partial class FormMenuUtama : Form
    {
        TokoSinarDB db = new TokoSinarDB();
        string Username;
        string ID_Penjualan;
        bool cekaddedit;
        object senderAdd;
        EventArgs eAdd;


        public FormMenuUtama()
        {
            InitializeComponent();
        }

        public FormMenuUtama(string username)
        {
            InitializeComponent();
            Username = username;

            cbTanggalFakturPembelian.Checked = false;
            cbTanggalPenjualan.Checked = false;
            cbTanggalRetur.Checked = false;

            dtpTanggalAwalCariPembelian.Enabled = false;
            dtpTanggalAkhirCariPembelian.Enabled = false;
            labelSDPembelian.Enabled = false;

            dtpTanggalAwalPenjualan.Enabled = false;
            dtpTanggalAkhirPenjualan.Enabled = false;
            labelSDPenjualan.Enabled = false;

            dtpTanggalAwalRetur.Enabled = false;
            dtpTanggalAkhirRetur.Enabled = false;
            labelSDRetur.Enabled = false;

            panelPembelian.Visible = true;
            panelOlahKaryawan.Visible = false;
            panelSupplier.Visible = false;
            panelBarang.Visible = false;
            panelPenjualan.Visible = false;
            panelRetur.Visible = false;
            panelLaporan.Visible = false;

            reportViewerInventori.Visible = false;
            reportViewerPembelian.Visible = false;
            reportViewerPenjualan.Visible = false;

            string roleKaryawanLogin = db.tbKaryawans.Where(x=>x.Username == Username).Select(x=>x.tbRole.Nama_Role).FirstOrDefault();
            if (roleKaryawanLogin == "Owner")
            {
                btnResetPasswordKaryawan.Visible = true;
                btnOlahKaryawan.Visible = true;
            }
            else
            {
                btnResetPasswordKaryawan.Visible = false;
                btnOlahKaryawan.Visible = false;
            }

            cbJenisKaryawan.SelectedIndex = 0;
            cbStatusKaryawan.SelectedIndex = 0;
            cbStatusSupplier.SelectedIndex = 0;

            groupBoxTambahUbahKaryawan.Enabled = false;
            groupBoxTambahUbahSupplier.Enabled = false;
            groupBoxTambahUbahBarang.Enabled = false;

            RefreshDataKaryawan();
            RefreshDataSupplier();
            RefreshDataBarang();
            RefreshDataRetur();

            dgvMasterPenjualan.DataSource = db.tbPenjualans.Select(x => new { ID_Penjualan = x.ID_Penjualan, Tanggal_Penjualan = x.Tanggal_Penjualan, Karyawan = x.tbKaryawan.Nama, Total_Penjualan = x.Total_Penjualan });
            dgvMasterPembelian.DataSource = db.tbPembelians.Select(x => new { No_Faktur = x.No_Faktur, Tanggal_Pembelian = x.Tanggal_Pembelian, Cara_Bayar = x.CaraBayar, Nama_Supplier = x.tbSupplier.Nama_Supplier, Salesman = x.Salesman, JatuhTempo = x.JatuhTempo, Sub_Total = x.Sub_Total, PPN = x.PPN, Total_Pembelian = x.Total_Pembelian, Nama = x.tbKaryawan.Nama, Status = x.Status == true ? "Lunas" : "Belum Lunas" }).ToList();

            timer1.Start();
            var orangMasuk = db.tbKaryawans.Where(x => x.Username == Username).FirstOrDefault();
            labelNama.Text = labelNama.Text + orangMasuk.Nama;
            labelRole.Text = labelRole.Text + orangMasuk.tbRole.Nama_Role;
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

        private void labelUbahPassword_Click(object sender, EventArgs e)
        {
            FormUbahPassword fup = new FormUbahPassword(Username);
            fup.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTanggalJam.Text = DateTime.Now.ToString("dd-MMMM-yyyy") + ", " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void btnPembelian_Click(object sender, EventArgs e)
        {
            panelPembelian.Visible = true;
            panelOlahKaryawan.Visible = false;
            panelSupplier.Visible = false;
            panelBarang.Visible = false;
            panelPenjualan.Visible = false;
            panelRetur.Visible = false;
            panelLaporan.Visible = false;

            RefreshDataPembelian();
        }

        private void btnOlahKaryawan_Click(object sender, EventArgs e)
        {
            panelPembelian.Visible = false;
            panelOlahKaryawan.Visible = true;
            panelSupplier.Visible = false;
            panelBarang.Visible = false;
            panelPenjualan.Visible = false;
            panelRetur.Visible = false;
            panelLaporan.Visible = false;

            RefreshDataKaryawan();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            panelPembelian.Visible = false;
            panelOlahKaryawan.Visible = false;
            panelSupplier.Visible = true;
            panelBarang.Visible = false;
            panelPenjualan.Visible = false;
            panelRetur.Visible = false;
            panelLaporan.Visible = false;

            RefreshDataSupplier();
        }

        private void btnOlahBarang_Click(object sender, EventArgs e)
        {
            panelPembelian.Visible = false;
            panelOlahKaryawan.Visible = false;
            panelSupplier.Visible = false;
            panelBarang.Visible = true;
            panelPenjualan.Visible = false;
            panelRetur.Visible = false;
            panelLaporan.Visible = false;

            RefreshDataBarang();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            panelPenjualan.Visible = true;
            panelPembelian.Visible = false;
            panelOlahKaryawan.Visible = false;
            panelSupplier.Visible = false;
            panelBarang.Visible = false;
            panelRetur.Visible = false;
            panelLaporan.Visible = false;

            RefreshDataPenjualan();
        }

        private void btnRetur_Click(object sender, EventArgs e)
        {
            panelPenjualan.Visible = false;
            panelPembelian.Visible = false;
            panelOlahKaryawan.Visible = false;
            panelSupplier.Visible = false;
            panelBarang.Visible = false;
            panelRetur.Visible = true;
            panelLaporan.Visible = false;

            RefreshDataRetur();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            panelPenjualan.Visible = false;
            panelPembelian.Visible = false;
            panelOlahKaryawan.Visible = false;
            panelSupplier.Visible = false;
            panelBarang.Visible = false;
            panelRetur.Visible = false;
            panelLaporan.Visible = true;

            reportViewerInventori.Visible = false;
            reportViewerPembelian.Visible = false;
            reportViewerPenjualan.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPembelianBaru_Click(object sender, EventArgs e)
        {
            FormPembelian fp = new FormPembelian(Username, "", "Baru");
            fp.ShowDialog();
            RefreshDataPembelian();
        }

        private void dgvMasterPembelian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvMasterPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("sub_total") || dgvMasterPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("total_pembelian"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
                if (dgvMasterPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("tanggal_pembelian") || dgvMasterPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("jatuhtempo"))
                {
                    if (e.Value.ToString() != "")
                    {
                        DateTime d = DateTime.Parse(e.Value.ToString());
                        e.Value = d.ToString("dd MMMM yyyy");
                    }
                }
            }
        }

        private void dgvMasterPembelian_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMasterPembelian.SelectedRows.Count > 0)
            {
                string No_Faktur = dgvMasterPembelian.SelectedRows[0].Cells[0].Value.ToString();
                if (db.tbDetailPembelians.Where(x => x.No_Faktur == No_Faktur).Count() > 0)
                {
                    dgvDetailPembelian.DataSource = db.tbDetailPembelians.Where(x => x.No_Faktur == No_Faktur).Select(x => new { Nama_Barang = x.Nama_Barang, Harga_Beli = x.Harga_Beli, Jumlah_Beli = x.Jumlah_Beli, Satuan = x.tbBarang.Satuan, Diskon = x.Diskon, Sub_Total = x.Sub_Total }).ToList();
                }
            }
        }

        private void dgvDetailPembelian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("harga_beli") || dgvDetailPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("sub_total"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void btnUbahPembelian_Click(object sender, EventArgs e)
        {
            string noFaktur = dgvMasterPembelian.SelectedRows[0].Cells["No_Faktur"].Value.ToString();
            FormPembelian formPembelian = new FormPembelian(Username, noFaktur, "Ubah");
            formPembelian.ShowDialog();
            RefreshDataPembelian();
        }

        private void btnHapusPembelian_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah anda yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                if (dgvMasterPembelian.SelectedRows.Count > 0)
                {
                    string No_Faktur_Selected = dgvMasterPembelian.SelectedRows[0].Cells[0].Value.ToString();
                    string ID_Retur_Selected = db.tbReturs.Where(x => x.No_Faktur == No_Faktur_Selected).Select(x => x.ID_Retur).FirstOrDefault();

                    //Delete Detail Retur
                    var dataDetailRetur = db.tbDetailReturs.Where(x => x.ID_Retur == ID_Retur_Selected).ToList();
                    if (dataDetailRetur != null)
                    {
                        foreach (var item in dataDetailRetur)
                        {
                            tbDetailRetur dataDelete = db.tbDetailReturs.Where(x => x.ID_Retur == item.ID_Retur).FirstOrDefault();

                            if (dataDelete != null)
                            {
                                db.tbDetailReturs.DeleteOnSubmit(dataDelete);
                                db.SubmitChanges();
                            }
                        }
                    }

                    //Delete Master Retur
                    tbRetur datadeleteRetur = db.tbReturs.Where(x => x.No_Faktur == No_Faktur_Selected).FirstOrDefault();

                    if (datadeleteRetur != null)
                    {
                        db.tbReturs.DeleteOnSubmit(datadeleteRetur);
                        db.SubmitChanges();
                    }

                    //Delete Detail Pembelian
                    var DataDetailPembelian = db.tbDetailPembelians.Where(x => x.No_Faktur == No_Faktur_Selected).ToList();
                    if (DataDetailPembelian != null)
                    {
                        foreach (var item in DataDetailPembelian)
                        {
                            tbDetailPembelian dataDelete = db.tbDetailPembelians.Where(x => x.No_Faktur == item.No_Faktur).FirstOrDefault();

                            if (dataDelete != null)
                            {
                                db.tbDetailPembelians.DeleteOnSubmit(dataDelete);
                                db.SubmitChanges();
                            }
                        }
                    }

                    //Delete Master Pembelian
                    tbPembelian datadeletePembelian = db.tbPembelians.Where(x => x.No_Faktur == No_Faktur_Selected).FirstOrDefault();

                    if (datadeletePembelian != null)
                    {
                        db.tbPembelians.DeleteOnSubmit(datadeletePembelian);
                        db.SubmitChanges();
                    }
                }

                RefreshDataPembelian();
            }
        }

        private void btnUbahStatus_Click(object sender, EventArgs e)
        {
            string NoFaktur = dgvMasterPembelian.SelectedRows[0].Cells["No_Faktur"].Value.ToString();

            var TMasterPembelian = db.tbPembelians.Where(x => x.No_Faktur == NoFaktur).FirstOrDefault();

            if (TMasterPembelian.Status == true)
            {
                TMasterPembelian.Status = false;
            }
            else
            {
                TMasterPembelian.Status = true;
            }
            db.SubmitChanges();

            RefreshDataPembelian();
        }

        private void cbTanggalFaktur_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTanggalFakturPembelian.Checked == true)
            {
                dtpTanggalAwalCariPembelian.Enabled = true;
                dtpTanggalAkhirCariPembelian.Enabled = true;
                labelSDPembelian.Enabled = true;
            }
            else
            {
                dtpTanggalAwalCariPembelian.Enabled = false;
                dtpTanggalAkhirCariPembelian.Enabled = false;
                labelSDPembelian.Enabled = false;
            }
        }

        private void btnCariPembelian_Click(object sender, EventArgs e)
        {
            if (cbTanggalFakturPembelian.Checked)
            {
                var hasilSearchPembelian = db.tbPembelians.Where(x => (x.No_Faktur.Contains(tbCariPembelian.Text.ToLower()) || x.tbSupplier.Nama_Supplier.ToLower().Contains(tbCariPembelian.Text.ToLower())) && (x.Tanggal_Pembelian >= dtpTanggalAwalCariPembelian.Value && x.Tanggal_Pembelian <= dtpTanggalAkhirCariPembelian.Value)).Select(x => new { x.No_Faktur, x.Tanggal_Pembelian, x.CaraBayar, x.tbSupplier.Nama_Supplier, x.Salesman, x.JatuhTempo, x.Sub_Total, x.PPN, x.Total_Pembelian, x.tbKaryawan.Nama, Status = x.Status == true ? "Lunas" : "Belum Lunas" }).ToList();
                dgvMasterPembelian.DataSource = hasilSearchPembelian;
            }
            else
            {
                var hasilSearchPembelian = db.tbPembelians.Where(x => (x.No_Faktur.Contains(tbCariPembelian.Text.ToLower()) || x.tbSupplier.Nama_Supplier.ToLower().Contains(tbCariPembelian.Text.ToLower()))).Select(x => new { x.No_Faktur, x.Tanggal_Pembelian, x.CaraBayar, x.tbSupplier.Nama_Supplier, x.Salesman, x.JatuhTempo, x.Sub_Total, x.PPN, x.Total_Pembelian, x.tbKaryawan.Nama, Status = x.Status == true ? "Lunas" : "Belum Lunas" }).ToList();
                dgvMasterPembelian.DataSource = hasilSearchPembelian;
            }
        }

        private void RefreshDataPembelian()
        {
            db = new TokoSinarDB();
            if (dgvMasterPembelian.SelectedRows.Count > 0)
            {
                dgvMasterPembelian.DataSource = db.tbPembelians.Select(x => new { No_Faktur = x.No_Faktur, Tanggal_Pembelian = x.Tanggal_Pembelian, Cara_Bayar = x.CaraBayar, Nama_Supplier = x.tbSupplier.Nama_Supplier, Salesman = x.Salesman, JatuhTempo = x.JatuhTempo, Sub_Total = x.Sub_Total, PPN = x.PPN, Total_Pemblian = x.Total_Pembelian, Nama_Karyawan = x.tbKaryawan.Nama, Status = x.Status == true ? "Lunas" : "Belum Lunas" });

                if (dgvMasterPembelian.SelectedRows.Count > 0)
                {
                    dgvDetailPembelian.DataSource = db.tbDetailPembelians.Where(x => x.No_Faktur == dgvMasterPembelian.SelectedRows[0].Cells[0].Value.ToString()).Select(x => new { Nama_Barang = x.Nama_Barang, Harga_Beli = x.Harga_Beli, Jumlah_Beli = x.Jumlah_Beli, Satuan = x.tbBarang.Satuan, Diskon = x.Diskon, Sub_Total = x.Sub_Total }).ToList();
                }
                else
                {
                    dgvDetailPembelian.DataSource = "";
                }
            }
        }

        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {
            cekaddedit = true;
            groupBoxTambahUbahKaryawan.Text = "Tambah Karyawan";
            groupBoxTambahUbahKaryawan.Enabled = true;
            tbUsernameKaryawan.ReadOnly = false;
            tbUsernameKaryawan.Text = "";
            tbNamaKaryawan.Text = "";
            tbAlamatKaryawan.Text = "";
            cbJenisKaryawan.SelectedIndex = 0;
            cbStatusKaryawan.SelectedIndex = 0;

            senderAdd = sender;
            eAdd = e;
        }

        private void btnUbahDataKaryawan_Click(object sender, EventArgs e)
        {
            try
            {
                cekaddedit = false;
                groupBoxTambahUbahKaryawan.Text = "Edit Karyawan";
                groupBoxTambahUbahKaryawan.Enabled = true;
                tbUsernameKaryawan.ReadOnly = true;

                string idUser = dgvMasterKaryawan.SelectedRows[0].Cells[0].Value.ToString();
                var dataEdit = db.tbKaryawans.Where(x => x.Username == idUser).Select(x => x).FirstOrDefault();
               
                tbUsernameKaryawan.Text = dataEdit.Username;
                tbNamaKaryawan.Text = dataEdit.Nama;
                tbAlamatKaryawan.Text = dataEdit.Alamat;

                string RoleKaryawan = db.tbKaryawans.Where(x => x.Username == idUser).Select(x => x.tbRole.Nama_Role).FirstOrDefault();
                cbJenisKaryawan.SelectedItem = RoleKaryawan;
                cbStatusKaryawan.SelectedItem = dataEdit.Status;
            }
            catch
            {
                cekaddedit = true;
                groupBoxTambahUbahKaryawan.Text = "Add Karyawan";
                groupBoxTambahUbahKaryawan.Enabled = true;
                tbUsernameKaryawan.ReadOnly = false;
                MessageBox.Show("Tidak ada data yang dipilih");
            }
        }

        private void tbCariKaryawan_TextChanged(object sender, EventArgs e)
        {
            var hasilsearch = db.tbKaryawans.Where(x => x.Nama.ToLower().Contains(tbCariKaryawan.Text.ToLower()) || x.Alamat.ToLower().Contains(tbCariKaryawan.Text.ToLower())).Select(x => new { Username = x.Username, Nama = x.Nama, JenisKaryawan = x.tbRole.Nama_Role, Alamat =  x.Alamat, Status = x.Status }).ToList();
            dgvMasterKaryawan.DataSource = hasilsearch;
        }

        private void btnHapusDataKaryawan_Click(object sender, EventArgs e)
        {
            try
            {
                string idUser = dgvMasterKaryawan.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult mbox = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo);
                if (mbox == DialogResult.Yes)
                {
                    if (db.tbPenjualans.Where(x => x.Username == idUser).Select(x => x).Count() <= 0 || db.tbPembelians.Where(x => x.Username == idUser).Select(x => x).Count() <= 0)
                    {
                        var cekuser = db.tbKaryawans.Where(x => x.Username == idUser).Select(x => x).FirstOrDefault();
                        if (cekuser != null)
                        {
                            db.tbKaryawans.DeleteOnSubmit(cekuser);
                            db.SubmitChanges();

                            MessageBox.Show("Data Berhasil dihapus");
                            RefreshDataKaryawan();
                            btnTambahKaryawan_Click(senderAdd, eAdd);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tidak ada data yang dipilih");
            }
        }

        private void RefreshDataKaryawan()
        {
            var dataAllKary = db.tbKaryawans.Select(x => new { Username = x.Username, Nama = x.Nama, JenisKaryawan = x.tbRole.Nama_Role, Alamat = x.Alamat, Status = x.Status });
            dgvMasterKaryawan.DataSource = dataAllKary.ToList();
        }

        private void btnSimpanKaryawan_Click(object sender, EventArgs e)
        {
            if (cekaddedit == true) //add
            {
                if (tbUsernameKaryawan.Text != string.Empty && tbNamaKaryawan.Text != string.Empty)
                {
                    try
                    {
                        tbKaryawan newUser = new tbKaryawan();

                        if (db.tbKaryawans.Where(x => x.Username == tbUsernameKaryawan.Text).Count() == 0)
                        {
                            newUser.Username = tbUsernameKaryawan.Text;
                            newUser.Password = "sinar";
                            newUser.Nama = tbNamaKaryawan.Text;
                            newUser.ID_Role = db.tbRoles.Where(x => x.Nama_Role == cbJenisKaryawan.Text).Select(x => x.ID_Role).FirstOrDefault();
                            newUser.Alamat = tbAlamatKaryawan.Text;
                            newUser.Status = cbStatusKaryawan.SelectedItem.ToString();

                            db.tbKaryawans.InsertOnSubmit(newUser);
                            db.SubmitChanges();

                            RefreshDataKaryawan();
                            MessageBox.Show("Data Berhasil ditambah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnTambahKaryawan_Click(senderAdd, eAdd);
                        }
                        else
                        {
                            MessageBox.Show("Username telah terdaftar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Tambah karyawan tidak berhasil.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Harap isi semua kolom dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else //edit
            {
                try
                {
                    if (db.tbKaryawans.Where(x => x.Username == Username).Count() > 0)
                    {
                        var editUser = db.tbKaryawans.Where(x => x.Username == tbUsernameKaryawan.Text).FirstOrDefault();
                        editUser.Username = db.tbKaryawans.Where(x => x.Username == tbUsernameKaryawan.Text).Select(x => x.Username).FirstOrDefault();
                        editUser.Nama = tbNamaKaryawan.Text;
                        editUser.ID_Role = db.tbRoles.Where(x => x.Nama_Role == cbJenisKaryawan.Text).Select(x => x.ID_Role).FirstOrDefault();
                        editUser.Alamat = tbAlamatKaryawan.Text;
                        editUser.Status = cbStatusKaryawan.SelectedItem.ToString();

                        db.SubmitChanges();

                        RefreshDataKaryawan();
                        MessageBox.Show("Data Karyawan berhasil diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ubah Data Karyawan gagal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Ubah Data Karyawan gagal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            groupBoxTambahUbahKaryawan.Enabled = false;
        }

        private void btnResetPasswordKaryawan_Click(object sender, EventArgs e)
        {
            var dataKaryawanResetPassword = db.tbKaryawans.Where(x => x.Username == Username).Select(x => x).FirstOrDefault();
            dataKaryawanResetPassword.Password = "sinar";
            db.SubmitChanges();
            RefreshDataKaryawan();
        }


        //SUPPLIER
        private void RefreshDataSupplier()
        {
            var dataAllSupplier = db.tbSuppliers.Select(x => new { x.ID_Supplier, x.Nama_Supplier, x.Alamat_Supplier, x.No_TelponSupplier, x.Status });
            dgvMasterSupplier.DataSource = dataAllSupplier.ToList();
        }

        private void tbCariSupplier_TextChanged(object sender, EventArgs e)
        {
            var hasilsearch = db.tbSuppliers.Where(x => x.Nama_Supplier.ToLower().Contains(tbCariSupplier.Text.ToLower()) || x.Alamat_Supplier.ToLower().Contains(tbCariSupplier.Text.ToLower())).Select(x => new { ID_Supplier = x.ID_Supplier, Nama_SUpplier = x.Nama_Supplier, Alamat_Supplier = x.Alamat_Supplier, Status = x.Status }).ToList();
            dgvMasterSupplier.DataSource = hasilsearch;
        }

        private void btnTambahSupplierBaru_Click(object sender, EventArgs e)
        {
            cekaddedit = true;
            groupBoxTambahUbahSupplier.Text = "Tambah Supplier";
            groupBoxTambahUbahSupplier.Enabled = true;
            tbKodeSupplier.ReadOnly = true;
            tbKodeSupplier.Text = db.FC_AutoIDSupplier();
            tbNamaSupplier.Text = "";
            tbAlamatSupplier.Text = "";
            tbTelpSupplier.Text = "";

            senderAdd = sender;
            eAdd = e;
        }

        private void btnUbahDataSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                cekaddedit = false;
                groupBoxTambahUbahSupplier.Text = "Ubah Supplier";
                groupBoxTambahUbahSupplier.Enabled = true;
                tbKodeSupplier.ReadOnly = true;

                string kodeSupplier = dgvMasterSupplier.SelectedRows[0].Cells[0].Value.ToString();
                var dataEdit = db.tbSuppliers.Where(x => x.ID_Supplier == kodeSupplier).Select(x => x).FirstOrDefault();
                tbKodeSupplier.Text = dataEdit.ID_Supplier;
                tbNamaSupplier.Text = dataEdit.Nama_Supplier;
                tbAlamatSupplier.Text = dataEdit.Alamat_Supplier;
                tbTelpSupplier.Text = dataEdit.No_TelponSupplier;
                cbStatusSupplier.SelectedItem = dataEdit.Status;
            }
            catch
            {
                cekaddedit = true;
                groupBoxTambahUbahSupplier.Text = "Tambah Supplier";
                groupBoxTambahUbahSupplier.Enabled = true;
                tbKodeSupplier.ReadOnly = true;
                MessageBox.Show("Tidak ada data yang dipilih", "Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnSimpanSupplier_Click(object sender, EventArgs e)
        {
            if (cekaddedit == true) //add
            {
                if (tbKodeSupplier.Text != string.Empty && tbNamaSupplier.Text != string.Empty && tbAlamatSupplier.Text != string.Empty && tbTelpSupplier.Text != string.Empty)
                {
                    try
                    {
                        tbSupplier newSupplier = new tbSupplier();

                        if (db.tbSuppliers.Where(x => x.ID_Supplier == tbKodeSupplier.Text).Count() == 0)
                        {
                            newSupplier.ID_Supplier = tbKodeSupplier.Text;
                            newSupplier.Nama_Supplier = tbNamaSupplier.Text;
                            newSupplier.Alamat_Supplier = tbAlamatSupplier.Text;
                            newSupplier.No_TelponSupplier = tbTelpSupplier.Text;
                            newSupplier.Status = cbStatusSupplier.SelectedItem.ToString();

                            db.tbSuppliers.InsertOnSubmit(newSupplier);
                            db.SubmitChanges();

                            RefreshDataSupplier();
                            MessageBox.Show("Data Supplier Berhasil ditambah", "Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            btnTambahSupplierBaru_Click(senderAdd, eAdd);
                        }
                        else
                        {
                            MessageBox.Show("Kode Supplier yang dimasukkan sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Tambah Supplier tidak berhasil", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else //edit
            {
                try
                {

                    if (db.tbSuppliers.Where(x => x.ID_Supplier == tbKodeSupplier.Text).Count() > 0)
                    {
                        var editSupplier = db.tbSuppliers.Where(x => x.ID_Supplier == tbKodeSupplier.Text).FirstOrDefault();
                        editSupplier.ID_Supplier = db.tbSuppliers.Where(x => x.ID_Supplier == tbKodeSupplier.Text).Select(x => x.ID_Supplier).FirstOrDefault();
                        editSupplier.Nama_Supplier = tbNamaSupplier.Text;
                        editSupplier.Alamat_Supplier = tbAlamatSupplier.Text;
                        editSupplier.No_TelponSupplier = tbTelpSupplier.Text;
                        editSupplier.Status = cbStatusSupplier.SelectedItem.ToString();

                        db.SubmitChanges();

                        RefreshDataSupplier();
                        MessageBox.Show("Data berhasil diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ubah Data gagal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Ubah Data gagal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tbTelpSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //BARANG
        private void tbCariBarang_TextChanged(object sender, EventArgs e)
        {
            var hasilsearch = db.tbBarangs.Where(x => x.Nama_Barang.ToLower().Contains(tbCariBarang.Text.ToLower())).Select(x => new { x.ID_Barang, x.Nama_Barang, x.Harga_Beli, x.Harga_Jual, x.Satuan, x.Stok }).ToList();
            dgvMasterBarang.DataSource = hasilsearch;
        }

        private void btnTambahBarangBaru_Click(object sender, EventArgs e)
        {
            radioSupplierLama.Checked = true;
            cbNamaSupplier.Enabled = true;
            tbAlamatSupplier.ReadOnly = true;
            tbNoTelpSupplier.ReadOnly = true;
            cekaddedit = true;
            groupBoxTambahUbahBarang.Text = "Tambah Barang";
            groupBoxTambahUbahBarang.Enabled = true;
            tbKodeBarang.ReadOnly = true;
            tbKodeBarang.Text = db.FC_AutoIDBarang();
            tbSatuanBarang.Text = "";
            tbNamaBarang.Text = "";
            tbHargaBeliBarang.Text = "0";
            tbHargaJualBarang.Text = "0";
            //nudStok.Value = 0;
            //nudStok.Enabled = false;

            senderAdd = sender;
            eAdd = e;
        }

        private void btnUbahDataBarang_Click(object sender, EventArgs e)
        {
            cbNamaSupplier.Enabled = true;
            tbAlamatSupplier.ReadOnly = true;
            tbNoTelpSupplier.ReadOnly = true;
            radioSupplierLama.Checked = true;

            try
            {
                cekaddedit = false;
                groupBoxTambahUbahBarang.Text = "Ubah Barang";
                groupBoxTambahUbahBarang.Enabled = true;
                tbKodeBarang.ReadOnly = true;

                string kodebarang = dgvMasterBarang.SelectedRows[0].Cells[0].Value.ToString();
                var dataEdit = db.tbBarangs.Where(x => x.ID_Barang == kodebarang).Select(x => x).FirstOrDefault();
                tbKodeBarang.Text = dataEdit.ID_Barang;
                tbNamaBarang.Text = dataEdit.Nama_Barang;
                tbSatuanBarang.Text = dataEdit.Satuan;
                //nudStok.Value = (int)dataEditDetailBarang.Stok;
                //nudStok.Enabled = true;
                decimal hargabeli = (decimal)dataEdit.Harga_Beli;
                decimal hargajual = (decimal)dataEdit.Harga_Jual;
                tbHargaBeliBarang.Text = hargabeli.ToString("n0");
                tbHargaJualBarang.Text = hargajual.ToString("n0");
                //dtpKadaluarsa.Value = (DateTime)dataEditDetailBarangTanggal_Kadaluarsa;
            }
            catch
            {
                cekaddedit = true;
                groupBoxTambahUbahBarang.Text = "Tambah Barang";
                groupBoxTambahUbahBarang.Enabled = true;
                tbKodeBarang.ReadOnly = false;
                MessageBox.Show("Tidak ada data yang dipilih","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void radioSupplierLama_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSupplierLama.Checked == true)
            {
                SupplierLama();
            }
            else
            {
                SupplierBaru();
            }
        }

        private void radioSupplierBaru_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSupplierLama.Checked == true)
            {
                SupplierLama();
            }
            else
            {
                SupplierBaru();
            }
        }

        private void SupplierLama()
        {
            cbNamaSupplier.Visible = true;
            tbNamaSupplier.Visible = false;
            cbNamaSupplier.Enabled = true;
            tbAlamatSupplier.ReadOnly = true;
            tbNoTelpSupplier.ReadOnly = true;

            cbNamaSupplier.Items.Clear();
            var namaSupplier = db.tbSuppliers.Select(x => x).ToList();
            foreach (var item in namaSupplier)
            {
                cbNamaSupplier.Items.Add(item.Nama_Supplier);
            }
            cbNamaSupplier.SelectedIndex = 0;
        }

        private void SupplierBaru()
        {
            cbNamaSupplier.Visible = false;
            tbNamaSupplier.Visible = true;
            cbNamaSupplier.Enabled = true;
            tbAlamatSupplier.ReadOnly = false;
            tbNoTelpSupplier.ReadOnly = false;
            tbNamaSupplier.Text = "";
            tbAlamatSupplier.Text = "";
            tbNoTelpSupplier.Text = "";
        }

        private void RefreshDataBarang()
        {
            dgvMasterBarang.DataSource = db.tbBarangs.Select(x => new { x.ID_Barang, x.Nama_Barang, x.Harga_Beli, x.Harga_Jual, x.Satuan, x.Stok }).ToList();
        }

        private void btnSimpanBarang_Click(object sender, EventArgs e)
        {
            if (cekaddedit == true) //add
            {
                tbBarang newBarang = new tbBarang();

                if (radioSupplierBaru.Checked == true)
                {
                    tbSupplier newSupplier = new tbSupplier();

                    newSupplier.ID_Supplier = db.FC_AutoIDSupplier();
                    newSupplier.Nama_Supplier = tbNamaSupplier.Text;
                    newSupplier.Alamat_Supplier = tbAlamatSupplier.Text;
                    newSupplier.No_TelponSupplier = tbNoTelpSupplier.Text;

                    db.tbSuppliers.InsertOnSubmit(newSupplier);
                    db.SubmitChanges();

                    newBarang.ID_Supplier = newSupplier.ID_Supplier;
                }
                else
                {
                    newBarang.ID_Supplier = db.tbSuppliers.Where(x => x.Nama_Supplier == cbNamaSupplier.Text).Select(x => x.ID_Supplier).FirstOrDefault();
                }

                if (tbKodeBarang.Text != string.Empty && tbNamaBarang.Text != string.Empty && tbHargaBeliBarang.Text != string.Empty && tbHargaJualBarang.Text != string.Empty)
                {
                    decimal HargaBeli;
                    decimal HargaJual;

                    try
                    {
                        if (db.tbBarangs.Where(x => x.ID_Barang == tbKodeBarang.Text).Count() == 0)
                        {
                            newBarang.ID_Barang = tbKodeBarang.Text;
                            newBarang.Nama_Barang = tbNamaBarang.Text;
                            //newBarang.Stok = (int)nudStok.Value;

                            double HargaBeliDouble;
                            double HargaJualDouble;
                            double.TryParse(tbHargaBeliBarang.Text, out HargaBeliDouble);
                            double.TryParse(tbHargaJualBarang.Text, out HargaJualDouble);

                            HargaBeli = (decimal)HargaBeliDouble;
                            HargaJual = (decimal)HargaJualDouble;

                            if (HargaBeli <= HargaJual)
                            {
                                newBarang.Satuan = tbSatuanBarang.Text;
                                newBarang.Harga_Beli = HargaBeli;
                                newBarang.Harga_Jual = HargaJual;
                                //newBarang.Tanggal_Kadaluarsa = dtpKadaluarsa.Value;
                                db.tbBarangs.InsertOnSubmit(newBarang);
                                db.SubmitChanges();

                                RefreshDataBarang();
                                MessageBox.Show("Data Berhasil ditambah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnTambahBarangBaru_Click(senderAdd, eAdd); 
                            }
                            else
                            {
                                MessageBox.Show("Harga jual harus lebih tinggi dari Harga beli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Kode Barang yang dimasukkan sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Tambah Barang tidak berhasil", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else //edit
            {
                tbBarang newBarang = new tbBarang();
                tbSupplier newSupplier = new tbSupplier();

                if (radioSupplierBaru.Checked == true)
                {

                    newSupplier.ID_Supplier = db.FC_AutoIDSupplier();
                    newSupplier.Nama_Supplier = tbNamaSupplier.Text;
                    newSupplier.Alamat_Supplier = tbAlamatSupplier.Text;
                    newSupplier.No_TelponSupplier = tbNoTelpSupplier.Text;

                    db.tbSuppliers.InsertOnSubmit(newSupplier);
                    db.SubmitChanges();

                }
                else
                {
                    newBarang.ID_Supplier = db.tbSuppliers.Where(x => x.Nama_Supplier == cbNamaSupplier.Text).Select(x => x.ID_Supplier).FirstOrDefault();
                }

                decimal HargaBeli;
                decimal HargaJual;

                try
                {
                    double HargaBeliDouble;
                    double HargaJualDouble;
                    double.TryParse(tbHargaBeliBarang.Text, out HargaBeliDouble);
                    double.TryParse(tbHargaJualBarang.Text, out HargaJualDouble);

                    HargaBeli = (decimal)HargaBeliDouble;
                    HargaJual = (decimal)HargaJualDouble;

                    if (db.tbBarangs.Where(x => x.ID_Barang == tbKodeBarang.Text).Count() > 0)
                    {
                        if (HargaBeli <= HargaJual)
                        {
                            var editBarang = db.tbBarangs.Where(x => x.ID_Barang == tbKodeBarang.Text).FirstOrDefault();
                            editBarang.ID_Supplier = newSupplier.ID_Supplier;
                            editBarang.ID_Barang = db.tbBarangs.Where(x => x.ID_Barang == tbKodeBarang.Text).Select(x => x.ID_Barang).FirstOrDefault();
                            editBarang.Nama_Barang = tbNamaBarang.Text;
                            editBarang.Satuan = tbSatuanBarang.Text;
                            //editBarang.Stok = (int)nudStok.Value;
                            editBarang.Harga_Beli = HargaBeli;
                            editBarang.Harga_Jual = HargaJual;
                            editBarang.ID_Supplier = newBarang.ID_Supplier;
                            //editBarang.Tanggal_Kadaluarsa = dtpKadaluarsa.Value;

                            db.SubmitChanges();

                            RefreshDataBarang();
                            MessageBox.Show("Data berhasil diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Harga jual harus lebih tinggi dari Harga beli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ubah Data gagal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Ubah Data gagal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvMasterBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvMasterBarang.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("harga_beli") || dgvMasterBarang.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("harga_jual"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void tbHargaBeliBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tbHargaJualBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tbHargaBeliBarang_Leave(object sender, EventArgs e)
        {
            double harga = double.Parse(tbHargaBeliBarang.Text);
            tbHargaBeliBarang.Text = harga.ToString("n0");
        }

        private void tbHargaJualBarang_Leave(object sender, EventArgs e)
        {
            double harga = double.Parse(tbHargaJualBarang.Text);
            tbHargaJualBarang.Text = harga.ToString("n0");
        }

        //PENJUALAN
        private void RefreshDataPenjualan()
        {
            db = new TokoSinarDB();
            if (dgvMasterPenjualan.SelectedRows.Count > 0)
            {
                dgvMasterPenjualan.DataSource = db.tbPenjualans.Select(x => new { ID_Penjualan = x.ID_Penjualan, Tanggal_Penjualan = x.Tanggal_Penjualan, Karyawan = x.tbKaryawan.Nama, Total_Penjualan = x.Total_Penjualan });

                if (dgvMasterPenjualan.SelectedRows.Count > 0)
                {
                    dgvDetailPenjualan.DataSource = db.tbDetailPenjualans.Where(x => x.ID_Penjualan == dgvMasterPenjualan.SelectedRows[0].Cells[0].Value.ToString()).Select(x => new { Nama_Barang = x.tbBarang.Nama_Barang, Harga_Jual = x.Harga_Jual, Jumlah_Jual = x.Jumlah_Jual, Satuan = x.tbBarang.Satuan, Sub_Total = x.Sub_Total }).ToList();
                }
                else
                {
                    dgvDetailPenjualan.DataSource = "";
                }
            }
        }

        private void btnPenjualanBaru_Click(object sender, EventArgs e)
        {
            tbPenjualan newPenjualan = new tbPenjualan();

            newPenjualan.ID_Penjualan = db.FC_AutoIDPenjualan();
            newPenjualan.Tanggal_Penjualan = DateTime.Now;
            newPenjualan.Total_Penjualan = 0;
            newPenjualan.Username = Username;

            db.tbPenjualans.InsertOnSubmit(newPenjualan);
            db.SubmitChanges();

            FormPenjualan FormPenjualan = new FormPenjualan(Username, newPenjualan.ID_Penjualan, "Baru");
            FormPenjualan.ShowDialog();
            RefreshDataPenjualan();
        }

        private void cbTanggalPenjualan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTanggalPenjualan.Checked == true)
            {
                dtpTanggalAwalPenjualan.Enabled = true;
                dtpTanggalAkhirPenjualan.Enabled = true;
                labelSDPenjualan.Enabled = true;
            }
            else
            {
                dtpTanggalAwalPenjualan.Enabled = false;
                dtpTanggalAkhirPenjualan.Enabled = false;
                labelSDPenjualan.Enabled = false;
            }
        }

        private void btnCariPenjualan_Click(object sender, EventArgs e)
        {
            if (cbTanggalFakturPembelian.Checked)
            {
                var hasilSearchPenjualan = db.tbPenjualans.Where(x => (x.ID_Penjualan.Contains(tbCariPembelian.Text.ToLower()) || x.tbKaryawan.Nama.ToLower().Contains(tbCariPembelian.Text.ToLower())) && (x.Tanggal_Penjualan >= dtpTanggalAwalPenjualan.Value && x.Tanggal_Penjualan <= dtpTanggalAkhirPenjualan.Value)).Select(x => new { ID_Penjualan = x.ID_Penjualan, Tanggal_Penjualan = x.Tanggal_Penjualan, Karyawan = x.tbKaryawan.Nama, Total_Penjualan = x.Total_Penjualan }).ToList();
                dgvMasterPenjualan.DataSource = hasilSearchPenjualan;
            }
            else
            {
                var hasilSearchPenjualan = db.tbPenjualans.Where(x => (x.ID_Penjualan.Contains(tbCariPembelian.Text.ToLower()) || x.tbKaryawan.Nama.ToLower().Contains(tbCariPembelian.Text.ToLower()))).Select(x => new { ID_Penjualan = x.ID_Penjualan, Tanggal_Penjualan = x.Tanggal_Penjualan, Karyawan = x.tbKaryawan.Nama, Total_Penjualan = x.Total_Penjualan }).ToList();
                dgvMasterPenjualan.DataSource = hasilSearchPenjualan;
            }
        }

        private void btnUbahPenjualan_Click(object sender, EventArgs e)
        {
            if (dgvMasterPenjualan.SelectedRows.Count > 0)
            {
                ID_Penjualan = dgvMasterPenjualan.SelectedRows[0].Cells[0].Value.ToString();
                FormPenjualan FormPenjualan = new FormPenjualan(Username, ID_Penjualan, "Ubah");
                FormPenjualan.ShowDialog();
            }
            RefreshDataPenjualan();
        }

        private void btnHapusPenjualan_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah anda yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string idPenjualan = "";
            if (dgvMasterPenjualan.SelectedRows.Count > 0)
            {
                idPenjualan = dgvMasterPenjualan.SelectedRows[0].Cells[0].Value.ToString();
            }

            if (message == DialogResult.Yes)
            {
                if (idPenjualan != null)
                {

                    var DataDetailPenjualan = db.tbDetailPenjualans.Where(x => x.ID_Penjualan == idPenjualan).ToList();
                    if (DataDetailPenjualan != null)
                    {
                        db.tbDetailPenjualans.DeleteAllOnSubmit(DataDetailPenjualan);
                        db.SubmitChanges();
                    }

                    tbPenjualan datadeletePenjualan = db.tbPenjualans.Where(x => x.ID_Penjualan == idPenjualan).FirstOrDefault();

                    if (datadeletePenjualan != null)
                    {
                        db.tbPenjualans.DeleteOnSubmit(datadeletePenjualan);
                        db.SubmitChanges();
                    }

                    RefreshDataPenjualan();
                }
                MessageBox.Show("Data Penjualan berhasil dihapus.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Penjualan batal dihapus.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void dgvMasterPenjualan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMasterPenjualan.SelectedRows.Count > 0)
            {
                string ID_Penjualan = dgvMasterPenjualan.SelectedRows[0].Cells[0].Value.ToString();
                if (db.tbDetailPenjualans.Where(x => x.ID_Penjualan == ID_Penjualan).Count() > 0)
                {
                    dgvDetailPenjualan.DataSource = db.tbDetailPenjualans.Where(x => x.ID_Penjualan == ID_Penjualan).Select(x => new { Nama_Barang = x.tbBarang.Nama_Barang, Harga_Jual = x.Harga_Jual, Jumlah_Jual = x.Jumlah_Jual, Satuan = x.tbBarang.Satuan, Sub_Total = x.Sub_Total }).ToList();
                }
            }
        }

        private void dgvMasterPenjualan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvMasterPenjualan.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("total_penjualan"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
                if (dgvMasterPenjualan.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("tanggal_penjualan"))
                {
                    if (e.Value.ToString() != "")
                    {
                        DateTime d = DateTime.Parse(e.Value.ToString());
                        e.Value = d.ToString("dd MMMM yyyy");
                    }
                }
            }
        }

        private void dgvDetailPenjualan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPenjualan.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("sub_total") || dgvDetailPenjualan.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("harga_jual"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        //RETUR
        private void RefreshDataRetur()
        {
            db = new TokoSinarDB();
            dgvMasterRetur.DataSource = db.tbReturs.Select(x => new { ID_Retur = x.ID_Retur, No_Faktur = x.No_Faktur, Tanggal_Retur = x.Tanggal_Retur }).ToList();
        }

        private void dgvMasterRetur_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMasterRetur.SelectedRows.Count > 0)
            {
                string idRetur = dgvMasterRetur.SelectedRows[0].Cells["ID_Retur"].Value.ToString();

                var dataDetailRetur = db.tbDetailReturs.Where(x => x.ID_Retur == idRetur).Select(x => new { ID_Barang = x.ID_Barang, Nama_Barang = x.tbBarang.Nama_Barang, Jumlah_Retur = x.Jumlah_Retur }).ToList();
                dgvDetailRetur.DataSource = dataDetailRetur;
            }
        }

        private void cbTanggalRetur_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTanggalRetur.Checked == true)
            {
                dtpTanggalAwalRetur.Enabled = true;
                dtpTanggalAkhirRetur.Enabled = true;
                labelSDRetur.Enabled = true;
            }
            else
            {
                dtpTanggalAwalRetur.Enabled = false;
                dtpTanggalAkhirRetur.Enabled = false;
                labelSDRetur.Enabled = false;
            }
        }

        private void btnCariRetur_Click(object sender, EventArgs e)
        {
            if (cbTanggalRetur.Checked)
            {
                var hasilSearchRetur = db.tbReturs.Where(x => (x.ID_Retur.Contains(tbCariRetur.Text.ToLower())) && (x.Tanggal_Retur >= dtpTanggalAwalRetur.Value && x.Tanggal_Retur <= dtpTanggalAkhirRetur.Value)).Select(x => x).ToList();
                dgvMasterRetur.DataSource = hasilSearchRetur;
            }
            else
            {
                var hasilSearchRetur = db.tbReturs.Where(x => (x.ID_Retur.Contains(tbCariRetur.Text.ToLower()))).Select(x => x).ToList();
                dgvMasterRetur.DataSource = hasilSearchRetur;
            }
        }

        private void btnTambahRetur_Click(object sender, EventArgs e)
        {
            FormRetur FormRetur = new FormRetur(Username, "", "");
            FormRetur.ShowDialog();
            RefreshDataRetur();
        }

        private void dgvMasterRetur_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvMasterRetur.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("tanggal_retur"))
                {
                    if (e.Value.ToString() != "")
                    {
                        DateTime d = DateTime.Parse(e.Value.ToString());
                        e.Value = d.ToString("dd MMMM yyyy");
                    }
                }
            }
        }

        private void btnUbahDataRetur_Click(object sender, EventArgs e)
        {
            string IDRetur = dgvMasterRetur.SelectedRows[0].Cells["ID_Retur"].Value.ToString();
            string NOFaktur = dgvMasterRetur.SelectedRows[0].Cells["No_Faktur"].Value.ToString();
            FormRetur FormRetur = new FormRetur(Username, IDRetur, NOFaktur);
            FormRetur.ShowDialog();
        }

        private void btnHapusDataRetur_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah anda yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                if (dgvMasterRetur.SelectedRows.Count > 0)
                {
                    string No_Faktur_Selected = dgvMasterRetur.SelectedRows[0].Cells["No_Faktur"].Value.ToString();
                    string ID_Retur_Selected = db.tbReturs.Where(x => x.No_Faktur == No_Faktur_Selected).Select(x => x.ID_Retur).FirstOrDefault();

                    //Delete Detail Retur
                    var dataDetailRetur = db.tbDetailReturs.Where(x => x.ID_Retur == ID_Retur_Selected).ToList();
                    if (dataDetailRetur != null)
                    {
                        foreach (var item in dataDetailRetur)
                        {
                            tbDetailRetur dataDelete = db.tbDetailReturs.Where(x => x.ID_Retur == item.ID_Retur).FirstOrDefault();

                            if (dataDelete != null)
                            {
                                db.tbDetailReturs.DeleteOnSubmit(dataDelete);
                                db.SubmitChanges();
                            }
                        }
                    }

                    //Delete Master Retur
                    tbRetur datadeleteRetur = db.tbReturs.Where(x => x.No_Faktur == No_Faktur_Selected).FirstOrDefault();

                    if (datadeleteRetur != null)
                    {
                        db.tbReturs.DeleteOnSubmit(datadeleteRetur);
                        db.SubmitChanges();
                    }
                }

                RefreshDataRetur();
                dgvDetailRetur.DataSource = "";
            }
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TokoSinarDataSet.ViewReportInventori' table. You can move, or remove it, as needed.
            this.ViewReportInventoriTableAdapter.Fill(this.TokoSinarDataSet.ViewReportInventori);
            // TODO: This line of code loads data into the 'TokoSinarDataSet.ViewReportPenjualan' table. You can move, or remove it, as needed.
            this.ViewReportPenjualanTableAdapter.Fill(this.TokoSinarDataSet.ViewReportPenjualan);
            //// TODO: This line of code loads data into the 'TokoSinarDataSet.ViewReportPembelian' table. You can move, or remove it, as needed.
            this.ViewReportPembelianTableAdapter.Fill(this.TokoSinarDataSet.ViewReportPembelian);

            this.reportViewerPembelian.RefreshReport();
            this.reportViewerPenjualan.RefreshReport();
            this.reportViewerInventori.RefreshReport();
        }

        private void btnLaporanPembelian_Click(object sender, EventArgs e)
        {
            reportViewerPembelian.Visible = true;
            reportViewerPenjualan.Visible = false;
            reportViewerInventori.Visible = false;

            var ListGrandTotal = db.tbPembelians.Where(x => x.Tanggal_Pembelian >= this.dtpTanggalAwalLaporan.Value && x.Tanggal_Pembelian <= this.dtpTanggalAkhirLaporan.Value).Select(x => x.Total_Pembelian).ToList();
            decimal GrandTotal = 0;

            foreach (var item in ListGrandTotal)
            {
                GrandTotal += (decimal)item;
            }

            TokoSinarDataSetTableAdapters.ViewReportPembelianTableAdapter adapter = new TokoSinarDataSetTableAdapters.ViewReportPembelianTableAdapter();
            TokoSinarDataSet.ViewReportPembelianDataTable table = new TokoSinarDataSet.ViewReportPembelianDataTable();

            adapter.FillBy(table, dtpTanggalAwalLaporan.Value.ToString(), dtpTanggalAkhirLaporan.Value.ToString());
            ReportDataSource GetSource = new ReportDataSource("ReportPembelian", (DataTable)table);
            ReportParameter rp1 = new ReportParameter("Tanggal_Awal", this.dtpTanggalAwalLaporan.Value.ToString("dd MMMM yyyy"));
            ReportParameter rp2 = new ReportParameter("Tanggal_Akhir", this.dtpTanggalAkhirPenjualan.Value.ToString("dd MMMM yyyy"));
            ReportParameter rp3 = new ReportParameter("Grand_Total", "Rp " + GrandTotal.ToString("n0") + ".00");
            this.reportViewerPembelian.LocalReport.SetParameters(new ReportParameter[] { rp1 });
            this.reportViewerPembelian.LocalReport.SetParameters(new ReportParameter[] { rp2 });
            this.reportViewerPembelian.LocalReport.SetParameters(new ReportParameter[] { rp3 });

            this.reportViewerPembelian.LocalReport.DataSources.Clear();

            this.reportViewerPembelian.LocalReport.DataSources.Add(GetSource);

            this.reportViewerPembelian.LocalReport.Refresh();

            this.reportViewerPembelian.RefreshReport();
        }

        private void btnLaporanPenjualan_Click(object sender, EventArgs e)
        {
            reportViewerPembelian.Visible = false;
            reportViewerPenjualan.Visible = true;
            reportViewerInventori.Visible = false;

            TokoSinarDataSetTableAdapters.ViewReportPenjualanTableAdapter adapter = new TokoSinarDataSetTableAdapters.ViewReportPenjualanTableAdapter();
            TokoSinarDataSet.ViewReportPenjualanDataTable table = new TokoSinarDataSet.ViewReportPenjualanDataTable();

            adapter.FillBy(table, dtpTanggalAwalLaporan.Value, dtpTanggalAkhirLaporan.Value);
            ReportDataSource GetSource = new ReportDataSource("ReportPenjualan", (DataTable)table);
            ReportParameter rp1 = new ReportParameter("Tanggal_Awal", this.dtpTanggalAwalLaporan.Value.ToString("dd MMMM yyyy"));
            ReportParameter rp2 = new ReportParameter("Tanggal_Akhir", this.dtpTanggalAkhirLaporan.Value.ToString("dd MMMM yyyy"));
            this.reportViewerPenjualan.LocalReport.SetParameters(new ReportParameter[] { rp1 });
            this.reportViewerPenjualan.LocalReport.SetParameters(new ReportParameter[] { rp2 });

            this.reportViewerPenjualan.LocalReport.DataSources.Clear();

            this.reportViewerPenjualan.LocalReport.DataSources.Add(GetSource);

            this.reportViewerPenjualan.LocalReport.Refresh();

            this.reportViewerPenjualan.RefreshReport();
        }

        private void btnLaporanInventori_Click(object sender, EventArgs e)
        {
            reportViewerPembelian.Visible = false;
            reportViewerPenjualan.Visible = false;
            reportViewerInventori.Visible = true;

            TokoSinarDataSetTableAdapters.ViewReportInventoriTableAdapter adapter = new TokoSinarDataSetTableAdapters.ViewReportInventoriTableAdapter();
            TokoSinarDataSet.ViewReportPenjualanDataTable table = new TokoSinarDataSet.ViewReportPenjualanDataTable();

            //adapter.FillBy(table, dtpTanggalAwalLaporan.Value, dtpTanggalAkhirLaporan.Value);
            ReportDataSource GetSource = new ReportDataSource("ReportPenjualan", (DataTable)table);
            //ReportParameter rp1 = new ReportParameter("Tanggal_Awal", this.dtpTanggalAwalLaporan.Value.ToString("dd MMMM yyyy"));
            //ReportParameter rp2 = new ReportParameter("Tanggal_Akhir", this.dtpTanggalAkhirLaporan.Value.ToString("dd MMMM yyyy"));
            //this.reportViewerPenjualan.LocalReport.SetParameters(new ReportParameter[] { rp1 });
            //this.reportViewerPenjualan.LocalReport.SetParameters(new ReportParameter[] { rp2 });

            this.reportViewerPenjualan.LocalReport.DataSources.Clear();

            this.reportViewerPenjualan.LocalReport.DataSources.Add(GetSource);

            this.reportViewerPenjualan.LocalReport.Refresh();

            this.reportViewerPenjualan.RefreshReport();
        }
    }
}
