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
    public partial class FormRetur : Form
    {
        TokoSinarDB db = new TokoSinarDB();
        string Username;
        string IDRetur;
        string NoFaktur;
        List<tbDetailRetur> ListDetailRetur = new List<tbDetailRetur>();
        string Status;
        
        public FormRetur()
        {
            InitializeComponent();

            groupBoxDataRetur.Enabled = false;
            cbTanggalPembelian.Checked = false;
            dtpTanggalAkhirPembelian.Enabled = false;
            dtpTanggalAwalPembelian.Enabled = false;
            LabelSDPembelian.Enabled = false;

            dgvPembelian.DataSource = db.tbPembelians.Select(x => new { No_Faktur = x.No_Faktur, Tanggal_Faktur = x.Tanggal_Pembelian, Cara_Bayar = x.CaraBayar, Nama_Supplier = x.tbSupplier.Nama_Supplier, Salesman = x.Salesman, Jatuh_Tempo = x.JatuhTempo, Sub_Total = x.Sub_Total, PPN = x.PPN, Total_Pembayaran = x.Total_Pembelian, Nama_Karyawan = x.tbKaryawan.Nama, Status = x.Status == true ? "Lunas" : "Belum Lunas" }).ToList();
        }

        public FormRetur(string username, string idRetur, string noFaktur)
        {
            InitializeComponent();

            groupBoxDataRetur.Enabled = false;
            cbTanggalPembelian.Checked = false;
            dtpTanggalAkhirPembelian.Enabled = false;
            dtpTanggalAwalPembelian.Enabled = false;
            LabelSDPembelian.Enabled = false;

            Username = username;
            NoFaktur = noFaktur;

            if (idRetur == "" && NoFaktur == "") //Tambah
            {
                IDRetur = db.FC_AutoIDRetur();
                Status = "Baru";

                groupBoxDataRetur.Enabled = false;
                groupBoxDataPembelian.Enabled = true;
                dgvDetailRetur.DataSource = "";
                dgvDetailPembelianRetur.DataSource = "";
            }
            else //Ubah
            {
                IDRetur = idRetur;
                Status = "Ubah";

                groupBoxDataRetur.Enabled = true;
                groupBoxDataPembelian.Enabled = false;

                dgvDetailPembelianRetur.DataSource = db.tbDetailPembelians.Where(x => x.No_Faktur == NoFaktur).Select(x => new { ID_Barang = x.ID_Barang, Nama_Barang = x.Nama_Barang, Harga_Beli = x.Harga_Beli, Diskon = x.Diskon, Jumlah_Beli = x.Jumlah_Beli, Sub_Total = x.Sub_Total }).ToList();
                dgvDetailRetur.DataSource = db.tbDetailReturs.Where(x => x.ID_Retur == IDRetur).Select(x => new {ID_Barang = x.ID_Barang, Jumlah_Retur = x.Jumlah_Retur, ID_Retur = x.ID_Retur }).ToList();
            }

            dgvPembelian.DataSource = db.tbPembelians.Select(x => new { No_Faktur = x.No_Faktur, Tanggal_Faktur = x.Tanggal_Pembelian, Cara_Bayar = x.CaraBayar, Nama_Supplier = x.tbSupplier.Nama_Supplier, Salesman = x.Salesman, Jatuh_Tempo = x.JatuhTempo, Sub_Total = x.Sub_Total, PPN = x.PPN, Total_Pembayaran = x.Total_Pembelian, Nama_Karyawan = x.tbKaryawan.Nama, Status = x.Status == true ? "Lunas" : "Belum Lunas" }).ToList();
        }

        private void dgvPembelian_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPembelian.SelectedRows.Count > 0)
            {
                string idPembelian = dgvPembelian.SelectedRows[0].Cells["No_Faktur"].Value.ToString();

                var dataDetailPembelian = db.tbDetailPembelians.Where(x => x.No_Faktur == idPembelian).Select(x => new { Nama_Barang = x.Nama_Barang, Harga_Beli = x.Harga_Beli, Diskon = x.Diskon, Jumlah_Beli = x.Jumlah_Beli, Sub_Total = x.Sub_Total }).ToList();
                dgvDetailPembelian.DataSource = dataDetailPembelian;
            }
        }

        private void btnPilihPembelian_Click(object sender, EventArgs e)
        {
            if (dgvPembelian.SelectedRows.Count > 0)
            {
                NoFaktur = dgvPembelian.SelectedRows[0].Cells["No_Faktur"].Value.ToString();
            }

            groupBoxDataRetur.Enabled = true;
            groupBoxDataPembelian.Enabled = false;
            dgvDetailPembelianRetur.DataSource = db.tbDetailPembelians.Where(x => x.No_Faktur == NoFaktur).Select(x => new { ID_Barang = x.ID_Barang, Nama_Barang = x.Nama_Barang, Harga_Beli = x.Harga_Beli, Diskon = x.Diskon, Jumlah_Beli = x.Jumlah_Beli, Sub_Total = x.Sub_Total }).ToList();
        }

        private void cbTanggalPembelian_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTanggalPembelian.Checked == true)
            {
                dtpTanggalAwalPembelian.Enabled = true;
                dtpTanggalAkhirPembelian.Enabled = true;
                LabelSDPembelian.Enabled = true;
            }
            else
            {
                dtpTanggalAwalPembelian.Enabled = false;
                dtpTanggalAkhirPembelian.Enabled = false;
                LabelSDPembelian.Enabled = false;
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cbTanggalPembelian.Checked)
            {
                var hasilSearchPembelian = db.tbPembelians.Where(x => (x.No_Faktur.Contains(tbCariDataPembelian.Text.ToLower()) || x.tbSupplier.Nama_Supplier.ToLower().Contains(tbCariDataPembelian.Text.ToLower())) && (x.Tanggal_Pembelian >= dtpTanggalAwalPembelian.Value && x.Tanggal_Pembelian <= dtpTanggalAkhirPembelian.Value)).Select(x => new { x.No_Faktur, x.Tanggal_Pembelian, x.CaraBayar, x.tbSupplier.Nama_Supplier, x.Salesman, x.JatuhTempo, x.Sub_Total, x.PPN, x.Total_Pembelian, x.tbKaryawan.Nama, Status = x.Status == true ? "Lunas" : "Belum Lunas" }).ToList();
                dgvPembelian.DataSource = hasilSearchPembelian;
            }
            else
            {
                var hasilSearchPembelian = db.tbPembelians.Where(x => (x.No_Faktur.Contains(tbCariDataPembelian.Text.ToLower()) || x.tbSupplier.Nama_Supplier.ToLower().Contains(tbCariDataPembelian.Text.ToLower()))).Select(x => new { x.No_Faktur, x.Tanggal_Pembelian, x.CaraBayar, x.tbSupplier.Nama_Supplier, x.Salesman, x.JatuhTempo, x.Sub_Total, x.PPN, x.Total_Pembelian, x.tbKaryawan.Nama, Status = x.Status == true ? "Lunas" : "Belum Lunas" }).ToList();
                dgvPembelian.DataSource = hasilSearchPembelian;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tbDetailRetur TDetailRetur = new tbDetailRetur();


            if (Status == "Baru")
            {
                TDetailRetur.ID_Barang = dgvDetailPembelianRetur.SelectedRows[0].Cells["ID_Barang"].Value.ToString();
                TDetailRetur.ID_Retur = IDRetur;

                int jumlah_beli = (int)dgvDetailPembelianRetur.SelectedRows[0].Cells["Jumlah_Beli"].Value;
                if (nudJumlahRetur.Value > jumlah_beli)
                {
                    MessageBox.Show("Jumlah yang akan diretur melebihi jumlah yang dibeli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TDetailRetur.Jumlah_Retur = (int)nudJumlahRetur.Value;

                    tbRetur TRetur = new tbRetur();
                    TRetur.ID_Retur = IDRetur;
                    TRetur.No_Faktur = NoFaktur;
                    TRetur.Tanggal_Retur = dtpTanggalRetur.Value;

                    db.tbReturs.InsertOnSubmit(TRetur);
                    db.SubmitChanges();

                    db.tbDetailReturs.InsertOnSubmit(TDetailRetur);
                    db.SubmitChanges();
                }
            }
            else
            {
                TDetailRetur.ID_Barang = dgvDetailPembelianRetur.SelectedRows[0].Cells["ID_Barang"].Value.ToString();
                TDetailRetur.ID_Retur = IDRetur;

                int jumlah_beli = (int)dgvDetailPembelianRetur.SelectedRows[0].Cells["Jumlah_Beli"].Value;
                if (nudJumlahRetur.Value > jumlah_beli)
                {
                    MessageBox.Show("Jumlah yang akan diretur melebihi jumlah yang dibeli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TDetailRetur.Jumlah_Retur = (int)nudJumlahRetur.Value;

                    tbRetur TRetur = new tbRetur();
                    TRetur.ID_Retur = IDRetur;
                    TRetur.No_Faktur = NoFaktur;
                    TRetur.Tanggal_Retur = dtpTanggalRetur.Value;
                    db.SubmitChanges();

                    db.tbDetailReturs.InsertOnSubmit(TDetailRetur);
                    db.SubmitChanges();
                }
            }

            dgvDetailRetur.DataSource = "";
            dgvDetailRetur.DataSource = db.tbDetailReturs.Where(x=>x.ID_Retur == IDRetur).Select(x => new {ID_Barang = x.ID_Barang, Jumlah_Retur = x.Jumlah_Retur, ID_Retur = x.ID_Retur }).ToList();

        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Data Retur Berhasil disimpan");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Data Retur Tidak Berhasil disimpan");
            }
        }

        private void dgvPembelian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("sub_total") || dgvPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("total_pembayaran"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
                if (dgvPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("tanggal_faktur") || dgvPembelian.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("jatuh_tempo"))
                {
                    if (e.Value.ToString() != "")
                    {
                        DateTime d = DateTime.Parse(e.Value.ToString());
                        e.Value = d.ToString("dd MMMM yyyy");
                    }
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

        private void dgvDetailPembelianRetur_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPembelianRetur.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("harga_beli") || dgvDetailPembelianRetur.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("sub_total"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDetailRetur.SelectedRows.Count > 0)
            {
                string IDRetur = dgvDetailRetur.SelectedRows[0].Cells["ID_Retur"].Value.ToString();

                tbDetailRetur dataDetailRetur = db.tbDetailReturs.Where(x => x.ID_Retur == IDRetur).FirstOrDefault();
                if (dataDetailRetur != null)
                {
                    db.tbDetailReturs.DeleteOnSubmit(dataDetailRetur);
                    db.SubmitChanges();
                    MessageBox.Show("Data Detail Retur berhasil dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvDetailRetur.DataSource = db.tbDetailReturs.Where(x=>x.ID_Retur == IDRetur).Select(x => new { ID_Barang = x.ID_Barang, Jumlah_Retur = x.Jumlah_Retur, ID_Retur = x.ID_Retur }).ToList();
                }
            }
        }
    }
}
