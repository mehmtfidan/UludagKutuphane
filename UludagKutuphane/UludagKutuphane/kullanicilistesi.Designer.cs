
namespace UludagKutuphane
{
    partial class kullanicilistesi
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
            this.KullaniciListesi_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciListesi_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciListesi_dgv
            // 
            this.KullaniciListesi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KullaniciListesi_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KullaniciListesi_dgv.Location = new System.Drawing.Point(0, 0);
            this.KullaniciListesi_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.KullaniciListesi_dgv.MultiSelect = false;
            this.KullaniciListesi_dgv.Name = "KullaniciListesi_dgv";
            this.KullaniciListesi_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.KullaniciListesi_dgv.RowTemplate.Height = 24;
            this.KullaniciListesi_dgv.Size = new System.Drawing.Size(621, 401);
            this.KullaniciListesi_dgv.TabIndex = 0;
            // 
            // kullanicilistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(621, 401);
            this.Controls.Add(this.KullaniciListesi_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "kullanicilistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "kullanicilistesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciListele_load);
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciListesi_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KullaniciListesi_dgv;
    }
}