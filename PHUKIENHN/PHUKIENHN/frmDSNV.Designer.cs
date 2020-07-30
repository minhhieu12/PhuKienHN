namespace PHUKIENHN
{
    partial class frmDSNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSNV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.cboCHUCVU = new System.Windows.Forms.ComboBox();
            this.dateNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.txtQUEQUAN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtTENDN = new System.Windows.Forms.TextBox();
            this.txtDIENTHOAI = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHUKIENHNDataSet = new PHUKIENHN.PHUKIENHNDataSet();
            this.btnTHEMNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnSUANV = new DevExpress.XtraEditors.SimpleButton();
            this.btnXOANV = new DevExpress.XtraEditors.SimpleButton();
            this.btnLUU = new DevExpress.XtraEditors.SimpleButton();
            this.btnINDSNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnXUATEXCEL = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.nHANVIENTableAdapter = new PHUKIENHN.PHUKIENHNDataSetTableAdapters.NHANVIENTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.cboCHUCVU);
            this.groupBox1.Controls.Add(this.dateNGAYSINH);
            this.groupBox1.Controls.Add(this.txtQUEQUAN);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtEMAIL);
            this.groupBox1.Controls.Add(this.txtTENDN);
            this.groupBox1.Controls.Add(this.txtDIENTHOAI);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Controls.Add(this.txtHOTEN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(464, 49);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(43, 20);
            this.radNu.TabIndex = 4;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(403, 50);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(55, 20);
            this.radNam.TabIndex = 4;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // cboCHUCVU
            // 
            this.cboCHUCVU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCHUCVU.FormattingEnabled = true;
            this.cboCHUCVU.Location = new System.Drawing.Point(663, 76);
            this.cboCHUCVU.Name = "cboCHUCVU";
            this.cboCHUCVU.Size = new System.Drawing.Size(155, 24);
            this.cboCHUCVU.TabIndex = 3;
            // 
            // dateNGAYSINH
            // 
            this.dateNGAYSINH.CustomFormat = "dd/MM/yyyy";
            this.dateNGAYSINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNGAYSINH.Location = new System.Drawing.Point(403, 20);
            this.dateNGAYSINH.Name = "dateNGAYSINH";
            this.dateNGAYSINH.Size = new System.Drawing.Size(145, 22);
            this.dateNGAYSINH.TabIndex = 2;
            // 
            // txtQUEQUAN
            // 
            this.txtQUEQUAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQUEQUAN.Location = new System.Drawing.Point(149, 81);
            this.txtQUEQUAN.Name = "txtQUEQUAN";
            this.txtQUEQUAN.Size = new System.Drawing.Size(145, 22);
            this.txtQUEQUAN.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(946, 48);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(152, 22);
            this.txtMK.TabIndex = 1;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMAIL.Location = new System.Drawing.Point(663, 48);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(155, 22);
            this.txtEMAIL.TabIndex = 1;
            // 
            // txtTENDN
            // 
            this.txtTENDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENDN.Location = new System.Drawing.Point(946, 22);
            this.txtTENDN.Name = "txtTENDN";
            this.txtTENDN.Size = new System.Drawing.Size(152, 22);
            this.txtTENDN.TabIndex = 1;
            // 
            // txtDIENTHOAI
            // 
            this.txtDIENTHOAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIENTHOAI.Location = new System.Drawing.Point(663, 18);
            this.txtDIENTHOAI.Name = "txtDIENTHOAI";
            this.txtDIENTHOAI.Size = new System.Drawing.Size(155, 22);
            this.txtDIENTHOAI.TabIndex = 1;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(403, 76);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(145, 22);
            this.txtCMND.TabIndex = 1;
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(149, 25);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(145, 22);
            this.txtMANV.TabIndex = 1;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOTEN.Location = new System.Drawing.Point(149, 53);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(145, 22);
            this.txtHOTEN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quê quán (Tỉnh/TP):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(838, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(838, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên đăng nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(587, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(586, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chức vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điện thoại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "CMND:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.AutoGenerateColumns = false;
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.NGAYSINH,
            this.GIOITINH,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDSNV.DataSource = this.nHANVIENBindingSource;
            this.dgvDSNV.Location = new System.Drawing.Point(12, 136);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.Size = new System.Drawing.Size(1104, 241);
            this.dgvDSNV.TabIndex = 5;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.pHUKIENHNDataSet;
            // 
            // pHUKIENHNDataSet
            // 
            this.pHUKIENHNDataSet.DataSetName = "PHUKIENHNDataSet";
            this.pHUKIENHNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTHEMNV
            // 
            this.btnTHEMNV.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHEMNV.Appearance.Options.UseFont = true;
            this.btnTHEMNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHEMNV.ImageOptions.Image")));
            this.btnTHEMNV.Location = new System.Drawing.Point(12, 383);
            this.btnTHEMNV.Name = "btnTHEMNV";
            this.btnTHEMNV.Size = new System.Drawing.Size(143, 40);
            this.btnTHEMNV.TabIndex = 4;
            this.btnTHEMNV.Text = "Thêm nhân viên";
            this.btnTHEMNV.Click += new System.EventHandler(this.btnTHEMNV_Click);
            // 
            // btnSUANV
            // 
            this.btnSUANV.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUANV.Appearance.Options.UseFont = true;
            this.btnSUANV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSUANV.ImageOptions.Image")));
            this.btnSUANV.Location = new System.Drawing.Point(293, 383);
            this.btnSUANV.Name = "btnSUANV";
            this.btnSUANV.Size = new System.Drawing.Size(126, 40);
            this.btnSUANV.TabIndex = 4;
            this.btnSUANV.Text = "Sừa nhân viên";
            this.btnSUANV.Click += new System.EventHandler(this.btnSUANV_Click);
            // 
            // btnXOANV
            // 
            this.btnXOANV.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOANV.Appearance.Options.UseFont = true;
            this.btnXOANV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXOANV.ImageOptions.Image")));
            this.btnXOANV.Location = new System.Drawing.Point(161, 383);
            this.btnXOANV.Name = "btnXOANV";
            this.btnXOANV.Size = new System.Drawing.Size(126, 40);
            this.btnXOANV.TabIndex = 4;
            this.btnXOANV.Text = "Xoá nhân viên";
            this.btnXOANV.Click += new System.EventHandler(this.btnXOANV_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLUU.Appearance.Options.UseFont = true;
            this.btnLUU.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLUU.ImageOptions.Image")));
            this.btnLUU.Location = new System.Drawing.Point(643, 385);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(78, 40);
            this.btnLUU.TabIndex = 4;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // btnINDSNV
            // 
            this.btnINDSNV.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINDSNV.Appearance.Options.UseFont = true;
            this.btnINDSNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnINDSNV.ImageOptions.Image")));
            this.btnINDSNV.Location = new System.Drawing.Point(727, 383);
            this.btnINDSNV.Name = "btnINDSNV";
            this.btnINDSNV.Size = new System.Drawing.Size(120, 40);
            this.btnINDSNV.TabIndex = 4;
            this.btnINDSNV.Text = "In danh sách";
            this.btnINDSNV.Click += new System.EventHandler(this.btnINDSNV_Click);
            // 
            // btnXUATEXCEL
            // 
            this.btnXUATEXCEL.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXUATEXCEL.Appearance.Options.UseFont = true;
            this.btnXUATEXCEL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXUATEXCEL.ImageOptions.Image")));
            this.btnXUATEXCEL.Location = new System.Drawing.Point(853, 383);
            this.btnXUATEXCEL.Name = "btnXUATEXCEL";
            this.btnXUATEXCEL.Size = new System.Drawing.Size(133, 40);
            this.btnXUATEXCEL.TabIndex = 4;
            this.btnXUATEXCEL.Text = "Xuất file Excel";
            this.btnXUATEXCEL.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(992, 383);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MANV";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENNV";
            this.Column3.HeaderText = "Họ và tên";
            this.Column3.Name = "Column3";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GIOITINH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "QUEQUAN";
            this.Column4.HeaderText = "Quê quán";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CMND";
            this.Column5.HeaderText = "CMND";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "Điện thoại";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "EMAIL";
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CHUCVU";
            this.Column8.HeaderText = "Chức vụ";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TENDN";
            this.Column9.HeaderText = "Tên đăng nhập";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MATKHAU";
            this.Column10.HeaderText = "Mật khẩu";
            this.Column10.Name = "Column10";
            // 
            // frmDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 435);
            this.Controls.Add(this.dgvDSNV);
            this.Controls.Add(this.btnSUANV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXUATEXCEL);
            this.Controls.Add(this.btnINDSNV);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnXOANV);
            this.Controls.Add(this.btnTHEMNV);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDSNV";
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.frmDSNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNGAYSINH;
        private System.Windows.Forms.TextBox txtQUEQUAN;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtDIENTHOAI;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTENDN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnTHEMNV;
        private DevExpress.XtraEditors.SimpleButton btnSUANV;
        private DevExpress.XtraEditors.SimpleButton btnXOANV;
        private DevExpress.XtraEditors.SimpleButton btnLUU;
        private DevExpress.XtraEditors.SimpleButton btnINDSNV;
        private DevExpress.XtraEditors.SimpleButton btnXUATEXCEL;
        private System.Windows.Forms.ComboBox cboCHUCVU;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private PHUKIENHNDataSet pHUKIENHNDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private PHUKIENHNDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}