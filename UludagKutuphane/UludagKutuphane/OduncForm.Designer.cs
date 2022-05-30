
namespace UludagKutuphane
{
    partial class OduncForm
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
            this.Ara_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.UyeNo_txt = new System.Windows.Forms.TextBox();
            this.BulBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Filtrele_dgv = new System.Windows.Forms.DataGridView();
            this.Ara_txt = new System.Windows.Forms.TextBox();
            this.OduncVerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ara_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filtrele_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Ara_dgv
            // 
            this.Ara_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ara_dgv.Location = new System.Drawing.Point(12, 248);
            this.Ara_dgv.Name = "Ara_dgv";
            this.Ara_dgv.Size = new System.Drawing.Size(903, 197);
            this.Ara_dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üye No:";
            // 
            // UyeNo_txt
            // 
            this.UyeNo_txt.Location = new System.Drawing.Point(74, 31);
            this.UyeNo_txt.Name = "UyeNo_txt";
            this.UyeNo_txt.Size = new System.Drawing.Size(147, 20);
            this.UyeNo_txt.TabIndex = 2;
            // 
            // BulBtn
            // 
            this.BulBtn.Location = new System.Drawing.Point(248, 24);
            this.BulBtn.Name = "BulBtn";
            this.BulBtn.Size = new System.Drawing.Size(75, 33);
            this.BulBtn.TabIndex = 3;
            this.BulBtn.Text = "Bul";
            this.BulBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // Filtrele_dgv
            // 
            this.Filtrele_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Filtrele_dgv.Location = new System.Drawing.Point(392, 60);
            this.Filtrele_dgv.Name = "Filtrele_dgv";
            this.Filtrele_dgv.Size = new System.Drawing.Size(523, 169);
            this.Filtrele_dgv.TabIndex = 5;
            // 
            // Ara_txt
            // 
            this.Ara_txt.Location = new System.Drawing.Point(478, 24);
            this.Ara_txt.Name = "Ara_txt";
            this.Ara_txt.Size = new System.Drawing.Size(149, 20);
            this.Ara_txt.TabIndex = 6;
            // 
            // OduncVerBtn
            // 
            this.OduncVerBtn.Location = new System.Drawing.Point(134, 118);
            this.OduncVerBtn.Name = "OduncVerBtn";
            this.OduncVerBtn.Size = new System.Drawing.Size(122, 59);
            this.OduncVerBtn.TabIndex = 7;
            this.OduncVerBtn.Text = "Ödünç Ver";
            this.OduncVerBtn.UseVisualStyleBackColor = true;
            // 
            // OduncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 457);
            this.Controls.Add(this.OduncVerBtn);
            this.Controls.Add(this.Ara_txt);
            this.Controls.Add(this.Filtrele_dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BulBtn);
            this.Controls.Add(this.UyeNo_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ara_dgv);
            this.Name = "OduncForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OduncForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OduncForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ara_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filtrele_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Ara_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UyeNo_txt;
        private System.Windows.Forms.Button BulBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Filtrele_dgv;
        private System.Windows.Forms.TextBox Ara_txt;
        private System.Windows.Forms.Button OduncVerBtn;
    }
}