namespace UludagKutuphane
{
    partial class Kaydol
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KullaniciAdi_txt = new System.Windows.Forms.TextBox();
            this.KullaniciSoyadi_txt = new System.Windows.Forms.TextBox();
            this.KullaniciMail_txt = new System.Windows.Forms.TextBox();
            this.KullaniciSifre_txt = new System.Windows.Forms.TextBox();
            this.GirisYap_btn = new System.Windows.Forms.Button();
            this.Okul_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Mail Adresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Soyadı";
            // 
            // KullaniciAdi_txt
            // 
            this.KullaniciAdi_txt.Location = new System.Drawing.Point(200, 39);
            this.KullaniciAdi_txt.Multiline = true;
            this.KullaniciAdi_txt.Name = "KullaniciAdi_txt";
            this.KullaniciAdi_txt.Size = new System.Drawing.Size(230, 32);
            this.KullaniciAdi_txt.TabIndex = 4;
            // 
            // KullaniciSoyadi_txt
            // 
            this.KullaniciSoyadi_txt.Location = new System.Drawing.Point(200, 96);
            this.KullaniciSoyadi_txt.Multiline = true;
            this.KullaniciSoyadi_txt.Name = "KullaniciSoyadi_txt";
            this.KullaniciSoyadi_txt.Size = new System.Drawing.Size(230, 32);
            this.KullaniciSoyadi_txt.TabIndex = 5;
            // 
            // KullaniciMail_txt
            // 
            this.KullaniciMail_txt.Location = new System.Drawing.Point(200, 163);
            this.KullaniciMail_txt.Multiline = true;
            this.KullaniciMail_txt.Name = "KullaniciMail_txt";
            this.KullaniciMail_txt.Size = new System.Drawing.Size(230, 32);
            this.KullaniciMail_txt.TabIndex = 6;
            // 
            // KullaniciSifre_txt
            // 
            this.KullaniciSifre_txt.Location = new System.Drawing.Point(200, 236);
            this.KullaniciSifre_txt.Multiline = true;
            this.KullaniciSifre_txt.Name = "KullaniciSifre_txt";
            this.KullaniciSifre_txt.Size = new System.Drawing.Size(230, 32);
            this.KullaniciSifre_txt.TabIndex = 7;
            // 
            // GirisYap_btn
            // 
            this.GirisYap_btn.Location = new System.Drawing.Point(200, 353);
            this.GirisYap_btn.Name = "GirisYap_btn";
            this.GirisYap_btn.Size = new System.Drawing.Size(230, 40);
            this.GirisYap_btn.TabIndex = 8;
            this.GirisYap_btn.Text = "Kaydol";
            this.GirisYap_btn.UseVisualStyleBackColor = true;
            this.GirisYap_btn.Click += new System.EventHandler(this.GirisYap_btn_Click);
            // 
            // Okul_cmb
            // 
            this.Okul_cmb.FormattingEnabled = true;
            this.Okul_cmb.Items.AddRange(new object[] {
            "Seçiniz",
            "İnegöl Meslek Yüksek Okulu",
            "İnegöl İşletme Fakültesi"});
            this.Okul_cmb.Location = new System.Drawing.Point(200, 300);
            this.Okul_cmb.Name = "Okul_cmb";
            this.Okul_cmb.Size = new System.Drawing.Size(230, 21);
            this.Okul_cmb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Okul";
            // 
            // Kaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Okul_cmb);
            this.Controls.Add(this.GirisYap_btn);
            this.Controls.Add(this.KullaniciSifre_txt);
            this.Controls.Add(this.KullaniciMail_txt);
            this.Controls.Add(this.KullaniciSoyadi_txt);
            this.Controls.Add(this.KullaniciAdi_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kaydol";
            this.Text = "Kaydol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KullaniciAdi_txt;
        private System.Windows.Forms.TextBox KullaniciSoyadi_txt;
        private System.Windows.Forms.TextBox KullaniciMail_txt;
        private System.Windows.Forms.TextBox KullaniciSifre_txt;
        private System.Windows.Forms.Button GirisYap_btn;
        private System.Windows.Forms.ComboBox Okul_cmb;
        private System.Windows.Forms.Label label5;
    }
}