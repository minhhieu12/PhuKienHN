namespace PHUKIENHN
{
    partial class frmTinhLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhLuong));
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTenNhanVien = new System.Windows.Forms.ComboBox();
            this.btnTinhLuong = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayCham = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayNghi = new System.Windows.Forms.TextBox();
            this.txtPhat = new System.Windows.Forms.TextBox();
            this.txtThuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnXuatBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvChamCong.Location = new System.Drawing.Point(12, 226);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.Size = new System.Drawing.Size(896, 283);
            this.dgvChamCong.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Họ và tên";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày chấm lương";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số giờ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Lương/giờ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Thưởng";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Phạt";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tổng lương";
            this.Column10.Name = "Column10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboTenNhanVien);
            this.groupBox2.Controls.Add(this.btnTinhLuong);
            this.groupBox2.Controls.Add(this.dateNgayCham);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNgayNghi);
            this.groupBox2.Controls.Add(this.txtPhat);
            this.groupBox2.Controls.Add(this.txtThuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chấm công";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cboTenNhanVien
            // 
            this.cboTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenNhanVien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTenNhanVien.FormattingEnabled = true;
            this.cboTenNhanVien.Location = new System.Drawing.Point(106, 23);
            this.cboTenNhanVien.Name = "cboTenNhanVien";
            this.cboTenNhanVien.Size = new System.Drawing.Size(192, 24);
            this.cboTenNhanVien.TabIndex = 3;
            this.cboTenNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboTenNhanVien_SelectedIndexChanged);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.ImageOptions.Image")));
            this.btnTinhLuong.Location = new System.Drawing.Point(691, 26);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(122, 38);
            this.btnTinhLuong.TabIndex = 2;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // dateNgayCham
            // 
            this.dateNgayCham.CustomFormat = "dd/MM/yyyy";
            this.dateNgayCham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayCham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayCham.Location = new System.Drawing.Point(105, 59);
            this.dateNgayCham.Name = "dateNgayCham";
            this.dateNgayCham.Size = new System.Drawing.Size(122, 22);
            this.dateNgayCham.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ngày";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(566, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(566, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày nghỉ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(369, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phạt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thưởng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ngày chấm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhân viên:";
            // 
            // txtNgayNghi
            // 
            this.txtNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayNghi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNgayNghi.Location = new System.Drawing.Point(457, 70);
            this.txtNgayNghi.Name = "txtNgayNghi";
            this.txtNgayNghi.Size = new System.Drawing.Size(103, 22);
            this.txtNgayNghi.TabIndex = 1;
            // 
            // txtPhat
            // 
            this.txtPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPhat.Location = new System.Drawing.Point(457, 42);
            this.txtPhat.Name = "txtPhat";
            this.txtPhat.Size = new System.Drawing.Size(103, 22);
            this.txtPhat.TabIndex = 1;
            // 
            // txtThuong
            // 
            this.txtThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtThuong.Location = new System.Drawing.Point(457, 11);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.Size = new System.Drawing.Size(103, 22);
            this.txtThuong.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(29, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "TỔNG LƯƠNG:";
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongLuong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTongLuong.Location = new System.Drawing.Point(146, 117);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(237, 22);
            this.txtTongLuong.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(391, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "VNĐ";
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatBaoCao.ImageOptions.Image")));
            this.btnXuatBaoCao.Location = new System.Drawing.Point(222, 164);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(115, 38);
            this.btnXuatBaoCao.TabIndex = 2;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(703, 164);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 38);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(343, 164);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sừa";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(424, 164);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 521);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.label14);
            this.Name = "frmTinhLuong";
            this.Text = "Tính lương";
            this.Load += new System.EventHandler(this.frmTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnTinhLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhat;
        private System.Windows.Forms.TextBox txtThuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTongLuong;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.SimpleButton btnXuatBaoCao;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ComboBox cboTenNhanVien;
        private System.Windows.Forms.DateTimePicker dateNgayCham;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayNghi;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}