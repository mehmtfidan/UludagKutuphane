﻿
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KitapSil_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // KitapSil_btn
            // 
            this.KitapSil_btn.Location = new System.Drawing.Point(59, 46);
            this.KitapSil_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KitapSil_btn.Name = "KitapSil_btn";
            this.KitapSil_btn.Size = new System.Drawing.Size(140, 63);
            this.KitapSil_btn.TabIndex = 0;
            this.KitapSil_btn.Text = "SİL";
            this.KitapSil_btn.UseVisualStyleBackColor = true;
            this.KitapSil_btn.Click += new System.EventHandler(this.KitapSil_btn_Click);
            // 
            // KitapSil_dgv
            // 
            this.KitapSil_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapSil_dgv.Location = new System.Drawing.Point(23, 154);
            this.KitapSil_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KitapSil_dgv.Name = "KitapSil_dgv";
            this.KitapSil_dgv.RowHeadersWidth = 51;
            this.KitapSil_dgv.RowTemplate.Height = 24;
            this.KitapSil_dgv.Size = new System.Drawing.Size(941, 448);
            this.KitapSil_dgv.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // kitapsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.KitapSil_dgv);
            this.Controls.Add(this.KitapSil_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "kitapsil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button1;
    }
}