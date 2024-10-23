
namespace SS_SOFTWARE_BARCODE
{
    partial class Form2
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
            this.cryBarcode = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CRY_BARCODE_PRINTING1 = new SS_SOFTWARE_BARCODE.CRY_BARCODE_PRINTING();
            this.SuspendLayout();
            // 
            // cryBarcode
            // 
            this.cryBarcode.ActiveViewIndex = 0;
            this.cryBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryBarcode.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryBarcode.Location = new System.Drawing.Point(0, 0);
            this.cryBarcode.Name = "cryBarcode";
            this.cryBarcode.ReportSource = this.CRY_BARCODE_PRINTING1;
            this.cryBarcode.Size = new System.Drawing.Size(800, 450);
            this.cryBarcode.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryBarcode);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer cryBarcode;
        private CRY_BARCODE_PRINTING CRY_BARCODE_PRINTING1;
    }
}