
namespace UludagKutuphane
{
    partial class kayipkitap
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
            this.Kayip_dgv = new System.Windows.Forms.DataGridView();
            this.durumdegis_Cmb = new System.Windows.Forms.ComboBox();
            this.durumdegis_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kayip_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Kayip_dgv
            // 
            this.Kayip_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Kayip_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Kayip_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kayip_dgv.Location = new System.Drawing.Point(11, 151);
            this.Kayip_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.Kayip_dgv.Name = "Kayip_dgv";
            this.Kayip_dgv.RowHeadersWidth = 51;
            this.Kayip_dgv.RowTemplate.Height = 24;
            this.Kayip_dgv.Size = new System.Drawing.Size(1070, 438);
            this.Kayip_dgv.TabIndex = 0;
            // 
            // durumdegis_Cmb
            // 
            this.durumdegis_Cmb.FormattingEnabled = true;
            this.durumdegis_Cmb.Items.AddRange(new object[] {
            "Seçiniz..",
            "Rafta"});
            this.durumdegis_Cmb.Location = new System.Drawing.Point(71, 87);
            this.durumdegis_Cmb.Margin = new System.Windows.Forms.Padding(2);
            this.durumdegis_Cmb.Name = "durumdegis_Cmb";
            this.durumdegis_Cmb.Size = new System.Drawing.Size(147, 21);
            this.durumdegis_Cmb.TabIndex = 9;
            // 
            // durumdegis_Btn
            // 
            this.durumdegis_Btn.Location = new System.Drawing.Point(280, 77);
            this.durumdegis_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.durumdegis_Btn.Name = "durumdegis_Btn";
            this.durumdegis_Btn.Size = new System.Drawing.Size(119, 37);
            this.durumdegis_Btn.TabIndex = 10;
            this.durumdegis_Btn.Text = "Durum Değiştir";
            this.durumdegis_Btn.UseVisualStyleBackColor = true;
            this.durumdegis_Btn.Click += new System.EventHandler(this.durumdegis_Btn_Click);
            // 
            // kayipkitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 600);
            this.Controls.Add(this.durumdegis_Btn);
            this.Controls.Add(this.durumdegis_Cmb);
            this.Controls.Add(this.Kayip_dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "kayipkitap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "kayipkitap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kayip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kayip_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Kayip_dgv;
        private System.Windows.Forms.ComboBox durumdegis_Cmb;
        private System.Windows.Forms.Button durumdegis_Btn;
    }
}