
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
            this.KitapSil_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapSil_dgv.Location = new System.Drawing.Point(17, 125);
            this.KitapSil_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.KitapSil_dgv.Name = "KitapSil_dgv";
            this.KitapSil_dgv.RowHeadersWidth = 51;
            this.KitapSil_dgv.RowTemplate.Height = 24;
            this.KitapSil_dgv.Size = new System.Drawing.Size(706, 364);
            this.KitapSil_dgv.TabIndex = 1;
            // 
            // kitapsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 499);
            this.Controls.Add(this.KitapSil_dgv);
            this.Controls.Add(this.KitapSil_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "kitapsil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitapsil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KitapSil_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KitapSil_btn;
        private System.Windows.Forms.DataGridView KitapSil_dgv;
    }
}