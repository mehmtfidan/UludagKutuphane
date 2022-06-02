
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Name_Tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GeriAl_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriAl_dgv
            // 
            this.GeriAl_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeriAl_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GeriAl_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.GeriAl_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeriAl_dgv.Location = new System.Drawing.Point(16, 148);
            this.GeriAl_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeriAl_dgv.Name = "GeriAl_dgv";
            this.GeriAl_dgv.RowHeadersWidth = 51;
            this.GeriAl_dgv.Size = new System.Drawing.Size(1433, 634);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seçiniz..",
            "Adı",
            "Kitap Adı",
            "Demirbaş Numarası"});
            this.comboBox1.Location = new System.Drawing.Point(495, 62);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // Name_Tb
            // 
            this.Name_Tb.Location = new System.Drawing.Point(691, 62);
            this.Name_Tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_Tb.Name = "Name_Tb";
            this.Name_Tb.Size = new System.Drawing.Size(180, 22);
            this.Name_Tb.TabIndex = 3;
            this.Name_Tb.TextChanged += new System.EventHandler(this.Name_Tb_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(909, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeriAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 796);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Name_Tb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GeriAl_Btn);
            this.Controls.Add(this.GeriAl_dgv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GeriAlForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GeriAlForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GeriAlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeriAl_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GeriAl_dgv;
        private System.Windows.Forms.Button GeriAl_Btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Name_Tb;
        private System.Windows.Forms.Button button1;
    }
}