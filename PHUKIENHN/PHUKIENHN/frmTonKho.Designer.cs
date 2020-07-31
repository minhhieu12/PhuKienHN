namespace PHUKIENHN
{
    partial class frmTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonKho));
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.pHUKIENHNDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHUKIENHNDataSet1 = new PHUKIENHN.PHUKIENHNDataSet1();
            this.btnXUATEXCEL = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.cTHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHOADONTableAdapter = new PHUKIENHN.PHUKIENHNDataSet1TableAdapters.CTHOADONTableAdapter();
            this.pHUKIENHNDataSet2 = new PHUKIENHN.PHUKIENHNDataSet2();
            this.pHUKIENHNDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new PHUKIENHN.PHUKIENHNDataSet1TableAdapters.SANPHAMTableAdapter();
            this.sANPHAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLTONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AutoGenerateColumns = false;
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.mASPDataGridViewTextBoxColumn,
            this.tENSPDataGridViewTextBoxColumn,
            this.dVTDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.sLTONDataGridViewTextBoxColumn});
            this.dgvTonKho.DataSource = this.sANPHAMBindingSource1;
            this.dgvTonKho.Location = new System.Drawing.Point(12, 79);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.Size = new System.Drawing.Size(674, 404);
            this.dgvTonKho.TabIndex = 1;
            this.dgvTonKho.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // pHUKIENHNDataSet1BindingSource
            // 
            this.pHUKIENHNDataSet1BindingSource.DataSource = this.pHUKIENHNDataSet1;
            this.pHUKIENHNDataSet1BindingSource.Position = 0;
            // 
            // pHUKIENHNDataSet1
            // 
            this.pHUKIENHNDataSet1.DataSetName = "PHUKIENHNDataSet1";
            this.pHUKIENHNDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXUATEXCEL
            // 
            this.btnXUATEXCEL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnXUATEXCEL.Location = new System.Drawing.Point(697, 81);
            this.btnXUATEXCEL.Name = "btnXUATEXCEL";
            this.btnXUATEXCEL.Size = new System.Drawing.Size(116, 41);
            this.btnXUATEXCEL.TabIndex = 4;
            this.btnXUATEXCEL.Text = "Xuất báo cáo";
            this.btnXUATEXCEL.Click += new System.EventHandler(this.btnXUATEXCEL_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(697, 132);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 41);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTIMKIEM);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 61);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm hàng hoá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên hàng hoá:";
            // 
            // txtTIMKIEM
            // 
            this.txtTIMKIEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIMKIEM.Location = new System.Drawing.Point(117, 25);
            this.txtTIMKIEM.Name = "txtTIMKIEM";
            this.txtTIMKIEM.Size = new System.Drawing.Size(551, 22);
            this.txtTIMKIEM.TabIndex = 0;
            this.txtTIMKIEM.TextChanged += new System.EventHandler(this.txtTIMKIEM_TextChanged);
            // 
            // cTHOADONBindingSource
            // 
            this.cTHOADONBindingSource.DataMember = "CTHOADON";
            this.cTHOADONBindingSource.DataSource = this.pHUKIENHNDataSet1BindingSource;
            // 
            // cTHOADONTableAdapter
            // 
            this.cTHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // pHUKIENHNDataSet2
            // 
            this.pHUKIENHNDataSet2.DataSetName = "PHUKIENHNDataSet2";
            this.pHUKIENHNDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHUKIENHNDataSet2BindingSource
            // 
            this.pHUKIENHNDataSet2BindingSource.DataSource = this.pHUKIENHNDataSet2;
            this.pHUKIENHNDataSet2BindingSource.Position = 0;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.pHUKIENHNDataSet1BindingSource;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // sANPHAMBindingSource1
            // 
            this.sANPHAMBindingSource1.DataMember = "SANPHAM";
            this.sANPHAMBindingSource1.DataSource = this.pHUKIENHNDataSet1BindingSource;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MASP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "Mã hàng hoá";
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TENSP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "Tên hàng hoá";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            this.tENSPDataGridViewTextBoxColumn.Width = 200;
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // sLTONDataGridViewTextBoxColumn
            // 
            this.sLTONDataGridViewTextBoxColumn.DataPropertyName = "SLTON";
            this.sLTONDataGridViewTextBoxColumn.HeaderText = "Số lượng tồn";
            this.sLTONDataGridViewTextBoxColumn.Name = "sLTONDataGridViewTextBoxColumn";
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvTonKho);
            this.Controls.Add(this.btnXUATEXCEL);
            this.Name = "frmTonKho";
            this.Text = "Tồn kho";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTonKho;
        private DevExpress.XtraEditors.SimpleButton btnXUATEXCEL;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.BindingSource pHUKIENHNDataSet1BindingSource;
        private PHUKIENHNDataSet1 pHUKIENHNDataSet1;
        private System.Windows.Forms.BindingSource cTHOADONBindingSource;
        private PHUKIENHNDataSet1TableAdapters.CTHOADONTableAdapter cTHOADONTableAdapter;
        private PHUKIENHNDataSet2 pHUKIENHNDataSet2;
        private System.Windows.Forms.BindingSource pHUKIENHNDataSet2BindingSource;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private PHUKIENHNDataSet1TableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLTONDataGridViewTextBoxColumn;
    }
}