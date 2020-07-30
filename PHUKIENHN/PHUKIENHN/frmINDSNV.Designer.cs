namespace PHUKIENHN
{
    partial class frmINDSNV
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
            this.crvINDSNV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvINDSNV
            // 
            this.crvINDSNV.ActiveViewIndex = -1;
            this.crvINDSNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvINDSNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvINDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvINDSNV.Location = new System.Drawing.Point(0, 0);
            this.crvINDSNV.Name = "crvINDSNV";
            this.crvINDSNV.Size = new System.Drawing.Size(1017, 492);
            this.crvINDSNV.TabIndex = 0;
            // 
            // frmINDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 492);
            this.Controls.Add(this.crvINDSNV);
            this.Name = "frmINDSNV";
            this.Text = "frmINDSNV";
            this.Load += new System.EventHandler(this.frmINDSNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvINDSNV;
    }
}