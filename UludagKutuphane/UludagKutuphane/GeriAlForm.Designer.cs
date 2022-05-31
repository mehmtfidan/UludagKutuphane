
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
            this.GeriAl_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GeriAl_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriAl_dgv
            // 
            this.GeriAl_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeriAl_dgv.Location = new System.Drawing.Point(16, 182);
            this.GeriAl_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeriAl_dgv.Name = "GeriAl_dgv";
            this.GeriAl_dgv.RowHeadersWidth = 51;
            this.GeriAl_dgv.Size = new System.Drawing.Size(1141, 399);
            this.GeriAl_dgv.TabIndex = 0;
            // 
            // GeriAl_Btn
            // 
            this.GeriAl_Btn.Location = new System.Drawing.Point(36, 31);
            this.GeriAl_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeriAl_Btn.Name = "GeriAl_Btn";
            this.GeriAl_Btn.Size = new System.Drawing.Size(163, 85);
            this.GeriAl_Btn.TabIndex = 1;
            this.GeriAl_Btn.Text = "Geri Al";
            this.GeriAl_Btn.UseVisualStyleBackColor = true;
            this.GeriAl_Btn.Click += new System.EventHandler(this.GeriAl_Btn_Click);
            // 
            // GeriAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 596);
            this.Controls.Add(this.GeriAl_Btn);
            this.Controls.Add(this.GeriAl_dgv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GeriAlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeriAlForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GeriAlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeriAl_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GeriAl_dgv;
        private System.Windows.Forms.Button GeriAl_Btn;
    }
}