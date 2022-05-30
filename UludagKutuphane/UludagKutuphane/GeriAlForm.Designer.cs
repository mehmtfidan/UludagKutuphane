
namespace UludagKutuphane
{
    partial class GeriAlForm
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
            this.GeriAl_dgv = new System.Windows.Forms.DataGridView();
            this.GeriAlBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GeriAlFiltre_txt = new System.Windows.Forms.TextBox();
            this.GeriAlFiltreBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GeriAl_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriAl_dgv
            // 
            this.GeriAl_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeriAl_dgv.Location = new System.Drawing.Point(12, 148);
            this.GeriAl_dgv.Name = "GeriAl_dgv";
            this.GeriAl_dgv.Size = new System.Drawing.Size(856, 324);
            this.GeriAl_dgv.TabIndex = 0;
            // 
            // GeriAlBtn
            // 
            this.GeriAlBtn.Location = new System.Drawing.Point(27, 25);
            this.GeriAlBtn.Name = "GeriAlBtn";
            this.GeriAlBtn.Size = new System.Drawing.Size(122, 69);
            this.GeriAlBtn.TabIndex = 1;
            this.GeriAlBtn.Text = "Geri Al";
            this.GeriAlBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seçiniz..",
            "Adı",
            "Yazar Adı",
            "Demirbaş Numarası",
            "Çevirmen"});
            this.comboBox1.Location = new System.Drawing.Point(355, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // GeriAlFiltre_txt
            // 
            this.GeriAlFiltre_txt.Location = new System.Drawing.Point(516, 26);
            this.GeriAlFiltre_txt.Name = "GeriAlFiltre_txt";
            this.GeriAlFiltre_txt.Size = new System.Drawing.Size(100, 20);
            this.GeriAlFiltre_txt.TabIndex = 3;
            this.GeriAlFiltre_txt.TextChanged += new System.EventHandler(this.GeriAlFiltre_txt_TextChanged);
            // 
            // GeriAlFiltreBtn
            // 
            this.GeriAlFiltreBtn.Location = new System.Drawing.Point(650, 23);
            this.GeriAlFiltreBtn.Name = "GeriAlFiltreBtn";
            this.GeriAlFiltreBtn.Size = new System.Drawing.Size(75, 23);
            this.GeriAlFiltreBtn.TabIndex = 4;
            this.GeriAlFiltreBtn.Text = "Temizle";
            this.GeriAlFiltreBtn.UseVisualStyleBackColor = true;
            // 
            // GeriAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 484);
            this.Controls.Add(this.GeriAlFiltreBtn);
            this.Controls.Add(this.GeriAlFiltre_txt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GeriAlBtn);
            this.Controls.Add(this.GeriAl_dgv);
            this.Name = "GeriAlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeriAlForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GeriAl_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GeriAl_dgv;
        private System.Windows.Forms.Button GeriAlBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox GeriAlFiltre_txt;
        private System.Windows.Forms.Button GeriAlFiltreBtn;
    }
}