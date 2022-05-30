
namespace UludagKutuphane
{
    partial class kitaplistesi
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
            this.KitapListesi_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KitapListesi_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // KitapListesi_dgv
            // 
            this.KitapListesi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapListesi_dgv.Location = new System.Drawing.Point(1, 51);
            this.KitapListesi_dgv.Name = "KitapListesi_dgv";
            this.KitapListesi_dgv.RowHeadersWidth = 51;
            this.KitapListesi_dgv.RowTemplate.Height = 24;
            this.KitapListesi_dgv.Size = new System.Drawing.Size(969, 498);
            this.KitapListesi_dgv.TabIndex = 0;
            // 
            // kitaplistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(969, 547);
            this.Controls.Add(this.KitapListesi_dgv);
            this.Name = "kitaplistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitaplistesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.kitaplistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KitapListesi_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KitapListesi_dgv;
    }
}