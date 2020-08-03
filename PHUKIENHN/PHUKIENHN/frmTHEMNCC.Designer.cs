namespace PHUKIENHN
{
    partial class frmTHEMNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTHEMNCC));
            this.btnLUU = new DevExpress.XtraEditors.SimpleButton();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtTENNCC = new System.Windows.Forms.TextBox();
            this.txtMANCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHUKIENHNDataSet3 = new PHUKIENHN.PHUKIENHNDataSet3();
            this.nHACUNGCAPTableAdapter = new PHUKIENHN.PHUKIENHNDataSet3TableAdapters.NHACUNGCAPTableAdapter();
            this.btnTHEMMOI = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLUU
            // 
            this.btnLUU.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLUU.ImageOptions.Image")));
            this.btnLUU.Location = new System.Drawing.Point(322, 12);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(96, 34);
            this.btnLUU.TabIndex = 3;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(90, 158);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(208, 20);
            this.txtEMAIL.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(90, 132);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(208, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(90, 71);
            this.txtDIACHI.Multiline = true;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(208, 55);
            this.txtDIACHI.TabIndex = 1;
            // 
            // txtTENNCC
            // 
            this.txtTENNCC.Location = new System.Drawing.Point(90, 43);
            this.txtTENNCC.Name = "txtTENNCC";
            this.txtTENNCC.Size = new System.Drawing.Size(208, 20);
            this.txtTENNCC.TabIndex = 1;
            // 
            // txtMANCC
            // 
            this.txtMANCC.Location = new System.Drawing.Point(90, 12);
            this.txtMANCC.Name = "txtMANCC";
            this.txtMANCC.ReadOnly = true;
            this.txtMANCC.Size = new System.Drawing.Size(208, 20);
            this.txtMANCC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "SDT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NCC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC:";
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.pHUKIENHNDataSet3;
            // 
            // pHUKIENHNDataSet3
            // 
            this.pHUKIENHNDataSet3.DataSetName = "PHUKIENHNDataSet3";
            this.pHUKIENHNDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // btnTHEMMOI
            // 
            this.btnTHEMMOI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnTHEMMOI.Location = new System.Drawing.Point(322, 52);
            this.btnTHEMMOI.Name = "btnTHEMMOI";
            this.btnTHEMMOI.Size = new System.Drawing.Size(96, 34);
            this.btnTHEMMOI.TabIndex = 3;
            this.btnTHEMMOI.Text = "Thêm mới";
            this.btnTHEMMOI.Click += new System.EventHandler(this.btnTHEMMOI_Click);
            // 
            // frmTHEMNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 190);
            this.Controls.Add(this.btnTHEMMOI);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtDIACHI);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTENNCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMANCC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Name = "frmTHEMNCC";
            this.Text = "THÊM NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.frmTHEMNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUKIENHNDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnLUU;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtTENNCC;
        private System.Windows.Forms.TextBox txtMANCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PHUKIENHNDataSet3 pHUKIENHNDataSet3;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private PHUKIENHNDataSet3TableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnTHEMMOI;
    }
}