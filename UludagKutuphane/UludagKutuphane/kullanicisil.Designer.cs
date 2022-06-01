
namespace UludagKutuphane
{
    partial class kullanicisil
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
            this.KullaniciSil_dgv = new System.Windows.Forms.DataGridView();
            this.Sil_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciSil_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciSil_dgv
            // 
            this.KullaniciSil_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KullaniciSil_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KullaniciSil_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KullaniciSil_dgv.Location = new System.Drawing.Point(16, 109);
            this.KullaniciSil_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.KullaniciSil_dgv.Name = "KullaniciSil_dgv";
            this.KullaniciSil_dgv.RowHeadersWidth = 51;
            this.KullaniciSil_dgv.RowTemplate.Height = 24;
            this.KullaniciSil_dgv.Size = new System.Drawing.Size(961, 473);
            this.KullaniciSil_dgv.TabIndex = 0;
            // 
            // Sil_btn
            // 
            this.Sil_btn.Location = new System.Drawing.Point(16, 31);
            this.Sil_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Sil_btn.Name = "Sil_btn";
            this.Sil_btn.Size = new System.Drawing.Size(100, 56);
            this.Sil_btn.TabIndex = 1;
            this.Sil_btn.Text = "SİL";
            this.Sil_btn.UseVisualStyleBackColor = true;
            this.Sil_btn.Click += new System.EventHandler(this.Sil_btn_Click);
            // 
            // kullanicisil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 604);
            this.Controls.Add(this.Sil_btn);
            this.Controls.Add(this.KullaniciSil_dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "kullanicisil";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "kullanicisil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciSil_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KullaniciSil_dgv;
        private System.Windows.Forms.Button Sil_btn;
    }
}