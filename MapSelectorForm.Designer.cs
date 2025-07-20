namespace EShiftApp
{
    partial class MapSelectorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.WebBrowser webBrowser1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 600);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // MapSelectorForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.webBrowser1);
            this.Name = "MapSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Location on Map";
            this.Load += new System.EventHandler(this.MapSelectorForm_Load);
            this.ResumeLayout(false);

        }
    }
}
