namespace TokoSinar
{
    partial class FormMenuUtama
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ViewReportInventoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TokoSinarDataSet = new TokoSinar.TokoSinarDataSet();
            this.ViewReportPenjualanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewReportPembelianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNama = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUbahPassword = new System.Windows.Forms.Label();
            this.panelPembelian = new System.Windows.Forms.Panel();
            this.groupBoxPembelian = new System.Windows.Forms.GroupBox();
            this.btnCariPembelian = new System.Windows.Forms.Button();
            this.dtpTanggalAkhirCariPembelian = new System.Windows.Forms.DateTimePicker();
            this.labelSDPembelian = new System.Windows.Forms.Label();
            this.dtpTanggalAwalCariPembelian = new System.Windows.Forms.DateTimePicker();
            this.cbTanggalFakturPembelian = new System.Windows.Forms.CheckBox();
            this.tbCariPembelian = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUbahStatus = new System.Windows.Forms.Button();
            this.dgvDetailPembelian = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMasterPembelian = new System.Windows.Forms.DataGridView();
            this.btnHapusPembelian = new System.Windows.Forms.Button();
            this.btnUbahPembelian = new System.Windows.Forms.Button();
            this.btnPembelianBaru = new System.Windows.Forms.Button();
            this.labelTanggalJam = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPembelian = new System.Windows.Forms.Button();
            this.btnOlahKaryawan = new System.Windows.Forms.Button();
            this.panelOlahKaryawan = new System.Windows.Forms.Panel();
            this.groupBoxKayawan = new System.Windows.Forms.GroupBox();
            this.btnResetPasswordKaryawan = new System.Windows.Forms.Button();
            this.btnHapusDataKaryawan = new System.Windows.Forms.Button();
            this.tbCariKaryawan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUbahDataKaryawan = new System.Windows.Forms.Button();
            this.groupBoxTambahUbahKaryawan = new System.Windows.Forms.GroupBox();
            this.btnSimpanKaryawan = new System.Windows.Forms.Button();
            this.cbStatusKaryawan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbJenisKaryawan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAlamatKaryawan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNamaKaryawan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsernameKaryawan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMasterKaryawan = new System.Windows.Forms.DataGridView();
            this.btnTambahKaryawan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCariSupplier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUbahDataSupplier = new System.Windows.Forms.Button();
            this.groupBoxTambahUbahSupplier = new System.Windows.Forms.GroupBox();
            this.tbTelpSupplier = new System.Windows.Forms.TextBox();
            this.btnSimpanSupplier = new System.Windows.Forms.Button();
            this.cbStatusSupplier = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAlamatSupplier = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNamaSupplier = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbKodeSupplier = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvMasterSupplier = new System.Windows.Forms.DataGridView();
            this.btnTambahSupplierBaru = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOlahBarang = new System.Windows.Forms.Button();
            this.panelBarang = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCariBarang = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnUbahDataBarang = new System.Windows.Forms.Button();
            this.groupBoxTambahUbahBarang = new System.Windows.Forms.GroupBox();
            this.groupBoxSupplierBaru = new System.Windows.Forms.GroupBox();
            this.cbNamaSupplier = new System.Windows.Forms.ComboBox();
            this.tbNoTelpSupplier = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbAlamatSupplierBarang = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.radioSupplierBaru = new System.Windows.Forms.RadioButton();
            this.radioSupplierLama = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbHargaJualBarang = new System.Windows.Forms.TextBox();
            this.tbHargaBeliBarang = new System.Windows.Forms.TextBox();
            this.btnSimpanBarang = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbSatuanBarang = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvMasterBarang = new System.Windows.Forms.DataGridView();
            this.btnTambahBarangBaru = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.panelPenjualan = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCariPenjualan = new System.Windows.Forms.Button();
            this.dtpTanggalAkhirPenjualan = new System.Windows.Forms.DateTimePicker();
            this.labelSDPenjualan = new System.Windows.Forms.Label();
            this.dtpTanggalAwalPenjualan = new System.Windows.Forms.DateTimePicker();
            this.cbTanggalPenjualan = new System.Windows.Forms.CheckBox();
            this.tbCariPenjualan = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dgvDetailPenjualan = new System.Windows.Forms.DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.dgvMasterPenjualan = new System.Windows.Forms.DataGridView();
            this.btnHapusPenjualan = new System.Windows.Forms.Button();
            this.btnUbahPenjualan = new System.Windows.Forms.Button();
            this.btnPenjualanBaru = new System.Windows.Forms.Button();
            this.panelRetur = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCariRetur = new System.Windows.Forms.Button();
            this.dtpTanggalAkhirRetur = new System.Windows.Forms.DateTimePicker();
            this.labelSDRetur = new System.Windows.Forms.Label();
            this.dtpTanggalAwalRetur = new System.Windows.Forms.DateTimePicker();
            this.cbTanggalRetur = new System.Windows.Forms.CheckBox();
            this.tbCariRetur = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.dgvDetailRetur = new System.Windows.Forms.DataGridView();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.dgvMasterRetur = new System.Windows.Forms.DataGridView();
            this.btnHapusDataRetur = new System.Windows.Forms.Button();
            this.btnUbahDataRetur = new System.Windows.Forms.Button();
            this.btnTambahRetur = new System.Windows.Forms.Button();
            this.btnRetur = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.panelLaporan = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.reportViewerInventori = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerPenjualan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerPembelian = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpTanggalAkhirLaporan = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.dtpTanggalAwalLaporan = new System.Windows.Forms.DateTimePicker();
            this.label37 = new System.Windows.Forms.Label();
            this.btnLaporanInventori = new System.Windows.Forms.Button();
            this.btnLaporanPenjualan = new System.Windows.Forms.Button();
            this.btnLaporanPembelian = new System.Windows.Forms.Button();
            this.ViewReportPembelianTableAdapter = new TokoSinar.TokoSinarDataSetTableAdapters.ViewReportPembelianTableAdapter();
            this.ViewReportPenjualanTableAdapter = new TokoSinar.TokoSinarDataSetTableAdapters.ViewReportPenjualanTableAdapter();
            this.ViewReportInventoriTableAdapter = new TokoSinar.TokoSinarDataSetTableAdapters.ViewReportInventoriTableAdapter();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportInventoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TokoSinarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportPenjualanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportPembelianBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelPembelian.SuspendLayout();
            this.groupBoxPembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterPembelian)).BeginInit();
            this.panelOlahKaryawan.SuspendLayout();
            this.groupBoxKayawan.SuspendLayout();
            this.groupBoxTambahUbahKaryawan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterKaryawan)).BeginInit();
            this.panelSupplier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTambahUbahSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSupplier)).BeginInit();
            this.panelBarang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTambahUbahBarang.SuspendLayout();
            this.groupBoxSupplierBaru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterBarang)).BeginInit();
            this.panelPenjualan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterPenjualan)).BeginInit();
            this.panelRetur.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRetur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterRetur)).BeginInit();
            this.panelLaporan.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewReportInventoriBindingSource
            // 
            this.ViewReportInventoriBindingSource.DataMember = "ViewReportInventori";
            this.ViewReportInventoriBindingSource.DataSource = this.TokoSinarDataSet;
            // 
            // TokoSinarDataSet
            // 
            this.TokoSinarDataSet.DataSetName = "TokoSinarDataSet";
            this.TokoSinarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewReportPenjualanBindingSource
            // 
            this.ViewReportPenjualanBindingSource.DataMember = "ViewReportPenjualan";
            this.ViewReportPenjualanBindingSource.DataSource = this.TokoSinarDataSet;
            // 
            // ViewReportPembelianBindingSource
            // 
            this.ViewReportPembelianBindingSource.DataMember = "ViewReportPembelian";
            this.ViewReportPembelianBindingSource.DataSource = this.TokoSinarDataSet;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Location = new System.Drawing.Point(1473, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 25);
            this.panel1.TabIndex = 0;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(245, 0);
            this.labelNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(92, 20);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Welcome ";
            this.labelNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelRole);
            this.panel2.Location = new System.Drawing.Point(1473, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 25);
            this.panel2.TabIndex = 1;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(149, 0);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(188, 20);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Anda masuk sebagai ";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.labelUbahPassword);
            this.panel3.Location = new System.Drawing.Point(1473, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 25);
            this.panel3.TabIndex = 2;
            // 
            // labelUbahPassword
            // 
            this.labelUbahPassword.AutoSize = true;
            this.labelUbahPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUbahPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelUbahPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbahPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelUbahPassword.Location = new System.Drawing.Point(181, 0);
            this.labelUbahPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUbahPassword.Name = "labelUbahPassword";
            this.labelUbahPassword.Size = new System.Drawing.Size(156, 20);
            this.labelUbahPassword.TabIndex = 3;
            this.labelUbahPassword.Text = "Ubah Password ?";
            this.labelUbahPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUbahPassword.Click += new System.EventHandler(this.labelUbahPassword_Click);
            // 
            // panelPembelian
            // 
            this.panelPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPembelian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPembelian.Controls.Add(this.groupBoxPembelian);
            this.panelPembelian.Location = new System.Drawing.Point(16, 196);
            this.panelPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.panelPembelian.Name = "panelPembelian";
            this.panelPembelian.Size = new System.Drawing.Size(1794, 719);
            this.panelPembelian.TabIndex = 3;
            // 
            // groupBoxPembelian
            // 
            this.groupBoxPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPembelian.Controls.Add(this.btnCariPembelian);
            this.groupBoxPembelian.Controls.Add(this.dtpTanggalAkhirCariPembelian);
            this.groupBoxPembelian.Controls.Add(this.labelSDPembelian);
            this.groupBoxPembelian.Controls.Add(this.dtpTanggalAwalCariPembelian);
            this.groupBoxPembelian.Controls.Add(this.cbTanggalFakturPembelian);
            this.groupBoxPembelian.Controls.Add(this.tbCariPembelian);
            this.groupBoxPembelian.Controls.Add(this.label3);
            this.groupBoxPembelian.Controls.Add(this.btnUbahStatus);
            this.groupBoxPembelian.Controls.Add(this.dgvDetailPembelian);
            this.groupBoxPembelian.Controls.Add(this.label2);
            this.groupBoxPembelian.Controls.Add(this.label1);
            this.groupBoxPembelian.Controls.Add(this.dgvMasterPembelian);
            this.groupBoxPembelian.Controls.Add(this.btnHapusPembelian);
            this.groupBoxPembelian.Controls.Add(this.btnUbahPembelian);
            this.groupBoxPembelian.Controls.Add(this.btnPembelianBaru);
            this.groupBoxPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPembelian.Location = new System.Drawing.Point(4, 4);
            this.groupBoxPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPembelian.Name = "groupBoxPembelian";
            this.groupBoxPembelian.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPembelian.Size = new System.Drawing.Size(1784, 709);
            this.groupBoxPembelian.TabIndex = 0;
            this.groupBoxPembelian.TabStop = false;
            this.groupBoxPembelian.Text = "Pembelian";
            // 
            // btnCariPembelian
            // 
            this.btnCariPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariPembelian.Location = new System.Drawing.Point(1019, 116);
            this.btnCariPembelian.Name = "btnCariPembelian";
            this.btnCariPembelian.Size = new System.Drawing.Size(87, 30);
            this.btnCariPembelian.TabIndex = 16;
            this.btnCariPembelian.Text = "Cari";
            this.btnCariPembelian.UseVisualStyleBackColor = true;
            this.btnCariPembelian.Click += new System.EventHandler(this.btnCariPembelian_Click);
            // 
            // dtpTanggalAkhirCariPembelian
            // 
            this.dtpTanggalAkhirCariPembelian.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAkhirCariPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalAkhirCariPembelian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAkhirCariPembelian.Location = new System.Drawing.Point(757, 114);
            this.dtpTanggalAkhirCariPembelian.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAkhirCariPembelian.Name = "dtpTanggalAkhirCariPembelian";
            this.dtpTanggalAkhirCariPembelian.Size = new System.Drawing.Size(256, 30);
            this.dtpTanggalAkhirCariPembelian.TabIndex = 15;
            // 
            // labelSDPembelian
            // 
            this.labelSDPembelian.AutoSize = true;
            this.labelSDPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDPembelian.Location = new System.Drawing.Point(712, 119);
            this.labelSDPembelian.Name = "labelSDPembelian";
            this.labelSDPembelian.Size = new System.Drawing.Size(39, 25);
            this.labelSDPembelian.TabIndex = 14;
            this.labelSDPembelian.Text = "s/d";
            // 
            // dtpTanggalAwalCariPembelian
            // 
            this.dtpTanggalAwalCariPembelian.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAwalCariPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalAwalCariPembelian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAwalCariPembelian.Location = new System.Drawing.Point(459, 114);
            this.dtpTanggalAwalCariPembelian.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAwalCariPembelian.Name = "dtpTanggalAwalCariPembelian";
            this.dtpTanggalAwalCariPembelian.Size = new System.Drawing.Size(247, 30);
            this.dtpTanggalAwalCariPembelian.TabIndex = 13;
            // 
            // cbTanggalFakturPembelian
            // 
            this.cbTanggalFakturPembelian.AutoSize = true;
            this.cbTanggalFakturPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanggalFakturPembelian.Location = new System.Drawing.Point(287, 118);
            this.cbTanggalFakturPembelian.Name = "cbTanggalFakturPembelian";
            this.cbTanggalFakturPembelian.Size = new System.Drawing.Size(166, 29);
            this.cbTanggalFakturPembelian.TabIndex = 12;
            this.cbTanggalFakturPembelian.Text = "Tanggal Faktur";
            this.cbTanggalFakturPembelian.UseVisualStyleBackColor = true;
            this.cbTanggalFakturPembelian.CheckedChanged += new System.EventHandler(this.cbTanggalFaktur_CheckedChanged);
            // 
            // tbCariPembelian
            // 
            this.tbCariPembelian.Location = new System.Drawing.Point(66, 116);
            this.tbCariPembelian.Name = "tbCariPembelian";
            this.tbCariPembelian.Size = new System.Drawing.Size(201, 30);
            this.tbCariPembelian.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cari :";
            // 
            // btnUbahStatus
            // 
            this.btnUbahStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahStatus.Location = new System.Drawing.Point(635, 31);
            this.btnUbahStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbahStatus.Name = "btnUbahStatus";
            this.btnUbahStatus.Size = new System.Drawing.Size(232, 44);
            this.btnUbahStatus.TabIndex = 9;
            this.btnUbahStatus.Text = "Lunas / Belum Lunas";
            this.btnUbahStatus.UseVisualStyleBackColor = true;
            this.btnUbahStatus.Click += new System.EventHandler(this.btnUbahStatus_Click);
            // 
            // dgvDetailPembelian
            // 
            this.dgvDetailPembelian.AllowUserToAddRows = false;
            this.dgvDetailPembelian.AllowUserToDeleteRows = false;
            this.dgvDetailPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPembelian.Location = new System.Drawing.Point(8, 514);
            this.dgvDetailPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetailPembelian.MultiSelect = false;
            this.dgvDetailPembelian.Name = "dgvDetailPembelian";
            this.dgvDetailPembelian.ReadOnly = true;
            this.dgvDetailPembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailPembelian.Size = new System.Drawing.Size(1768, 187);
            this.dgvDetailPembelian.TabIndex = 8;
            this.dgvDetailPembelian.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailPembelian_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 482);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detail Pembelian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Master Pembelian";
            // 
            // dgvMasterPembelian
            // 
            this.dgvMasterPembelian.AllowUserToAddRows = false;
            this.dgvMasterPembelian.AllowUserToDeleteRows = false;
            this.dgvMasterPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMasterPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterPembelian.Location = new System.Drawing.Point(8, 154);
            this.dgvMasterPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMasterPembelian.MultiSelect = false;
            this.dgvMasterPembelian.Name = "dgvMasterPembelian";
            this.dgvMasterPembelian.ReadOnly = true;
            this.dgvMasterPembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasterPembelian.Size = new System.Drawing.Size(1768, 320);
            this.dgvMasterPembelian.TabIndex = 3;
            this.dgvMasterPembelian.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMasterPembelian_CellFormatting);
            this.dgvMasterPembelian.SelectionChanged += new System.EventHandler(this.dgvMasterPembelian_SelectionChanged);
            // 
            // btnHapusPembelian
            // 
            this.btnHapusPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusPembelian.Location = new System.Drawing.Point(419, 31);
            this.btnHapusPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusPembelian.Name = "btnHapusPembelian";
            this.btnHapusPembelian.Size = new System.Drawing.Size(208, 44);
            this.btnHapusPembelian.TabIndex = 2;
            this.btnHapusPembelian.Text = "Hapus Pembelian";
            this.btnHapusPembelian.UseVisualStyleBackColor = true;
            this.btnHapusPembelian.Click += new System.EventHandler(this.btnHapusPembelian_Click);
            // 
            // btnUbahPembelian
            // 
            this.btnUbahPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahPembelian.Location = new System.Drawing.Point(212, 31);
            this.btnUbahPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbahPembelian.Name = "btnUbahPembelian";
            this.btnUbahPembelian.Size = new System.Drawing.Size(199, 44);
            this.btnUbahPembelian.TabIndex = 1;
            this.btnUbahPembelian.Text = "Ubah Pembelian";
            this.btnUbahPembelian.UseVisualStyleBackColor = true;
            this.btnUbahPembelian.Click += new System.EventHandler(this.btnUbahPembelian_Click);
            // 
            // btnPembelianBaru
            // 
            this.btnPembelianBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembelianBaru.Location = new System.Drawing.Point(8, 31);
            this.btnPembelianBaru.Margin = new System.Windows.Forms.Padding(4);
            this.btnPembelianBaru.Name = "btnPembelianBaru";
            this.btnPembelianBaru.Size = new System.Drawing.Size(196, 44);
            this.btnPembelianBaru.TabIndex = 0;
            this.btnPembelianBaru.Text = "Pembelian Baru";
            this.btnPembelianBaru.UseVisualStyleBackColor = true;
            this.btnPembelianBaru.Click += new System.EventHandler(this.btnPembelianBaru_Click);
            // 
            // labelTanggalJam
            // 
            this.labelTanggalJam.AutoSize = true;
            this.labelTanggalJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalJam.Location = new System.Drawing.Point(16, 11);
            this.labelTanggalJam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTanggalJam.Name = "labelTanggalJam";
            this.labelTanggalJam.Size = new System.Drawing.Size(68, 31);
            this.labelTanggalJam.TabIndex = 4;
            this.labelTanggalJam.Text = "Jam";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPembelian
            // 
            this.btnPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembelian.Location = new System.Drawing.Point(16, 119);
            this.btnPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.btnPembelian.Name = "btnPembelian";
            this.btnPembelian.Size = new System.Drawing.Size(180, 70);
            this.btnPembelian.TabIndex = 5;
            this.btnPembelian.Text = "Pembelian";
            this.btnPembelian.UseVisualStyleBackColor = true;
            this.btnPembelian.Click += new System.EventHandler(this.btnPembelian_Click);
            // 
            // btnOlahKaryawan
            // 
            this.btnOlahKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlahKaryawan.Location = new System.Drawing.Point(204, 119);
            this.btnOlahKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnOlahKaryawan.Name = "btnOlahKaryawan";
            this.btnOlahKaryawan.Size = new System.Drawing.Size(180, 70);
            this.btnOlahKaryawan.TabIndex = 6;
            this.btnOlahKaryawan.Text = "Olah Karyawan";
            this.btnOlahKaryawan.UseVisualStyleBackColor = true;
            this.btnOlahKaryawan.Click += new System.EventHandler(this.btnOlahKaryawan_Click);
            // 
            // panelOlahKaryawan
            // 
            this.panelOlahKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOlahKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOlahKaryawan.Controls.Add(this.groupBoxKayawan);
            this.panelOlahKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOlahKaryawan.Location = new System.Drawing.Point(16, 196);
            this.panelOlahKaryawan.Name = "panelOlahKaryawan";
            this.panelOlahKaryawan.Size = new System.Drawing.Size(1794, 719);
            this.panelOlahKaryawan.TabIndex = 7;
            // 
            // groupBoxKayawan
            // 
            this.groupBoxKayawan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxKayawan.Controls.Add(this.btnResetPasswordKaryawan);
            this.groupBoxKayawan.Controls.Add(this.btnHapusDataKaryawan);
            this.groupBoxKayawan.Controls.Add(this.tbCariKaryawan);
            this.groupBoxKayawan.Controls.Add(this.label10);
            this.groupBoxKayawan.Controls.Add(this.btnUbahDataKaryawan);
            this.groupBoxKayawan.Controls.Add(this.groupBoxTambahUbahKaryawan);
            this.groupBoxKayawan.Controls.Add(this.dgvMasterKaryawan);
            this.groupBoxKayawan.Controls.Add(this.btnTambahKaryawan);
            this.groupBoxKayawan.Controls.Add(this.label4);
            this.groupBoxKayawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKayawan.Location = new System.Drawing.Point(6, 5);
            this.groupBoxKayawan.Name = "groupBoxKayawan";
            this.groupBoxKayawan.Size = new System.Drawing.Size(1781, 707);
            this.groupBoxKayawan.TabIndex = 18;
            this.groupBoxKayawan.TabStop = false;
            this.groupBoxKayawan.Text = "Karyawan";
            // 
            // btnResetPasswordKaryawan
            // 
            this.btnResetPasswordKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPasswordKaryawan.Location = new System.Drawing.Point(619, 33);
            this.btnResetPasswordKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetPasswordKaryawan.Name = "btnResetPasswordKaryawan";
            this.btnResetPasswordKaryawan.Size = new System.Drawing.Size(196, 75);
            this.btnResetPasswordKaryawan.TabIndex = 23;
            this.btnResetPasswordKaryawan.Text = "Reset Password Karyawan";
            this.btnResetPasswordKaryawan.UseVisualStyleBackColor = true;
            this.btnResetPasswordKaryawan.Click += new System.EventHandler(this.btnResetPasswordKaryawan_Click);
            // 
            // btnHapusDataKaryawan
            // 
            this.btnHapusDataKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusDataKaryawan.Location = new System.Drawing.Point(415, 32);
            this.btnHapusDataKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusDataKaryawan.Name = "btnHapusDataKaryawan";
            this.btnHapusDataKaryawan.Size = new System.Drawing.Size(196, 75);
            this.btnHapusDataKaryawan.TabIndex = 22;
            this.btnHapusDataKaryawan.Text = "Hapus Data Karyawan";
            this.btnHapusDataKaryawan.UseVisualStyleBackColor = true;
            this.btnHapusDataKaryawan.Click += new System.EventHandler(this.btnHapusDataKaryawan_Click);
            // 
            // tbCariKaryawan
            // 
            this.tbCariKaryawan.Location = new System.Drawing.Point(72, 139);
            this.tbCariKaryawan.Name = "tbCariKaryawan";
            this.tbCariKaryawan.Size = new System.Drawing.Size(227, 30);
            this.tbCariKaryawan.TabIndex = 21;
            this.tbCariKaryawan.TextChanged += new System.EventHandler(this.tbCariKaryawan_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cari :";
            // 
            // btnUbahDataKaryawan
            // 
            this.btnUbahDataKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahDataKaryawan.Location = new System.Drawing.Point(211, 32);
            this.btnUbahDataKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbahDataKaryawan.Name = "btnUbahDataKaryawan";
            this.btnUbahDataKaryawan.Size = new System.Drawing.Size(196, 75);
            this.btnUbahDataKaryawan.TabIndex = 19;
            this.btnUbahDataKaryawan.Text = "Ubah Data Karyawan";
            this.btnUbahDataKaryawan.UseVisualStyleBackColor = true;
            this.btnUbahDataKaryawan.Click += new System.EventHandler(this.btnUbahDataKaryawan_Click);
            // 
            // groupBoxTambahUbahKaryawan
            // 
            this.groupBoxTambahUbahKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.btnSimpanKaryawan);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.cbStatusKaryawan);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.label9);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.cbJenisKaryawan);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.label8);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.tbAlamatKaryawan);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.label7);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.tbNamaKaryawan);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.label6);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.tbUsernameKaryawan);
            this.groupBoxTambahUbahKaryawan.Controls.Add(this.label5);
            this.groupBoxTambahUbahKaryawan.Location = new System.Drawing.Point(1203, 137);
            this.groupBoxTambahUbahKaryawan.Name = "groupBoxTambahUbahKaryawan";
            this.groupBoxTambahUbahKaryawan.Size = new System.Drawing.Size(572, 562);
            this.groupBoxTambahUbahKaryawan.TabIndex = 18;
            this.groupBoxTambahUbahKaryawan.TabStop = false;
            this.groupBoxTambahUbahKaryawan.Text = " Tambah Karyawan";
            // 
            // btnSimpanKaryawan
            // 
            this.btnSimpanKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpanKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanKaryawan.Location = new System.Drawing.Point(402, 499);
            this.btnSimpanKaryawan.Name = "btnSimpanKaryawan";
            this.btnSimpanKaryawan.Size = new System.Drawing.Size(166, 59);
            this.btnSimpanKaryawan.TabIndex = 10;
            this.btnSimpanKaryawan.Text = "Simpan";
            this.btnSimpanKaryawan.UseVisualStyleBackColor = true;
            this.btnSimpanKaryawan.Click += new System.EventHandler(this.btnSimpanKaryawan_Click);
            // 
            // cbStatusKaryawan
            // 
            this.cbStatusKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusKaryawan.FormattingEnabled = true;
            this.cbStatusKaryawan.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.cbStatusKaryawan.Location = new System.Drawing.Point(189, 321);
            this.cbStatusKaryawan.Name = "cbStatusKaryawan";
            this.cbStatusKaryawan.Size = new System.Drawing.Size(156, 33);
            this.cbStatusKaryawan.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Status :";
            // 
            // cbJenisKaryawan
            // 
            this.cbJenisKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisKaryawan.FormattingEnabled = true;
            this.cbJenisKaryawan.Items.AddRange(new object[] {
            "Owner",
            "Karyawan"});
            this.cbJenisKaryawan.Location = new System.Drawing.Point(189, 282);
            this.cbJenisKaryawan.Name = "cbJenisKaryawan";
            this.cbJenisKaryawan.Size = new System.Drawing.Size(225, 33);
            this.cbJenisKaryawan.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Jenis Karyawan :";
            // 
            // tbAlamatKaryawan
            // 
            this.tbAlamatKaryawan.Location = new System.Drawing.Point(189, 115);
            this.tbAlamatKaryawan.Multiline = true;
            this.tbAlamatKaryawan.Name = "tbAlamatKaryawan";
            this.tbAlamatKaryawan.Size = new System.Drawing.Size(314, 161);
            this.tbAlamatKaryawan.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Alamat Karyawan :";
            // 
            // tbNamaKaryawan
            // 
            this.tbNamaKaryawan.Location = new System.Drawing.Point(189, 74);
            this.tbNamaKaryawan.Name = "tbNamaKaryawan";
            this.tbNamaKaryawan.Size = new System.Drawing.Size(314, 30);
            this.tbNamaKaryawan.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nama Karyawan :";
            // 
            // tbUsernameKaryawan
            // 
            this.tbUsernameKaryawan.Location = new System.Drawing.Point(189, 35);
            this.tbUsernameKaryawan.Name = "tbUsernameKaryawan";
            this.tbUsernameKaryawan.Size = new System.Drawing.Size(225, 30);
            this.tbUsernameKaryawan.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username :";
            // 
            // dgvMasterKaryawan
            // 
            this.dgvMasterKaryawan.AllowUserToAddRows = false;
            this.dgvMasterKaryawan.AllowUserToDeleteRows = false;
            this.dgvMasterKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMasterKaryawan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterKaryawan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvMasterKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterKaryawan.Location = new System.Drawing.Point(6, 175);
            this.dgvMasterKaryawan.MultiSelect = false;
            this.dgvMasterKaryawan.Name = "dgvMasterKaryawan";
            this.dgvMasterKaryawan.ReadOnly = true;
            this.dgvMasterKaryawan.RowTemplate.Height = 24;
            this.dgvMasterKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasterKaryawan.Size = new System.Drawing.Size(1189, 524);
            this.dgvMasterKaryawan.TabIndex = 1;
            // 
            // btnTambahKaryawan
            // 
            this.btnTambahKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahKaryawan.Location = new System.Drawing.Point(7, 30);
            this.btnTambahKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahKaryawan.Name = "btnTambahKaryawan";
            this.btnTambahKaryawan.Size = new System.Drawing.Size(196, 75);
            this.btnTambahKaryawan.TabIndex = 17;
            this.btnTambahKaryawan.Text = "Tambah Karyawan Baru";
            this.btnTambahKaryawan.UseVisualStyleBackColor = true;
            this.btnTambahKaryawan.Click += new System.EventHandler(this.btnTambahKaryawan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Karyawan";
            // 
            // btnSupplier
            // 
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Location = new System.Drawing.Point(392, 119);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(180, 70);
            this.btnSupplier.TabIndex = 8;
            this.btnSupplier.Text = "Olah Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // panelSupplier
            // 
            this.panelSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSupplier.Controls.Add(this.groupBox1);
            this.panelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSupplier.Location = new System.Drawing.Point(16, 196);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(1794, 719);
            this.panelSupplier.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbCariSupplier);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnUbahDataSupplier);
            this.groupBox1.Controls.Add(this.groupBoxTambahUbahSupplier);
            this.groupBox1.Controls.Add(this.dgvMasterSupplier);
            this.groupBox1.Controls.Add(this.btnTambahSupplierBaru);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1781, 707);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // tbCariSupplier
            // 
            this.tbCariSupplier.Location = new System.Drawing.Point(72, 139);
            this.tbCariSupplier.Name = "tbCariSupplier";
            this.tbCariSupplier.Size = new System.Drawing.Size(227, 30);
            this.tbCariSupplier.TabIndex = 21;
            this.tbCariSupplier.TextChanged += new System.EventHandler(this.tbCariSupplier_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cari :";
            // 
            // btnUbahDataSupplier
            // 
            this.btnUbahDataSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahDataSupplier.Location = new System.Drawing.Point(211, 32);
            this.btnUbahDataSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbahDataSupplier.Name = "btnUbahDataSupplier";
            this.btnUbahDataSupplier.Size = new System.Drawing.Size(196, 75);
            this.btnUbahDataSupplier.TabIndex = 19;
            this.btnUbahDataSupplier.Text = "Ubah Data Supplier";
            this.btnUbahDataSupplier.UseVisualStyleBackColor = true;
            this.btnUbahDataSupplier.Click += new System.EventHandler(this.btnUbahDataSupplier_Click);
            // 
            // groupBoxTambahUbahSupplier
            // 
            this.groupBoxTambahUbahSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTambahUbahSupplier.Controls.Add(this.tbTelpSupplier);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.btnSimpanSupplier);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.cbStatusSupplier);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.label12);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.label13);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.tbAlamatSupplier);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.label14);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.tbNamaSupplier);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.label15);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.tbKodeSupplier);
            this.groupBoxTambahUbahSupplier.Controls.Add(this.label16);
            this.groupBoxTambahUbahSupplier.Location = new System.Drawing.Point(1203, 137);
            this.groupBoxTambahUbahSupplier.Name = "groupBoxTambahUbahSupplier";
            this.groupBoxTambahUbahSupplier.Size = new System.Drawing.Size(572, 562);
            this.groupBoxTambahUbahSupplier.TabIndex = 0;
            this.groupBoxTambahUbahSupplier.TabStop = false;
            this.groupBoxTambahUbahSupplier.Text = " Tambah Supplier";
            // 
            // tbTelpSupplier
            // 
            this.tbTelpSupplier.Location = new System.Drawing.Point(189, 282);
            this.tbTelpSupplier.Name = "tbTelpSupplier";
            this.tbTelpSupplier.Size = new System.Drawing.Size(314, 30);
            this.tbTelpSupplier.TabIndex = 8;
            this.tbTelpSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelpSupplier_KeyPress);
            // 
            // btnSimpanSupplier
            // 
            this.btnSimpanSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpanSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanSupplier.Location = new System.Drawing.Point(402, 499);
            this.btnSimpanSupplier.Name = "btnSimpanSupplier";
            this.btnSimpanSupplier.Size = new System.Drawing.Size(166, 59);
            this.btnSimpanSupplier.TabIndex = 0;
            this.btnSimpanSupplier.Text = "Simpan";
            this.btnSimpanSupplier.UseVisualStyleBackColor = true;
            this.btnSimpanSupplier.Click += new System.EventHandler(this.btnSimpanSupplier_Click);
            // 
            // cbStatusSupplier
            // 
            this.cbStatusSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusSupplier.FormattingEnabled = true;
            this.cbStatusSupplier.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.cbStatusSupplier.Location = new System.Drawing.Point(189, 321);
            this.cbStatusSupplier.Name = "cbStatusSupplier";
            this.cbStatusSupplier.Size = new System.Drawing.Size(156, 33);
            this.cbStatusSupplier.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(104, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Status :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Telp. Supplier :";
            // 
            // tbAlamatSupplier
            // 
            this.tbAlamatSupplier.Location = new System.Drawing.Point(189, 115);
            this.tbAlamatSupplier.Multiline = true;
            this.tbAlamatSupplier.Name = "tbAlamatSupplier";
            this.tbAlamatSupplier.Size = new System.Drawing.Size(314, 161);
            this.tbAlamatSupplier.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Alamat Supplier :";
            // 
            // tbNamaSupplier
            // 
            this.tbNamaSupplier.Location = new System.Drawing.Point(189, 74);
            this.tbNamaSupplier.Name = "tbNamaSupplier";
            this.tbNamaSupplier.Size = new System.Drawing.Size(314, 30);
            this.tbNamaSupplier.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "Nama Supplier :";
            // 
            // tbKodeSupplier
            // 
            this.tbKodeSupplier.Location = new System.Drawing.Point(189, 35);
            this.tbKodeSupplier.Name = "tbKodeSupplier";
            this.tbKodeSupplier.ReadOnly = true;
            this.tbKodeSupplier.Size = new System.Drawing.Size(225, 30);
            this.tbKodeSupplier.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Kode Supplier :";
            // 
            // dgvMasterSupplier
            // 
            this.dgvMasterSupplier.AllowUserToAddRows = false;
            this.dgvMasterSupplier.AllowUserToDeleteRows = false;
            this.dgvMasterSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMasterSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvMasterSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterSupplier.Location = new System.Drawing.Point(6, 175);
            this.dgvMasterSupplier.MultiSelect = false;
            this.dgvMasterSupplier.Name = "dgvMasterSupplier";
            this.dgvMasterSupplier.ReadOnly = true;
            this.dgvMasterSupplier.RowTemplate.Height = 24;
            this.dgvMasterSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasterSupplier.Size = new System.Drawing.Size(1189, 524);
            this.dgvMasterSupplier.TabIndex = 1;
            // 
            // btnTambahSupplierBaru
            // 
            this.btnTambahSupplierBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahSupplierBaru.Location = new System.Drawing.Point(7, 30);
            this.btnTambahSupplierBaru.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahSupplierBaru.Name = "btnTambahSupplierBaru";
            this.btnTambahSupplierBaru.Size = new System.Drawing.Size(196, 75);
            this.btnTambahSupplierBaru.TabIndex = 17;
            this.btnTambahSupplierBaru.Text = "Tambah Supplier Baru";
            this.btnTambahSupplierBaru.UseVisualStyleBackColor = true;
            this.btnTambahSupplierBaru.Click += new System.EventHandler(this.btnTambahSupplierBaru_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Data Supplier";
            // 
            // btnOlahBarang
            // 
            this.btnOlahBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlahBarang.Location = new System.Drawing.Point(580, 119);
            this.btnOlahBarang.Margin = new System.Windows.Forms.Padding(4);
            this.btnOlahBarang.Name = "btnOlahBarang";
            this.btnOlahBarang.Size = new System.Drawing.Size(180, 70);
            this.btnOlahBarang.TabIndex = 20;
            this.btnOlahBarang.Text = "Olah Barang";
            this.btnOlahBarang.UseVisualStyleBackColor = true;
            this.btnOlahBarang.Click += new System.EventHandler(this.btnOlahBarang_Click);
            // 
            // panelBarang
            // 
            this.panelBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarang.Controls.Add(this.groupBox2);
            this.panelBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBarang.Location = new System.Drawing.Point(16, 196);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Size = new System.Drawing.Size(1794, 719);
            this.panelBarang.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbCariBarang);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnUbahDataBarang);
            this.groupBox2.Controls.Add(this.groupBoxTambahUbahBarang);
            this.groupBox2.Controls.Add(this.dgvMasterBarang);
            this.groupBox2.Controls.Add(this.btnTambahBarangBaru);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1781, 707);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barang";
            // 
            // tbCariBarang
            // 
            this.tbCariBarang.Location = new System.Drawing.Point(72, 139);
            this.tbCariBarang.Name = "tbCariBarang";
            this.tbCariBarang.Size = new System.Drawing.Size(227, 30);
            this.tbCariBarang.TabIndex = 21;
            this.tbCariBarang.TextChanged += new System.EventHandler(this.tbCariBarang_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 25);
            this.label18.TabIndex = 20;
            this.label18.Text = "Cari :";
            // 
            // btnUbahDataBarang
            // 
            this.btnUbahDataBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahDataBarang.Location = new System.Drawing.Point(211, 32);
            this.btnUbahDataBarang.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbahDataBarang.Name = "btnUbahDataBarang";
            this.btnUbahDataBarang.Size = new System.Drawing.Size(196, 75);
            this.btnUbahDataBarang.TabIndex = 19;
            this.btnUbahDataBarang.Text = "Ubah Data Barang";
            this.btnUbahDataBarang.UseVisualStyleBackColor = true;
            this.btnUbahDataBarang.Click += new System.EventHandler(this.btnUbahDataBarang_Click);
            // 
            // groupBoxTambahUbahBarang
            // 
            this.groupBoxTambahUbahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTambahUbahBarang.Controls.Add(this.groupBoxSupplierBaru);
            this.groupBoxTambahUbahBarang.Controls.Add(this.radioSupplierBaru);
            this.groupBoxTambahUbahBarang.Controls.Add(this.radioSupplierLama);
            this.groupBoxTambahUbahBarang.Controls.Add(this.label26);
            this.groupBoxTambahUbahBarang.Controls.Add(this.label25);
            this.groupBoxTambahUbahBarang.Controls.Add(this.tbHargaJualBarang);
            this.groupBoxTambahUbahBarang.Controls.Add(this.tbHargaBeliBarang);
            this.groupBoxTambahUbahBarang.Controls.Add(this.btnSimpanBarang);
            this.groupBoxTambahUbahBarang.Controls.Add(this.label19);
            this.groupBoxTambahUbahBarang.Controls.Add(this.label20);
            this.groupBoxTambahUbahBarang.Controls.Add(this.tbSatuanBarang);
            this.groupBoxTambahUbahBarang.Controls.Add(this.label21);
            this.groupBoxTambahUbahBarang.Controls.Add(this.tbNamaBarang);
            this.groupBoxTambahUbahBarang.Controls.Add(this.label22);
            this.groupBoxTambahUbahBarang.Controls.Add(this.tbKodeBarang);
            this.groupBoxTambahUbahBarang.Controls.Add(this.label23);
            this.groupBoxTambahUbahBarang.Location = new System.Drawing.Point(1266, 137);
            this.groupBoxTambahUbahBarang.Name = "groupBoxTambahUbahBarang";
            this.groupBoxTambahUbahBarang.Size = new System.Drawing.Size(509, 562);
            this.groupBoxTambahUbahBarang.TabIndex = 0;
            this.groupBoxTambahUbahBarang.TabStop = false;
            this.groupBoxTambahUbahBarang.Text = " Tambah Supplier";
            // 
            // groupBoxSupplierBaru
            // 
            this.groupBoxSupplierBaru.Controls.Add(this.cbNamaSupplier);
            this.groupBoxSupplierBaru.Controls.Add(this.tbNoTelpSupplier);
            this.groupBoxSupplierBaru.Controls.Add(this.label27);
            this.groupBoxSupplierBaru.Controls.Add(this.tbAlamatSupplierBarang);
            this.groupBoxSupplierBaru.Controls.Add(this.label28);
            this.groupBoxSupplierBaru.Controls.Add(this.textBox7);
            this.groupBoxSupplierBaru.Controls.Add(this.label29);
            this.groupBoxSupplierBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSupplierBaru.Location = new System.Drawing.Point(8, 267);
            this.groupBoxSupplierBaru.Name = "groupBoxSupplierBaru";
            this.groupBoxSupplierBaru.Size = new System.Drawing.Size(497, 226);
            this.groupBoxSupplierBaru.TabIndex = 15;
            this.groupBoxSupplierBaru.TabStop = false;
            this.groupBoxSupplierBaru.Text = "Supplier";
            // 
            // cbNamaSupplier
            // 
            this.cbNamaSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamaSupplier.FormattingEnabled = true;
            this.cbNamaSupplier.Location = new System.Drawing.Point(189, 35);
            this.cbNamaSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.cbNamaSupplier.Name = "cbNamaSupplier";
            this.cbNamaSupplier.Size = new System.Drawing.Size(305, 33);
            this.cbNamaSupplier.TabIndex = 33;
            // 
            // tbNoTelpSupplier
            // 
            this.tbNoTelpSupplier.Location = new System.Drawing.Point(189, 168);
            this.tbNoTelpSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.tbNoTelpSupplier.MaxLength = 15;
            this.tbNoTelpSupplier.Name = "tbNoTelpSupplier";
            this.tbNoTelpSupplier.Size = new System.Drawing.Size(305, 30);
            this.tbNoTelpSupplier.TabIndex = 32;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(31, 171);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(139, 25);
            this.label27.TabIndex = 31;
            this.label27.Text = "Telp Supplier :";
            // 
            // tbAlamatSupplierBarang
            // 
            this.tbAlamatSupplierBarang.Location = new System.Drawing.Point(189, 77);
            this.tbAlamatSupplierBarang.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlamatSupplierBarang.MaxLength = 200;
            this.tbAlamatSupplierBarang.Multiline = true;
            this.tbAlamatSupplierBarang.Name = "tbAlamatSupplierBarang";
            this.tbAlamatSupplierBarang.Size = new System.Drawing.Size(305, 83);
            this.tbAlamatSupplierBarang.TabIndex = 30;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 80);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(161, 25);
            this.label28.TabIndex = 29;
            this.label28.Text = "Alamat Supplier :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(189, 35);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.MaxLength = 100;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(305, 30);
            this.textBox7.TabIndex = 28;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 39);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(152, 25);
            this.label29.TabIndex = 27;
            this.label29.Text = "Nama Supplier :";
            // 
            // radioSupplierBaru
            // 
            this.radioSupplierBaru.AutoSize = true;
            this.radioSupplierBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSupplierBaru.Location = new System.Drawing.Point(198, 229);
            this.radioSupplierBaru.Name = "radioSupplierBaru";
            this.radioSupplierBaru.Size = new System.Drawing.Size(151, 29);
            this.radioSupplierBaru.TabIndex = 14;
            this.radioSupplierBaru.TabStop = true;
            this.radioSupplierBaru.Text = "Supplier Baru";
            this.radioSupplierBaru.UseVisualStyleBackColor = true;
            this.radioSupplierBaru.CheckedChanged += new System.EventHandler(this.radioSupplierBaru_CheckedChanged);
            // 
            // radioSupplierLama
            // 
            this.radioSupplierLama.AutoSize = true;
            this.radioSupplierLama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSupplierLama.Location = new System.Drawing.Point(20, 229);
            this.radioSupplierLama.Name = "radioSupplierLama";
            this.radioSupplierLama.Size = new System.Drawing.Size(159, 29);
            this.radioSupplierLama.TabIndex = 13;
            this.radioSupplierLama.TabStop = true;
            this.radioSupplierLama.Text = "Supplier Lama";
            this.radioSupplierLama.UseVisualStyleBackColor = true;
            this.radioSupplierLama.CheckedChanged += new System.EventHandler(this.radioSupplierLama_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(181, 187);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 25);
            this.label26.TabIndex = 12;
            this.label26.Text = "Rp. ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(181, 151);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 25);
            this.label25.TabIndex = 11;
            this.label25.Text = "Rp. ";
            // 
            // tbHargaJualBarang
            // 
            this.tbHargaJualBarang.Location = new System.Drawing.Point(233, 184);
            this.tbHargaJualBarang.Name = "tbHargaJualBarang";
            this.tbHargaJualBarang.Size = new System.Drawing.Size(267, 30);
            this.tbHargaJualBarang.TabIndex = 10;
            this.tbHargaJualBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHargaJualBarang_KeyPress);
            this.tbHargaJualBarang.Leave += new System.EventHandler(this.tbHargaJualBarang_Leave);
            // 
            // tbHargaBeliBarang
            // 
            this.tbHargaBeliBarang.Location = new System.Drawing.Point(233, 148);
            this.tbHargaBeliBarang.Name = "tbHargaBeliBarang";
            this.tbHargaBeliBarang.Size = new System.Drawing.Size(267, 30);
            this.tbHargaBeliBarang.TabIndex = 8;
            this.tbHargaBeliBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHargaBeliBarang_KeyPress);
            this.tbHargaBeliBarang.Leave += new System.EventHandler(this.tbHargaBeliBarang_Leave);
            // 
            // btnSimpanBarang
            // 
            this.btnSimpanBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpanBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanBarang.Location = new System.Drawing.Point(339, 499);
            this.btnSimpanBarang.Name = "btnSimpanBarang";
            this.btnSimpanBarang.Size = new System.Drawing.Size(166, 59);
            this.btnSimpanBarang.TabIndex = 0;
            this.btnSimpanBarang.Text = "Simpan";
            this.btnSimpanBarang.UseVisualStyleBackColor = true;
            this.btnSimpanBarang.Click += new System.EventHandler(this.btnSimpanBarang_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(61, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 25);
            this.label19.TabIndex = 9;
            this.label19.Text = "Harga Jual :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(66, 151);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 25);
            this.label20.TabIndex = 7;
            this.label20.Text = "Harga Beli :";
            // 
            // tbSatuanBarang
            // 
            this.tbSatuanBarang.Location = new System.Drawing.Point(186, 112);
            this.tbSatuanBarang.Name = "tbSatuanBarang";
            this.tbSatuanBarang.Size = new System.Drawing.Size(314, 30);
            this.tbSatuanBarang.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(93, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 25);
            this.label21.TabIndex = 5;
            this.label21.Text = "Satuan :";
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(186, 71);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(314, 30);
            this.tbNamaBarang.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(37, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(143, 25);
            this.label22.TabIndex = 3;
            this.label22.Text = "Nama Barang :";
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Location = new System.Drawing.Point(186, 32);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.ReadOnly = true;
            this.tbKodeBarang.Size = new System.Drawing.Size(225, 30);
            this.tbKodeBarang.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(41, 35);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 25);
            this.label23.TabIndex = 1;
            this.label23.Text = "Kode Barang :";
            // 
            // dgvMasterBarang
            // 
            this.dgvMasterBarang.AllowUserToAddRows = false;
            this.dgvMasterBarang.AllowUserToDeleteRows = false;
            this.dgvMasterBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMasterBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvMasterBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterBarang.Location = new System.Drawing.Point(6, 175);
            this.dgvMasterBarang.MultiSelect = false;
            this.dgvMasterBarang.Name = "dgvMasterBarang";
            this.dgvMasterBarang.ReadOnly = true;
            this.dgvMasterBarang.RowTemplate.Height = 24;
            this.dgvMasterBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasterBarang.Size = new System.Drawing.Size(1254, 524);
            this.dgvMasterBarang.TabIndex = 1;
            this.dgvMasterBarang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMasterBarang_CellFormatting);
            // 
            // btnTambahBarangBaru
            // 
            this.btnTambahBarangBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahBarangBaru.Location = new System.Drawing.Point(7, 30);
            this.btnTambahBarangBaru.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahBarangBaru.Name = "btnTambahBarangBaru";
            this.btnTambahBarangBaru.Size = new System.Drawing.Size(196, 75);
            this.btnTambahBarangBaru.TabIndex = 17;
            this.btnTambahBarangBaru.Text = "Tambah Barang Baru";
            this.btnTambahBarangBaru.UseVisualStyleBackColor = true;
            this.btnTambahBarangBaru.Click += new System.EventHandler(this.btnTambahBarangBaru_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 25);
            this.label24.TabIndex = 0;
            this.label24.Text = "Data Barang";
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjualan.Location = new System.Drawing.Point(768, 119);
            this.btnPenjualan.Margin = new System.Windows.Forms.Padding(4);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(180, 70);
            this.btnPenjualan.TabIndex = 21;
            this.btnPenjualan.Text = "Penjualan";
            this.btnPenjualan.UseVisualStyleBackColor = true;
            this.btnPenjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // panelPenjualan
            // 
            this.panelPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPenjualan.Controls.Add(this.groupBox3);
            this.panelPenjualan.Location = new System.Drawing.Point(16, 196);
            this.panelPenjualan.Margin = new System.Windows.Forms.Padding(4);
            this.panelPenjualan.Name = "panelPenjualan";
            this.panelPenjualan.Size = new System.Drawing.Size(1794, 719);
            this.panelPenjualan.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnCariPenjualan);
            this.groupBox3.Controls.Add(this.dtpTanggalAkhirPenjualan);
            this.groupBox3.Controls.Add(this.labelSDPenjualan);
            this.groupBox3.Controls.Add(this.dtpTanggalAwalPenjualan);
            this.groupBox3.Controls.Add(this.cbTanggalPenjualan);
            this.groupBox3.Controls.Add(this.tbCariPenjualan);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.dgvDetailPenjualan);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.dgvMasterPenjualan);
            this.groupBox3.Controls.Add(this.btnHapusPenjualan);
            this.groupBox3.Controls.Add(this.btnUbahPenjualan);
            this.groupBox3.Controls.Add(this.btnPenjualanBaru);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1784, 709);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Penjualan";
            // 
            // btnCariPenjualan
            // 
            this.btnCariPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariPenjualan.Location = new System.Drawing.Point(978, 112);
            this.btnCariPenjualan.Name = "btnCariPenjualan";
            this.btnCariPenjualan.Size = new System.Drawing.Size(87, 30);
            this.btnCariPenjualan.TabIndex = 16;
            this.btnCariPenjualan.Text = "Cari";
            this.btnCariPenjualan.UseVisualStyleBackColor = true;
            this.btnCariPenjualan.Click += new System.EventHandler(this.btnCariPenjualan_Click);
            // 
            // dtpTanggalAkhirPenjualan
            // 
            this.dtpTanggalAkhirPenjualan.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAkhirPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalAkhirPenjualan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAkhirPenjualan.Location = new System.Drawing.Point(729, 112);
            this.dtpTanggalAkhirPenjualan.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAkhirPenjualan.Name = "dtpTanggalAkhirPenjualan";
            this.dtpTanggalAkhirPenjualan.Size = new System.Drawing.Size(243, 30);
            this.dtpTanggalAkhirPenjualan.TabIndex = 15;
            // 
            // labelSDPenjualan
            // 
            this.labelSDPenjualan.AutoSize = true;
            this.labelSDPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDPenjualan.Location = new System.Drawing.Point(684, 117);
            this.labelSDPenjualan.Name = "labelSDPenjualan";
            this.labelSDPenjualan.Size = new System.Drawing.Size(39, 25);
            this.labelSDPenjualan.TabIndex = 14;
            this.labelSDPenjualan.Text = "s/d";
            // 
            // dtpTanggalAwalPenjualan
            // 
            this.dtpTanggalAwalPenjualan.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAwalPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalAwalPenjualan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAwalPenjualan.Location = new System.Drawing.Point(427, 112);
            this.dtpTanggalAwalPenjualan.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAwalPenjualan.Name = "dtpTanggalAwalPenjualan";
            this.dtpTanggalAwalPenjualan.Size = new System.Drawing.Size(251, 30);
            this.dtpTanggalAwalPenjualan.TabIndex = 13;
            // 
            // cbTanggalPenjualan
            // 
            this.cbTanggalPenjualan.AutoSize = true;
            this.cbTanggalPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanggalPenjualan.Location = new System.Drawing.Point(273, 116);
            this.cbTanggalPenjualan.Name = "cbTanggalPenjualan";
            this.cbTanggalPenjualan.Size = new System.Drawing.Size(148, 29);
            this.cbTanggalPenjualan.TabIndex = 12;
            this.cbTanggalPenjualan.Text = "Tanggal Jual";
            this.cbTanggalPenjualan.UseVisualStyleBackColor = true;
            this.cbTanggalPenjualan.CheckedChanged += new System.EventHandler(this.cbTanggalPenjualan_CheckedChanged);
            // 
            // tbCariPenjualan
            // 
            this.tbCariPenjualan.Location = new System.Drawing.Point(66, 116);
            this.tbCariPenjualan.Name = "tbCariPenjualan";
            this.tbCariPenjualan.Size = new System.Drawing.Size(201, 30);
            this.tbCariPenjualan.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(8, 119);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 25);
            this.label31.TabIndex = 10;
            this.label31.Text = "Cari :";
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
            this.dgvDetailPenjualan.Location = new System.Drawing.Point(8, 464);
            this.dgvDetailPenjualan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetailPenjualan.MultiSelect = false;
            this.dgvDetailPenjualan.Name = "dgvDetailPenjualan";
            this.dgvDetailPenjualan.ReadOnly = true;
            this.dgvDetailPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailPenjualan.Size = new System.Drawing.Size(1768, 237);
            this.dgvDetailPenjualan.TabIndex = 8;
            this.dgvDetailPenjualan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailPenjualan_CellFormatting);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(8, 435);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(153, 25);
            this.label32.TabIndex = 7;
            this.label32.Text = "Detail Penjualan";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(8, 79);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(164, 25);
            this.label33.TabIndex = 4;
            this.label33.Text = "Master Penjualan";
            // 
            // dgvMasterPenjualan
            // 
            this.dgvMasterPenjualan.AllowUserToAddRows = false;
            this.dgvMasterPenjualan.AllowUserToDeleteRows = false;
            this.dgvMasterPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMasterPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterPenjualan.Location = new System.Drawing.Point(8, 154);
            this.dgvMasterPenjualan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMasterPenjualan.MultiSelect = false;
            this.dgvMasterPenjualan.Name = "dgvMasterPenjualan";
            this.dgvMasterPenjualan.ReadOnly = true;
            this.dgvMasterPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasterPenjualan.Size = new System.Drawing.Size(1768, 277);
            this.dgvMasterPenjualan.TabIndex = 3;
            this.dgvMasterPenjualan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMasterPenjualan_CellFormatting);
            this.dgvMasterPenjualan.SelectionChanged += new System.EventHandler(this.dgvMasterPenjualan_SelectionChanged);
            // 
            // btnHapusPenjualan
            // 
            this.btnHapusPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusPenjualan.Location = new System.Drawing.Point(419, 31);
            this.btnHapusPenjualan.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusPenjualan.Name = "btnHapusPenjualan";
            this.btnHapusPenjualan.Size = new System.Drawing.Size(208, 44);
            this.btnHapusPenjualan.TabIndex = 2;
            this.btnHapusPenjualan.Text = "Hapus Penjualan";
            this.btnHapusPenjualan.UseVisualStyleBackColor = true;
            this.btnHapusPenjualan.Click += new System.EventHandler(this.btnHapusPenjualan_Click);
            // 
            // btnUbahPenjualan
            // 
            this.btnUbahPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahPenjualan.Location = new System.Drawing.Point(212, 31);
            this.btnUbahPenjualan.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbahPenjualan.Name = "btnUbahPenjualan";
            this.btnUbahPenjualan.Size = new System.Drawing.Size(199, 44);
            this.btnUbahPenjualan.TabIndex = 1;
            this.btnUbahPenjualan.Text = "Ubah Penjualan";
            this.btnUbahPenjualan.UseVisualStyleBackColor = true;
            this.btnUbahPenjualan.Click += new System.EventHandler(this.btnUbahPenjualan_Click);
            // 
            // btnPenjualanBaru
            // 
            this.btnPenjualanBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjualanBaru.Location = new System.Drawing.Point(8, 31);
            this.btnPenjualanBaru.Margin = new System.Windows.Forms.Padding(4);
            this.btnPenjualanBaru.Name = "btnPenjualanBaru";
            this.btnPenjualanBaru.Size = new System.Drawing.Size(196, 44);
            this.btnPenjualanBaru.TabIndex = 0;
            this.btnPenjualanBaru.Text = "Penjualan Baru";
            this.btnPenjualanBaru.UseVisualStyleBackColor = true;
            this.btnPenjualanBaru.Click += new System.EventHandler(this.btnPenjualanBaru_Click);
            // 
            // panelRetur
            // 
            this.panelRetur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRetur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRetur.Controls.Add(this.groupBox4);
            this.panelRetur.Location = new System.Drawing.Point(16, 196);
            this.panelRetur.Margin = new System.Windows.Forms.Padding(4);
            this.panelRetur.Name = "panelRetur";
            this.panelRetur.Size = new System.Drawing.Size(1794, 719);
            this.panelRetur.TabIndex = 23;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnCariRetur);
            this.groupBox4.Controls.Add(this.dtpTanggalAkhirRetur);
            this.groupBox4.Controls.Add(this.labelSDRetur);
            this.groupBox4.Controls.Add(this.dtpTanggalAwalRetur);
            this.groupBox4.Controls.Add(this.cbTanggalRetur);
            this.groupBox4.Controls.Add(this.tbCariRetur);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.dgvDetailRetur);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.dgvMasterRetur);
            this.groupBox4.Controls.Add(this.btnHapusDataRetur);
            this.groupBox4.Controls.Add(this.btnUbahDataRetur);
            this.groupBox4.Controls.Add(this.btnTambahRetur);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1784, 709);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Retur Barang";
            // 
            // btnCariRetur
            // 
            this.btnCariRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariRetur.Location = new System.Drawing.Point(978, 112);
            this.btnCariRetur.Name = "btnCariRetur";
            this.btnCariRetur.Size = new System.Drawing.Size(87, 30);
            this.btnCariRetur.TabIndex = 16;
            this.btnCariRetur.Text = "Cari";
            this.btnCariRetur.UseVisualStyleBackColor = true;
            this.btnCariRetur.Click += new System.EventHandler(this.btnCariRetur_Click);
            // 
            // dtpTanggalAkhirRetur
            // 
            this.dtpTanggalAkhirRetur.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAkhirRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalAkhirRetur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAkhirRetur.Location = new System.Drawing.Point(729, 112);
            this.dtpTanggalAkhirRetur.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAkhirRetur.Name = "dtpTanggalAkhirRetur";
            this.dtpTanggalAkhirRetur.Size = new System.Drawing.Size(243, 30);
            this.dtpTanggalAkhirRetur.TabIndex = 15;
            // 
            // labelSDRetur
            // 
            this.labelSDRetur.AutoSize = true;
            this.labelSDRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDRetur.Location = new System.Drawing.Point(684, 117);
            this.labelSDRetur.Name = "labelSDRetur";
            this.labelSDRetur.Size = new System.Drawing.Size(39, 25);
            this.labelSDRetur.TabIndex = 14;
            this.labelSDRetur.Text = "s/d";
            // 
            // dtpTanggalAwalRetur
            // 
            this.dtpTanggalAwalRetur.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAwalRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalAwalRetur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAwalRetur.Location = new System.Drawing.Point(427, 112);
            this.dtpTanggalAwalRetur.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAwalRetur.Name = "dtpTanggalAwalRetur";
            this.dtpTanggalAwalRetur.Size = new System.Drawing.Size(251, 30);
            this.dtpTanggalAwalRetur.TabIndex = 13;
            // 
            // cbTanggalRetur
            // 
            this.cbTanggalRetur.AutoSize = true;
            this.cbTanggalRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanggalRetur.Location = new System.Drawing.Point(273, 116);
            this.cbTanggalRetur.Name = "cbTanggalRetur";
            this.cbTanggalRetur.Size = new System.Drawing.Size(157, 29);
            this.cbTanggalRetur.TabIndex = 12;
            this.cbTanggalRetur.Text = "Tanggal Retur";
            this.cbTanggalRetur.UseVisualStyleBackColor = true;
            this.cbTanggalRetur.CheckedChanged += new System.EventHandler(this.cbTanggalRetur_CheckedChanged);
            // 
            // tbCariRetur
            // 
            this.tbCariRetur.Location = new System.Drawing.Point(66, 116);
            this.tbCariRetur.Name = "tbCariRetur";
            this.tbCariRetur.Size = new System.Drawing.Size(201, 30);
            this.tbCariRetur.TabIndex = 11;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(8, 119);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 25);
            this.label34.TabIndex = 10;
            this.label34.Text = "Cari :";
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
            this.dgvDetailRetur.Location = new System.Drawing.Point(8, 464);
            this.dgvDetailRetur.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetailRetur.MultiSelect = false;
            this.dgvDetailRetur.Name = "dgvDetailRetur";
            this.dgvDetailRetur.ReadOnly = true;
            this.dgvDetailRetur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailRetur.Size = new System.Drawing.Size(1768, 237);
            this.dgvDetailRetur.TabIndex = 8;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(8, 435);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(112, 25);
            this.label35.TabIndex = 7;
            this.label35.Text = "Detail Retur";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(8, 79);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(123, 25);
            this.label36.TabIndex = 4;
            this.label36.Text = "Master Retur";
            // 
            // dgvMasterRetur
            // 
            this.dgvMasterRetur.AllowUserToAddRows = false;
            this.dgvMasterRetur.AllowUserToDeleteRows = false;
            this.dgvMasterRetur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMasterRetur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterRetur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterRetur.Location = new System.Drawing.Point(8, 154);
            this.dgvMasterRetur.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMasterRetur.MultiSelect = false;
            this.dgvMasterRetur.Name = "dgvMasterRetur";
            this.dgvMasterRetur.ReadOnly = true;
            this.dgvMasterRetur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasterRetur.Size = new System.Drawing.Size(1768, 277);
            this.dgvMasterRetur.TabIndex = 3;
            this.dgvMasterRetur.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMasterRetur_CellFormatting);
            this.dgvMasterRetur.SelectionChanged += new System.EventHandler(this.dgvMasterRetur_SelectionChanged);
            // 
            // btnHapusDataRetur
            // 
            this.btnHapusDataRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusDataRetur.Location = new System.Drawing.Point(419, 31);
            this.btnHapusDataRetur.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusDataRetur.Name = "btnHapusDataRetur";
            this.btnHapusDataRetur.Size = new System.Drawing.Size(208, 44);
            this.btnHapusDataRetur.TabIndex = 2;
            this.btnHapusDataRetur.Text = "Hapus Data Retur";
            this.btnHapusDataRetur.UseVisualStyleBackColor = true;
            this.btnHapusDataRetur.Click += new System.EventHandler(this.btnHapusDataRetur_Click);
            // 
            // btnUbahDataRetur
            // 
            this.btnUbahDataRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahDataRetur.Location = new System.Drawing.Point(212, 31);
            this.btnUbahDataRetur.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbahDataRetur.Name = "btnUbahDataRetur";
            this.btnUbahDataRetur.Size = new System.Drawing.Size(199, 44);
            this.btnUbahDataRetur.TabIndex = 1;
            this.btnUbahDataRetur.Text = "Ubah Data Retur";
            this.btnUbahDataRetur.UseVisualStyleBackColor = true;
            this.btnUbahDataRetur.Click += new System.EventHandler(this.btnUbahDataRetur_Click);
            // 
            // btnTambahRetur
            // 
            this.btnTambahRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahRetur.Location = new System.Drawing.Point(8, 31);
            this.btnTambahRetur.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahRetur.Name = "btnTambahRetur";
            this.btnTambahRetur.Size = new System.Drawing.Size(196, 44);
            this.btnTambahRetur.TabIndex = 0;
            this.btnTambahRetur.Text = "Tambah Retur";
            this.btnTambahRetur.UseVisualStyleBackColor = true;
            this.btnTambahRetur.Click += new System.EventHandler(this.btnTambahRetur_Click);
            // 
            // btnRetur
            // 
            this.btnRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetur.Location = new System.Drawing.Point(956, 119);
            this.btnRetur.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetur.Name = "btnRetur";
            this.btnRetur.Size = new System.Drawing.Size(180, 70);
            this.btnRetur.TabIndex = 23;
            this.btnRetur.Text = "Retur";
            this.btnRetur.UseVisualStyleBackColor = true;
            this.btnRetur.Click += new System.EventHandler(this.btnRetur_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.Location = new System.Drawing.Point(1144, 119);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(180, 70);
            this.btnLaporan.TabIndex = 24;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // panelLaporan
            // 
            this.panelLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLaporan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLaporan.Controls.Add(this.groupBox5);
            this.panelLaporan.Location = new System.Drawing.Point(16, 196);
            this.panelLaporan.Margin = new System.Windows.Forms.Padding(4);
            this.panelLaporan.Name = "panelLaporan";
            this.panelLaporan.Size = new System.Drawing.Size(1794, 719);
            this.panelLaporan.TabIndex = 24;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.reportViewerInventori);
            this.groupBox5.Controls.Add(this.reportViewerPenjualan);
            this.groupBox5.Controls.Add(this.reportViewerPembelian);
            this.groupBox5.Controls.Add(this.dtpTanggalAkhirLaporan);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.dtpTanggalAwalLaporan);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.btnLaporanInventori);
            this.groupBox5.Controls.Add(this.btnLaporanPenjualan);
            this.groupBox5.Controls.Add(this.btnLaporanPembelian);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(4, 4);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1784, 709);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Laporan";
            // 
            // reportViewerInventori
            // 
            this.reportViewerInventori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "ReportInventori";
            reportDataSource1.Value = this.ViewReportInventoriBindingSource;
            this.reportViewerInventori.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerInventori.LocalReport.ReportEmbeddedResource = "TokoSinar.ReportInventori.rdlc";
            this.reportViewerInventori.Location = new System.Drawing.Point(9, 118);
            this.reportViewerInventori.Name = "reportViewerInventori";
            this.reportViewerInventori.Size = new System.Drawing.Size(1759, 590);
            this.reportViewerInventori.TabIndex = 18;
            // 
            // reportViewerPenjualan
            // 
            this.reportViewerPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "ReportPenjualan";
            reportDataSource2.Value = this.ViewReportPenjualanBindingSource;
            this.reportViewerPenjualan.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerPenjualan.LocalReport.ReportEmbeddedResource = "TokoSinar.ReportPenjualan.rdlc";
            this.reportViewerPenjualan.Location = new System.Drawing.Point(9, 118);
            this.reportViewerPenjualan.Name = "reportViewerPenjualan";
            this.reportViewerPenjualan.Size = new System.Drawing.Size(1759, 590);
            this.reportViewerPenjualan.TabIndex = 17;
            // 
            // reportViewerPembelian
            // 
            this.reportViewerPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "ReportPembelian";
            reportDataSource3.Value = this.ViewReportPembelianBindingSource;
            this.reportViewerPembelian.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerPembelian.LocalReport.ReportEmbeddedResource = "TokoSinar.ReportPembelian.rdlc";
            this.reportViewerPembelian.Location = new System.Drawing.Point(9, 118);
            this.reportViewerPembelian.Name = "reportViewerPembelian";
            this.reportViewerPembelian.Size = new System.Drawing.Size(1759, 590);
            this.reportViewerPembelian.TabIndex = 16;
            // 
            // dtpTanggalAkhirLaporan
            // 
            this.dtpTanggalAkhirLaporan.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAkhirLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalAkhirLaporan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAkhirLaporan.Location = new System.Drawing.Point(406, 80);
            this.dtpTanggalAkhirLaporan.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAkhirLaporan.Name = "dtpTanggalAkhirLaporan";
            this.dtpTanggalAkhirLaporan.Size = new System.Drawing.Size(243, 30);
            this.dtpTanggalAkhirLaporan.TabIndex = 15;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(361, 79);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 25);
            this.label30.TabIndex = 14;
            this.label30.Text = "s/d";
            // 
            // dtpTanggalAwalLaporan
            // 
            this.dtpTanggalAwalLaporan.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAwalLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalAwalLaporan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAwalLaporan.Location = new System.Drawing.Point(104, 80);
            this.dtpTanggalAwalLaporan.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAwalLaporan.Name = "dtpTanggalAwalLaporan";
            this.dtpTanggalAwalLaporan.Size = new System.Drawing.Size(251, 30);
            this.dtpTanggalAwalLaporan.TabIndex = 13;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(8, 85);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(90, 25);
            this.label37.TabIndex = 10;
            this.label37.Text = "Periode :";
            // 
            // btnLaporanInventori
            // 
            this.btnLaporanInventori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanInventori.Location = new System.Drawing.Point(531, 31);
            this.btnLaporanInventori.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaporanInventori.Name = "btnLaporanInventori";
            this.btnLaporanInventori.Size = new System.Drawing.Size(260, 44);
            this.btnLaporanInventori.TabIndex = 2;
            this.btnLaporanInventori.Text = "Buat Laporan Inventori";
            this.btnLaporanInventori.UseVisualStyleBackColor = true;
            this.btnLaporanInventori.Click += new System.EventHandler(this.btnLaporanInventori_Click);
            // 
            // btnLaporanPenjualan
            // 
            this.btnLaporanPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanPenjualan.Location = new System.Drawing.Point(273, 31);
            this.btnLaporanPenjualan.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaporanPenjualan.Name = "btnLaporanPenjualan";
            this.btnLaporanPenjualan.Size = new System.Drawing.Size(250, 44);
            this.btnLaporanPenjualan.TabIndex = 1;
            this.btnLaporanPenjualan.Text = "Buat Laporan Penjualan";
            this.btnLaporanPenjualan.UseVisualStyleBackColor = true;
            this.btnLaporanPenjualan.Click += new System.EventHandler(this.btnLaporanPenjualan_Click);
            // 
            // btnLaporanPembelian
            // 
            this.btnLaporanPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanPembelian.Location = new System.Drawing.Point(8, 31);
            this.btnLaporanPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaporanPembelian.Name = "btnLaporanPembelian";
            this.btnLaporanPembelian.Size = new System.Drawing.Size(259, 44);
            this.btnLaporanPembelian.TabIndex = 0;
            this.btnLaporanPembelian.Text = "Buat Laporan Pembelian";
            this.btnLaporanPembelian.UseVisualStyleBackColor = true;
            this.btnLaporanPembelian.Click += new System.EventHandler(this.btnLaporanPembelian_Click);
            // 
            // ViewReportPembelianTableAdapter
            // 
            this.ViewReportPembelianTableAdapter.ClearBeforeFill = true;
            // 
            // ViewReportPenjualanTableAdapter
            // 
            this.ViewReportPenjualanTableAdapter.ClearBeforeFill = true;
            // 
            // ViewReportInventoriTableAdapter
            // 
            this.ViewReportInventoriTableAdapter.ClearBeforeFill = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1332, 119);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 70);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(865, 21);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(331, 58);
            this.label38.TabIndex = 26;
            this.label38.Text = "TOKO SINAR\r\nJL. LETJEN SAMUJI NO.29";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 928);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelLaporan);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.panelRetur);
            this.Controls.Add(this.btnRetur);
            this.Controls.Add(this.panelPenjualan);
            this.Controls.Add(this.btnPenjualan);
            this.Controls.Add(this.panelPembelian);
            this.Controls.Add(this.panelBarang);
            this.Controls.Add(this.btnOlahBarang);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.panelOlahKaryawan);
            this.Controls.Add(this.btnOlahKaryawan);
            this.Controls.Add(this.btnPembelian);
            this.Controls.Add(this.labelTanggalJam);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenuUtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportInventoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TokoSinarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportPenjualanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportPembelianBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelPembelian.ResumeLayout(false);
            this.groupBoxPembelian.ResumeLayout(false);
            this.groupBoxPembelian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterPembelian)).EndInit();
            this.panelOlahKaryawan.ResumeLayout(false);
            this.groupBoxKayawan.ResumeLayout(false);
            this.groupBoxKayawan.PerformLayout();
            this.groupBoxTambahUbahKaryawan.ResumeLayout(false);
            this.groupBoxTambahUbahKaryawan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterKaryawan)).EndInit();
            this.panelSupplier.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTambahUbahSupplier.ResumeLayout(false);
            this.groupBoxTambahUbahSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSupplier)).EndInit();
            this.panelBarang.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTambahUbahBarang.ResumeLayout(false);
            this.groupBoxTambahUbahBarang.PerformLayout();
            this.groupBoxSupplierBaru.ResumeLayout(false);
            this.groupBoxSupplierBaru.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterBarang)).EndInit();
            this.panelPenjualan.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterPenjualan)).EndInit();
            this.panelRetur.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRetur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterRetur)).EndInit();
            this.panelLaporan.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelUbahPassword;
        private System.Windows.Forms.Panel panelPembelian;
        private System.Windows.Forms.GroupBox groupBoxPembelian;
        private System.Windows.Forms.DataGridView dgvDetailPembelian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMasterPembelian;
        private System.Windows.Forms.Button btnHapusPembelian;
        private System.Windows.Forms.Button btnUbahPembelian;
        private System.Windows.Forms.Button btnPembelianBaru;
        private System.Windows.Forms.Label labelTanggalJam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPembelian;
        private System.Windows.Forms.Button btnUbahStatus;
        private System.Windows.Forms.DateTimePicker dtpTanggalAwalCariPembelian;
        private System.Windows.Forms.CheckBox cbTanggalFakturPembelian;
        private System.Windows.Forms.TextBox tbCariPembelian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhirCariPembelian;
        private System.Windows.Forms.Label labelSDPembelian;
        private System.Windows.Forms.Button btnCariPembelian;
        private System.Windows.Forms.Button btnOlahKaryawan;
        private System.Windows.Forms.Panel panelOlahKaryawan;
        private System.Windows.Forms.DataGridView dgvMasterKaryawan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxKayawan;
        private System.Windows.Forms.Button btnTambahKaryawan;
        private System.Windows.Forms.GroupBox groupBoxTambahUbahKaryawan;
        private System.Windows.Forms.Button btnSimpanKaryawan;
        private System.Windows.Forms.ComboBox cbStatusKaryawan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbJenisKaryawan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAlamatKaryawan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNamaKaryawan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUsernameKaryawan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUbahDataKaryawan;
        private System.Windows.Forms.TextBox tbCariKaryawan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHapusDataKaryawan;
        private System.Windows.Forms.Button btnResetPasswordKaryawan;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariSupplier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUbahDataSupplier;
        private System.Windows.Forms.GroupBox groupBoxTambahUbahSupplier;
        private System.Windows.Forms.TextBox tbTelpSupplier;
        private System.Windows.Forms.Button btnSimpanSupplier;
        private System.Windows.Forms.ComboBox cbStatusSupplier;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAlamatSupplier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbNamaSupplier;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbKodeSupplier;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvMasterSupplier;
        private System.Windows.Forms.Button btnTambahSupplierBaru;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnOlahBarang;
        private System.Windows.Forms.Panel panelBarang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCariBarang;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnUbahDataBarang;
        private System.Windows.Forms.GroupBox groupBoxTambahUbahBarang;
        private System.Windows.Forms.GroupBox groupBoxSupplierBaru;
        private System.Windows.Forms.ComboBox cbNamaSupplier;
        private System.Windows.Forms.TextBox tbNoTelpSupplier;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbAlamatSupplierBarang;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RadioButton radioSupplierBaru;
        private System.Windows.Forms.RadioButton radioSupplierLama;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbHargaJualBarang;
        private System.Windows.Forms.TextBox tbHargaBeliBarang;
        private System.Windows.Forms.Button btnSimpanBarang;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbSatuanBarang;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvMasterBarang;
        private System.Windows.Forms.Button btnTambahBarangBaru;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Panel panelPenjualan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCariPenjualan;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhirPenjualan;
        private System.Windows.Forms.Label labelSDPenjualan;
        private System.Windows.Forms.DateTimePicker dtpTanggalAwalPenjualan;
        private System.Windows.Forms.CheckBox cbTanggalPenjualan;
        private System.Windows.Forms.TextBox tbCariPenjualan;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dgvDetailPenjualan;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dgvMasterPenjualan;
        private System.Windows.Forms.Button btnHapusPenjualan;
        private System.Windows.Forms.Button btnUbahPenjualan;
        private System.Windows.Forms.Button btnPenjualanBaru;
        private System.Windows.Forms.Panel panelRetur;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCariRetur;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhirRetur;
        private System.Windows.Forms.Label labelSDRetur;
        private System.Windows.Forms.DateTimePicker dtpTanggalAwalRetur;
        private System.Windows.Forms.CheckBox cbTanggalRetur;
        private System.Windows.Forms.TextBox tbCariRetur;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridView dgvDetailRetur;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dgvMasterRetur;
        private System.Windows.Forms.Button btnHapusDataRetur;
        private System.Windows.Forms.Button btnUbahDataRetur;
        private System.Windows.Forms.Button btnTambahRetur;
        private System.Windows.Forms.Button btnRetur;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Panel panelLaporan;
        private System.Windows.Forms.GroupBox groupBox5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPembelian;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhirLaporan;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtpTanggalAwalLaporan;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnLaporanInventori;
        private System.Windows.Forms.Button btnLaporanPenjualan;
        private System.Windows.Forms.Button btnLaporanPembelian;
        private System.Windows.Forms.BindingSource ViewReportPembelianBindingSource;
        private TokoSinarDataSet TokoSinarDataSet;
        private TokoSinarDataSetTableAdapters.ViewReportPembelianTableAdapter ViewReportPembelianTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPenjualan;
        private System.Windows.Forms.BindingSource ViewReportPenjualanBindingSource;
        private TokoSinarDataSetTableAdapters.ViewReportPenjualanTableAdapter ViewReportPenjualanTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInventori;
        private System.Windows.Forms.BindingSource ViewReportInventoriBindingSource;
        private TokoSinarDataSetTableAdapters.ViewReportInventoriTableAdapter ViewReportInventoriTableAdapter;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label38;
    }
}