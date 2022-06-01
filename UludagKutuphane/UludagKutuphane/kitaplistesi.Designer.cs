
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KitapListesi_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // KitapListesi_dgv
            // 
            this.KitapListesi_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KitapListesi_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KitapListesi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapListesi_dgv.Location = new System.Drawing.Point(11, 96);
            this.KitapListesi_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KitapListesi_dgv.Name = "KitapListesi_dgv";
            this.KitapListesi_dgv.RowHeadersWidth = 51;
            this.KitapListesi_dgv.RowTemplate.Height = 24;
            this.KitapListesi_dgv.Size = new System.Drawing.Size(1005, 554);
            this.KitapListesi_dgv.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seçiniz..",
            "Adı",
            "Yazar Adı",
            "Demirbaş Numarası",
            "Çevirmen Adı",
            "Yayınevi"});
            this.comboBox1.Location = new System.Drawing.Point(239, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(403, 40);
            this.NameTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(123, 20);
            this.NameTb.TabIndex = 2;
            this.NameTb.TextChanged += new System.EventHandler(this.NameTb_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitaplistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1027, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.KitapListesi_dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "kitaplistesi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "kitaplistesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.kitaplistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KitapListesi_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView KitapListesi_dgv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Button button1;
    }
}