namespace PHUKIENHN.DAO
{
    partial class frmINHOADON
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
            this.crvINHOADON = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvINHOADON
            // 
            this.crvINHOADON.ActiveViewIndex = -1;
            this.crvINHOADON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvINHOADON.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvINHOADON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvINHOADON.Location = new System.Drawing.Point(0, 0);
            this.crvINHOADON.Name = "crvINHOADON";
            this.crvINHOADON.Size = new System.Drawing.Size(968, 539);
            this.crvINHOADON.TabIndex = 0;
            // 
            // frmINHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 539);
            this.Controls.Add(this.crvINHOADON);
            this.Name = "frmINHOADON";
            this.Text = "In hoá đơn";
            this.Load += new System.EventHandler(this.frmINHOADON_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvINHOADON;
    }
}