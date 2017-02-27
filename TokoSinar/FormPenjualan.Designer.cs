namespace TokoSinar
{
    partial class FormPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpTanggalPenjualan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdPenjualan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalPenjualan = new System.Windows.Forms.Label();
            this.listBoxBarang = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCariBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetailPenjualan = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.tbHargaKhusus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbHargaBeli = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1184, 1004);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Penjualan";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpTanggalPenjualan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbIdPenjualan);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelTotalPenjualan);
            this.panel2.Controls.Add(this.listBoxBarang);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbCariBarang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 946);
            this.panel2.TabIndex = 16;
            // 
            // dtpTanggalPenjualan
            // 
            this.dtpTanggalPenjualan.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalPenjualan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalPenjualan.Location = new System.Drawing.Point(202, 48);
            this.dtpTanggalPenjualan.Name = "dtpTanggalPenjualan";
            this.dtpTanggalPenjualan.Size = new System.Drawing.Size(200, 30);
            this.dtpTanggalPenjualan.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tanggal Penjualan :";
            // 
            // tbIdPenjualan
            // 
            this.tbIdPenjualan.Location = new System.Drawing.Point(202, 6);
            this.tbIdPenjualan.Name = "tbIdPenjualan";
            this.tbIdPenjualan.ReadOnly = true;
            this.tbIdPenjualan.Size = new System.Drawing.Size(196, 30);
            this.tbIdPenjualan.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID Penjualan :";
            // 
            // labelTotalPenjualan
            // 
            this.labelTotalPenjualan.AutoSize = true;
            this.labelTotalPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPenjualan.Location = new System.Drawing.Point(131, 83);
            this.labelTotalPenjualan.Name = "labelTotalPenjualan";
            this.labelTotalPenjualan.Size = new System.Drawing.Size(27, 29);
            this.labelTotalPenjualan.TabIndex = 17;
            this.labelTotalPenjualan.Text = "0";
            // 
            // listBoxBarang
            // 
            this.listBoxBarang.FormattingEnabled = true;
            this.listBoxBarang.ItemHeight = 25;
            this.listBoxBarang.Location = new System.Drawing.Point(12, 191);
            this.listBoxBarang.Name = "listBoxBarang";
            this.listBoxBarang.Size = new System.Drawing.Size(386, 729);
            this.listBoxBarang.TabIndex = 21;
            this.listBoxBarang.SelectedIndexChanged += new System.EventHandler(this.listBoxBarang_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "List Barang :";
            // 
            // tbCariBarang
            // 
            this.tbCariBarang.Location = new System.Drawing.Point(72, 115);
            this.tbCariBarang.Name = "tbCariBarang";
            this.tbCariBarang.Size = new System.Drawing.Size(326, 30);
            this.tbCariBarang.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cari :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tbHargaBeli);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.dgvDetailPenjualan);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnSelesai);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnBatal);
            this.panel1.Controls.Add(this.tbHargaKhusus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbNamaBarang);
            this.panel1.Controls.Add(this.tbHarga);
            this.panel1.Controls.Add(this.nudQty);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Location = new System.Drawing.Point(457, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 946);
            this.panel1.TabIndex = 11;
            // 
            // dgvDetailPenjualan
            // 
            this.dgvDetailPenjualan.AllowUserToAddRows = false;
            this.dgvDetailPenjualan.AllowUserToDeleteRows = false;
            this.dgvDetailPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPenjualan.Location = new System.Drawing.Point(7, 292);
            this.dgvDetailPenjualan.Name = "dgvDetailPenjualan";
            this.dgvDetailPenjualan.ReadOnly = true;
            this.dgvDetailPenjualan.RowTemplate.Height = 24;
            this.dgvDetailPenjualan.Size = new System.Drawing.Size(707, 584);
            this.dgvDetailPenjualan.TabIndex = 13;
            this.dgvDetailPenjualan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailPenjualan_CellFormatting);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(159, 121);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "Rp.";
            // 
            // btnSelesai
            // 
            this.btnSelesai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelesai.Location = new System.Drawing.Point(423, 883);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(142, 57);
            this.btnSelesai.TabIndex = 14;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Rp.";
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatal.Location = new System.Drawing.Point(573, 883);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(141, 57);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // tbHargaKhusus
            // 
            this.tbHargaKhusus.Location = new System.Drawing.Point(208, 118);
            this.tbHargaKhusus.Margin = new System.Windows.Forms.Padding(4);
            this.tbHargaKhusus.Name = "tbHargaKhusus";
            this.tbHargaKhusus.Size = new System.Drawing.Size(156, 30);
            this.tbHargaKhusus.TabIndex = 7;
            this.tbHargaKhusus.Text = "0";
            this.tbHargaKhusus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHargaKhusus_KeyPress);
            this.tbHargaKhusus.Leave += new System.EventHandler(this.tbHargaKhusus_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nama Barang :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 121);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Harga Khusus:";
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(159, 6);
            this.tbNamaBarang.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.ReadOnly = true;
            this.tbNamaBarang.Size = new System.Drawing.Size(279, 30);
            this.tbNamaBarang.TabIndex = 1;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(208, 80);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(4);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.Size = new System.Drawing.Size(156, 30);
            this.tbHarga.TabIndex = 4;
            this.tbHarga.Text = "0";
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(164, 159);
            this.nudQty.Margin = new System.Windows.Forms.Padding(4);
            this.nudQty.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(71, 30);
            this.nudQty.TabIndex = 9;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Harga Jual :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Qty :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 264);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Detail Penjualan :";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(8, 216);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 42);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(116, 216);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 44);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(159, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "Rp.";
            // 
            // tbHargaBeli
            // 
            this.tbHargaBeli.Location = new System.Drawing.Point(208, 44);
            this.tbHargaBeli.Margin = new System.Windows.Forms.Padding(4);
            this.tbHargaBeli.Name = "tbHargaBeli";
            this.tbHargaBeli.ReadOnly = true;
            this.tbHargaBeli.Size = new System.Drawing.Size(156, 30);
            this.tbHargaBeli.TabIndex = 18;
            this.tbHargaBeli.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 47);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "Harga Beli :";
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 1037);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDetailPenjualan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox tbHargaKhusus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTotalPenjualan;
        private System.Windows.Forms.ListBox listBoxBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCariBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdPenjualan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTanggalPenjualan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbHargaBeli;
        private System.Windows.Forms.Label label15;
    }
}