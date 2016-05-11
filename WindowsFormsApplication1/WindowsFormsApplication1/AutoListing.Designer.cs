namespace WindowsFormsApplication1
{
    partial class AutoListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoListing));
            this.kaymuLogo = new System.Windows.Forms.PictureBox();
            this.webBrowse = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.kaymuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // kaymuLogo
            // 
            this.kaymuLogo.Image = ((System.Drawing.Image)(resources.GetObject("kaymuLogo.Image")));
            this.kaymuLogo.Location = new System.Drawing.Point(12, 12);
            this.kaymuLogo.Name = "kaymuLogo";
            this.kaymuLogo.Size = new System.Drawing.Size(276, 95);
            this.kaymuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.kaymuLogo.TabIndex = 0;
            this.kaymuLogo.TabStop = false;
            // 
            // webBrowse
            // 
            this.webBrowse.AllowWebBrowserDrop = false;
            this.webBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowse.IsWebBrowserContextMenuEnabled = false;
            this.webBrowse.Location = new System.Drawing.Point(0, 0);
            this.webBrowse.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowse.Name = "webBrowse";
            this.webBrowse.ScriptErrorsSuppressed = true;
            this.webBrowse.Size = new System.Drawing.Size(486, 393);
            this.webBrowse.TabIndex = 1;
            this.webBrowse.Url = new System.Uri("http://www.kaymu.com.bd/customer/account/login/", System.UriKind.Absolute);
            this.webBrowse.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // AutoListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 393);
            this.Controls.Add(this.webBrowse);
            this.Controls.Add(this.kaymuLogo);
            this.Name = "AutoListing";
            this.Text = "AutoListing";
            ((System.ComponentModel.ISupportInitialize)(this.kaymuLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kaymuLogo;
        private System.Windows.Forms.WebBrowser webBrowse;
    }
}