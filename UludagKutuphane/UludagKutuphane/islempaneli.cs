using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UludagKutuphane
{
    public partial class islempaneli : Form
    {
        public islempaneli()
        {
            InitializeComponent();
        }

        private void islempaneli_Load(object sender, EventArgs e)
        {
            kullanicieklebtn.Visible = false;
            kullaniciguncellebtn.Visible = false;
            kullanicisilbtn.Visible = false;
        }

        private void kullanicilistesibtn_Click(object sender, EventArgs e)
        {
            if (kullanicieklebtn.Visible == false)
            {
                kullanicieklebtn.Visible = true;
                kullaniciguncellebtn.Visible = true;
                kullanicisilbtn.Visible = true;
            }
            else
            {
                kullanicieklebtn.Visible = false;
                kullaniciguncellebtn.Visible = false;
                kullanicisilbtn.Visible = false;
            }
            kullanicilistesi kullanicilistesiform = new kullanicilistesi();
            kullanicilistesiform.MdiParent = this;
            kullanicilistesiform.Show();
        }

        private void kullanicieklebtn_Click(object sender, EventArgs e)
        {
            kullaniciekle kullaniciekleform = new kullaniciekle();
            kullaniciekleform.MdiParent = this;
            kullaniciekleform.Show();
        }

        private void kullanicisilbtn_Click(object sender, EventArgs e)
        {
            kullanicisil kullanicisilform = new kullanicisil();
            kullanicisilform.MdiParent = this;
            kullanicisilform.Show();
        }

        private void kullaniciguncellebtn_Click(object sender, EventArgs e)
        {
            kullaniciguncelle kullaniciguncelleform = new kullaniciguncelle();
            kullaniciguncelleform.MdiParent = this;
            kullaniciguncelleform.Show();
        }
    }
}
