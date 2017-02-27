namespace TokoSinar
{
    partial class FormRetur
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
            this.groupBoxDataPembelian = new System.Windows.Forms.GroupBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.dtpTanggalAkhirPembelian = new System.Windows.Forms.DateTimePicker();
            this.LabelSDPembelian = new System.Windows.Forms.Label();
            this.dtpTanggalAwalPembelian = new System.Windows.Forms.DateTimePicker();
            this.cbTanggalPembelian = new System.Windows.Forms.CheckBox();
            this.tbCariDataPembelian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPilihPembelian = new System.Windows.Forms.Button();
            this.dgvDetailPembelian = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.groupBoxDataRetur = new System.Windows.Forms.GroupBox();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.dgvDetailRetur = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetailPembelianRetur = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.nudJumlahRetur = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTanggalRetur = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.ID_Retur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDataPembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            this.groupBoxDataRetur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRetur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelianRetur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahRetur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDataPembelian
            // 
            this.groupBoxDataPembelian.Controls.Add(this.btnCari);
            this.groupBoxDataPembelian.Controls.Add(this.dtpTanggalAkhirPembelian);
            this.groupBoxDataPembelian.Controls.Add(this.LabelSDPembelian);
            this.groupBoxDataPembelian.Controls.Add(this.dtpTanggalAwalPembelian);
            this.groupBoxDataPembelian.Controls.Add(this.cbTanggalPembelian);
            this.groupBoxDataPembelian.Controls.Add(this.tbCariDataPembelian);
            this.groupBoxDataPembelian.Controls.Add(this.label2);
            this.groupBoxDataPembelian.Controls.Add(this.btnPilihPembelian);
            this.groupBoxDataPembelian.Controls.Add(this.dgvDetailPembelian);
            this.groupBoxDataPembelian.Controls.Add(this.label1);
            this.groupBoxDataPembelian.Controls.Add(this.dgvPembelian);
            this.groupBoxDataPembelian.Location = new System.Drawing.Point(13, 14);
            this.groupBoxDataPembelian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDataPembelian.Name = "groupBoxDataPembelian";
            this.groupBoxDataPembelian.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDataPembelian.Size = new System.Drawing.Size(927, 824);
            this.groupBoxDataPembelian.TabIndex = 0;
            this.groupBoxDataPembelian.TabStop = false;
            this.groupBoxDataPembelian.Text = "Data Pembelian";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(690, 63);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(86, 35);
            this.btnCari.TabIndex = 10;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // dtpTanggalAkhirPembelian
            // 
            this.dtpTanggalAkhirPembelian.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAkhirPembelian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAkhirPembelian.Location = new System.Drawing.Point(475, 63);
            this.dtpTanggalAkhirPembelian.Name = "dtpTanggalAkhirPembelian";
            this.dtpTanggalAkhirPembelian.Size = new System.Drawing.Size(209, 30);
            this.dtpTanggalAkhirPembelian.TabIndex = 9;
            // 
            // LabelSDPembelian
            // 
            this.LabelSDPembelian.AutoSize = true;
            this.LabelSDPembelian.Location = new System.Drawing.Point(430, 67);
            this.LabelSDPembelian.Name = "LabelSDPembelian";
            this.LabelSDPembelian.Size = new System.Drawing.Size(39, 25);
            this.LabelSDPembelian.TabIndex = 8;
            this.LabelSDPembelian.Text = "s/d";
            // 
            // dtpTanggalAwalPembelian
            // 
            this.dtpTanggalAwalPembelian.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAwalPembelian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAwalPembelian.Location = new System.Drawing.Point(216, 63);
            this.dtpTanggalAwalPembelian.Name = "dtpTanggalAwalPembelian";
            this.dtpTanggalAwalPembelian.Size = new System.Drawing.Size(208, 30);
            this.dtpTanggalAwalPembelian.TabIndex = 7;
            // 
            // cbTanggalPembelian
            // 
            this.cbTanggalPembelian.AutoSize = true;
            this.cbTanggalPembelian.Location = new System.Drawing.Point(7, 67);
            this.cbTanggalPembelian.Name = "cbTanggalPembelian";
            this.cbTanggalPembelian.Size = new System.Drawing.Size(203, 29);
            this.cbTanggalPembelian.TabIndex = 6;
            this.cbTanggalPembelian.Text = "Tanggal Pembelian";
            this.cbTanggalPembelian.UseVisualStyleBackColor = true;
            this.cbTanggalPembelian.CheckedChanged += new System.EventHandler(this.cbTanggalPembelian_CheckedChanged);
            // 
            // tbCariDataPembelian
            // 
            this.tbCariDataPembelian.Location = new System.Drawing.Point(72, 29);
            this.tbCariDataPembelian.Name = "tbCariDataPembelian";
            this.tbCariDataPembelian.Size = new System.Drawing.Size(190, 30);
            this.tbCariDataPembelian.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cari :";
            // 
            // btnPilihPembelian
            // 
            this.btnPilihPembelian.Location = new System.Drawing.Point(7, 105);
            this.btnPilihPembelian.Name = "btnPilihPembelian";
            this.btnPilihPembelian.Size = new System.Drawing.Size(153, 44);
            this.btnPilihPembelian.TabIndex = 3;
            this.btnPilihPembelian.Text = "Pilih Pembelian";
            this.btnPilihPembelian.UseVisualStyleBackColor = true;
            this.btnPilihPembelian.Click += new System.EventHandler(this.btnPilihPembelian_Click);
            // 
            // dgvDetailPembelian
            // 
            this.dgvDetailPembelian.AllowUserToAddRows = false;
            this.dgvDetailPembelian.AllowUserToDeleteRows = false;
            this.dgvDetailPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPembelian.Location = new System.Drawing.Point(7, 527);
            this.dgvDetailPembelian.Name = "dgvDetailPembelian";
            this.dgvDetailPembelian.ReadOnly = true;
            this.dgvDetailPembelian.RowTemplate.Height = 24;
            this.dgvDetailPembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailPembelian.Size = new System.Drawing.Size(900, 289);
            this.dgvDetailPembelian.TabIndex = 2;
            this.dgvDetailPembelian.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailPembelian_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detail Pembelian";
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.AllowUserToAddRows = false;
            this.dgvPembelian.AllowUserToDeleteRows = false;
            this.dgvPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelian.Location = new System.Drawing.Point(7, 155);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.ReadOnly = true;
            this.dgvPembelian.RowTemplate.Height = 24;
            this.dgvPembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPembelian.Size = new System.Drawing.Size(900, 341);
            this.dgvPembelian.TabIndex = 0;
            this.dgvPembelian.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPembelian_CellFormatting);
            this.dgvPembelian.SelectionChanged += new System.EventHandler(this.dgvPembelian_SelectionChanged);
            // 
            // groupBoxDataRetur
            // 
            this.groupBoxDataRetur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDataRetur.Controls.Add(this.btnHapus);
            this.groupBoxDataRetur.Controls.Add(this.btnSelesai);
            this.groupBoxDataRetur.Controls.Add(this.dgvDetailRetur);
            this.groupBoxDataRetur.Controls.Add(this.label5);
            this.groupBoxDataRetur.Controls.Add(this.dgvDetailPembelianRetur);
            this.groupBoxDataRetur.Controls.Add(this.btnTambah);
            this.groupBoxDataRetur.Controls.Add(this.nudJumlahRetur);
            this.groupBoxDataRetur.Controls.Add(this.label4);
            this.groupBoxDataRetur.Controls.Add(this.dtpTanggalRetur);
            this.groupBoxDataRetur.Controls.Add(this.label3);
            this.groupBoxDataRetur.Location = new System.Drawing.Point(947, 14);
            this.groupBoxDataRetur.Name = "groupBoxDataRetur";
            this.groupBoxDataRetur.Size = new System.Drawing.Size(955, 824);
            this.groupBoxDataRetur.TabIndex = 1;
            this.groupBoxDataRetur.TabStop = false;
            this.groupBoxDataRetur.Text = "Data Retur";
            // 
            // btnSelesai
            // 
            this.btnSelesai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelesai.Location = new System.Drawing.Point(853, 94);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(96, 47);
            this.btnSelesai.TabIndex = 18;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // dgvDetailRetur
            // 
            this.dgvDetailRetur.AllowUserToAddRows = false;
            this.dgvDetailRetur.AllowUserToDeleteRows = false;
            this.dgvDetailRetur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailRetur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailRetur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailRetur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Retur});
            this.dgvDetailRetur.Location = new System.Drawing.Point(11, 562);
            this.dgvDetailRetur.Name = "dgvDetailRetur";
            this.dgvDetailRetur.ReadOnly = true;
            this.dgvDetailRetur.RowTemplate.Height = 24;
            this.dgvDetailRetur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailRetur.Size = new System.Drawing.Size(938, 254);
            this.dgvDetailRetur.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "DetailRetur";
            // 
            // dgvDetailPembelianRetur
            // 
            this.dgvDetailPembelianRetur.AllowUserToAddRows = false;
            this.dgvDetailPembelianRetur.AllowUserToDeleteRows = false;
            this.dgvDetailPembelianRetur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailPembelianRetur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailPembelianRetur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPembelianRetur.Location = new System.Drawing.Point(11, 155);
            this.dgvDetailPembelianRetur.Name = "dgvDetailPembelianRetur";
            this.dgvDetailPembelianRetur.ReadOnly = true;
            this.dgvDetailPembelianRetur.RowTemplate.Height = 24;
            this.dgvDetailPembelianRetur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailPembelianRetur.Size = new System.Drawing.Size(938, 327);
            this.dgvDetailPembelianRetur.TabIndex = 15;
            this.dgvDetailPembelianRetur.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailPembelianRetur_CellFormatting);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(11, 97);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(96, 47);
            this.btnTambah.TabIndex = 14;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // nudJumlahRetur
            // 
            this.nudJumlahRetur.Location = new System.Drawing.Point(158, 65);
            this.nudJumlahRetur.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudJumlahRetur.Name = "nudJumlahRetur";
            this.nudJumlahRetur.Size = new System.Drawing.Size(95, 30);
            this.nudJumlahRetur.TabIndex = 13;
            this.nudJumlahRetur.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jumlah Retur :";
            // 
            // dtpTanggalRetur
            // 
            this.dtpTanggalRetur.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalRetur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalRetur.Location = new System.Drawing.Point(158, 29);
            this.dtpTanggalRetur.Name = "dtpTanggalRetur";
            this.dtpTanggalRetur.Size = new System.Drawing.Size(209, 30);
            this.dtpTanggalRetur.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tanggal Retur :";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(11, 513);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(116, 43);
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // ID_Retur
            // 
            this.ID_Retur.DataPropertyName = "ID_Retur";
            this.ID_Retur.HeaderText = "ID_Retur";
            this.ID_Retur.Name = "ID_Retur";
            this.ID_Retur.ReadOnly = true;
            this.ID_Retur.Visible = false;
            // 
            // FormRetur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 852);
            this.Controls.Add(this.groupBoxDataRetur);
            this.Controls.Add(this.groupBoxDataPembelian);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxDataPembelian.ResumeLayout(false);
            this.groupBoxDataPembelian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            this.groupBoxDataRetur.ResumeLayout(false);
            this.groupBoxDataRetur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRetur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelianRetur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahRetur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataPembelian;
        private System.Windows.Forms.DataGridView dgvPembelian;
        private System.Windows.Forms.DataGridView dgvDetailPembelian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSDPembelian;
        private System.Windows.Forms.DateTimePicker dtpTanggalAwalPembelian;
        private System.Windows.Forms.CheckBox cbTanggalPembelian;
        private System.Windows.Forms.TextBox tbCariDataPembelian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPilihPembelian;
        private System.Windows.Forms.GroupBox groupBoxDataRetur;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhirPembelian;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.DataGridView dgvDetailPembelianRetur;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.NumericUpDown nudJumlahRetur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTanggalRetur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.DataGridView dgvDetailRetur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Retur;
    }
}