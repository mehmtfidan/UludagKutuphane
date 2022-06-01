
namespace UludagKutuphane
{
    partial class kitapsil
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
            this.KitapSil_btn = new System.Windows.Forms.Button();
            this.KitapSil_dgv = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KitapFiltre_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KitapSil_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // KitapSil_btn
            // 
            this.KitapSil_btn.Location = new System.Drawing.Point(44, 37);
            this.KitapSil_btn.Margin = new System.Windows.Forms.Padding(2);
            this.KitapSil_btn.Name = "KitapSil_btn";
            this.KitapSil_btn.Size = new System.Drawing.Size(105, 51);
            this.KitapSil_btn.TabIndex = 0;
            this.KitapSil_btn.Text = "SİL";
            this.KitapSil_btn.UseVisualStyleBackColor = true;
            this.KitapSil_btn.Click += new System.EventHandler(this.KitapSil_btn_Click);
            // 
            // KitapSil_dgv
            // 
            this.KitapSil_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KitapSil_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KitapSil_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapSil_dgv.Location = new System.Drawing.Point(11, 118);
            this.KitapSil_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.KitapSil_dgv.Name = "KitapSil_dgv";
            this.KitapSil_dgv.RowHeadersWidth = 51;
            this.KitapSil_dgv.RowTemplate.Height = 24;
            this.KitapSil_dgv.Size = new System.Drawing.Size(964, 508);
            this.KitapSil_dgv.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seçiniz",
            "Kitap Adı",
            "Yazar Adı",
            "Demirbaş No",
            "Çevirmen Adı",
            "Yayınevi"});
            this.comboBox1.Location = new System.Drawing.Point(433, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(597, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KitapFiltre_Btn
            // 
            this.KitapFiltre_Btn.Location = new System.Drawing.Point(759, 53);
            this.KitapFiltre_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.KitapFiltre_Btn.Name = "KitapFiltre_Btn";
            this.KitapFiltre_Btn.Size = new System.Drawing.Size(72, 20);
            this.KitapFiltre_Btn.TabIndex = 4;
            this.KitapFiltre_Btn.Text = "Temizle";
            this.KitapFiltre_Btn.UseVisualStyleBackColor = true;
            this.KitapFiltre_Btn.Click += new System.EventHandler(this.KitapFiltre_Btn_Click);
            // 
            // kitapsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 649);
            this.Controls.Add(this.KitapFiltre_Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.KitapSil_dgv);
            this.Controls.Add(this.KitapSil_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "kitapsil";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "kitapsil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KitapSil_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KitapSil_btn;
        private System.Windows.Forms.DataGridView KitapSil_dgv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button KitapFiltre_Btn;
    }
}