namespace PHUKIENHN
{
    partial class frmTHEMSANPHAMMOI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTHEMSANPHAMMOI));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTHEMNCC = new DevExpress.XtraEditors.SimpleButton();
            this.btnLUU = new DevExpress.XtraEditors.SimpleButton();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.txtGIA = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTENSP = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtMASP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHUKIENHNDataSet1 = new PHUKIENHN.PHUKIENHNDataSet1();
            this.sANPHAMTableAdapter = new PHUKIENHN.PHUKIENHNDataSet1TableAdapters.SANPHAMTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.btnTHEMMOI = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP:";
            // 
            // btnTHEMNCC
            // 
            this.btnTHEMNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHEMNCC.ImageOptions.Image")));
            this.btnTHEMNCC.Location = new System.Drawing.Point(357, 92);
            this.btnTHEMNCC.Name = "btnTHEMNCC";
            this.btnTHEMNCC.Size = new System.Drawing.Size(96, 34);
            this.btnTHEMNCC.TabIndex = 3;
            this.btnTHEMNCC.Text = "Thêm NCC";
            this.btnTHEMNCC.Click += new System.EventHandler(this.btnTHEMNCC_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLUU.ImageOptions.Image")));
            this.btnLUU.Location = new System.Drawing.Point(357, 12);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(96, 34);
            this.btnLUU.TabIndex = 3;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // cboNCC
            // 
            this.cboNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(98, 99);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(230, 24);
            this.cboNCC.TabIndex = 2;
            this.cboNCC.SelectedIndexChanged += new System.EventHandler(this.cboNCC_SelectedIndexChanged);
            // 
            // txtGIA
            // 
            this.txtGIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGIA.Location = new System.Drawing.Point(98, 185);
            this.txtGIA.Name = "txtGIA";
            this.txtGIA.Size = new System.Drawing.Size(230, 22);
            this.txtGIA.TabIndex = 1;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(98, 157);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(230, 22);
            this.txtSL.TabIndex = 1;
            // 
            // txtTENSP
            // 
            this.txtTENSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENSP.Location = new System.Drawing.Point(98, 43);
            this.txtTENSP.Name = "txtTENSP";
            this.txtTENSP.Size = new System.Drawing.Size(230, 22);
            this.txtTENSP.TabIndex = 1;
            // 
            // txtNCC
            // 
            this.txtNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCC.Location = new System.Drawing.Point(98, 129);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.ReadOnly = true;
            this.txtNCC.Size = new System.Drawing.Size(230, 22);
            this.txtNCC.TabIndex = 1;
            // 
            // txtMASP
            // 
            this.txtMASP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASP.Location = new System.Drawing.Point(98, 12);
            this.txtMASP.Name = "txtMASP";
            this.txtMASP.ReadOnly = true;
            this.txtMASP.Size = new System.Drawing.Size(230, 22);
            this.txtMASP.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên NCC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NCC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên SP:";
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.pHUKIENHNDataSet1;
            // 
            // pHUKIENHNDataSet1
            // 
            this.pHUKIENHNDataSet1.DataSetName = "PHUKIENHNDataSet1";
            this.pHUKIENHNDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ĐVT:";
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(98, 71);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(230, 22);
            this.txtDVT.TabIndex = 1;
            // 
            // btnTHEMMOI
            // 
            this.btnTHEMMOI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnTHEMMOI.Location = new System.Drawing.Point(357, 52);
            this.btnTHEMMOI.Name = "btnTHEMMOI";
            this.btnTHEMMOI.Size = new System.Drawing.Size(96, 34);
            this.btnTHEMMOI.TabIndex = 3;
            this.btnTHEMMOI.Text = "Thêm mới";
            this.btnTHEMMOI.Click += new System.EventHandler(this.btnTHEMMOI_Click);
            // 
            // frmTHEMSANPHAMMOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 223);
            this.Controls.Add(this.btnTHEMNCC);
            this.Controls.Add(this.btnTHEMMOI);
            this.Controls.Add(this.txtMASP);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGIA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTENSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.label6);
            this.Name = "frmTHEMSANPHAMMOI";
            this.Text = "THÊM SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmTHEMSANPHAMMOI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTHEMNCC;
        private DevExpress.XtraEditors.SimpleButton btnLUU;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.TextBox txtGIA;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTENSP;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtMASP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private PHUKIENHNDataSet1 pHUKIENHNDataSet1;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private PHUKIENHNDataSet1TableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnTHEMMOI;
    }
}