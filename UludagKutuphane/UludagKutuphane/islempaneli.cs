using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace UludagKutuphane
{
    public partial class islempaneli : Form
    {
        public islempaneli()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void islempaneli_Load(object sender, EventArgs e)
        {
            //kullanicieklebtn.Visible = false;
            //kullaniciguncellebtn.Visible = false;
            //kullanicisilbtn.Visible = false;

            //kitapeklebtn.Visible = false;
            //kitapguncellebtn.Visible = false;
            //kitapsilbtn.Visible = false;

        }
        private kullanicilistesi kullanicilistesiform;
        private void kullanicilistesibtn_Click(object sender, EventArgs e)
        {
            //if (kullanicieklebtn.Visible == false)
            //{
            //    //kullanicieklebtn.Visible = true;
            //    //kullaniciguncellebtn.Visible = true;
            //    //kullanicisilbtn.Visible = true;
            //    //kullanicilistesiform = new kullanicilistesi();
            //    //kullanicilistesiform.MdiParent = this;
            //    kullanicilistesiform.Show();
            //}
            //else
            //{
                //kullanicieklebtn.Visible = false;
                //kullaniciguncellebtn.Visible = false;
                //kullanicisilbtn.Visible = false;
                kullanicilistesiform = new kullanicilistesi();
                kullanicilistesiform.MdiParent = this;
                kullanicilistesiform.Show();
            //}
          
        }
        private kullaniciekle kullaniciekleform;
        //private bool kullaniciekleDurum;
        private void kullanicieklebtn_Click(object sender, EventArgs e)
        {
           //if (kullaniciekleDurum == false)
           // {
                kullaniciekleform = new kullaniciekle();
                kullaniciekleform.MdiParent = this;
                kullaniciekleform.Show();
                //kullaniciekleDurum = true;
            //}
            //else
            //{
            //    kullaniciekleform.Close();
            //    kullaniciekleDurum = false;
            //}
            
        }

        private kullanicisil kullanicisilform;
        //private bool kullanicisilDurum;

        private void kullanicisilbtn_Click(object sender, EventArgs e)
        {
           //if(kullanicisilDurum ==false)
           // {
                kullanicisilform = new kullanicisil();
                kullanicisilform.MdiParent = this;
                kullanicisilform.Show();
                //kullanicisilDurum = true;
            //}
            //else
            //{
                //kullanicisilform.Close();
                //kullanicisilDurum = false;
            //}
        }
        private kullaniciguncelle kullaniciguncelleform;
        //private bool kullaniciguncelleDurum;
        private void kullaniciguncellebtn_Click(object sender, EventArgs e)
        {
            //if (kullaniciguncelleDurum == false)
            //{
                kullaniciguncelleform = new kullaniciguncelle();
                kullaniciguncelleform.MdiParent = this;
                kullaniciguncelleform.Show();
                //kullaniciguncelleDurum = true;
            //}
            //else
            //{
            //    kullaniciguncelleform.Close();
            //    kullaniciguncelleDurum = false;
            //}
        }
        //private kitaplistesi klisteform;
        private void kitaplistesibtn_Click(object sender, EventArgs e)
        {
            //if (kitapeklebtn.Visible == false)
            //{
            //kitapeklebtn.Visible = true;
            //kitapguncellebtn.Visible = true;
            //kitapsilbtn.Visible = true;
            kitaplistesi klisteform = new kitaplistesi();
                klisteform.MdiParent = this;
                klisteform.Show();
            //}
            //else
            //{
                //kitapeklebtn.Visible = false;
                //kitapguncellebtn.Visible = false;
                //kitapsilbtn.Visible = false;
                //klisteform = new kitaplistesi();
                //klisteform.MdiParent = this;
                //klisteform.Close();
            //}
           
        }
        private kitapekle kekleform;
        private bool kitapekleDurum;
        private void kitapeklebtn_Click(object sender, EventArgs e)
        {
           if(kitapekleDurum == false)
            {
                kekleform = new kitapekle();
                kekleform.MdiParent = this;
                kekleform.Show();
                kitapekleDurum = true;
                
            }
           else
            {
                kekleform.Close();
                kitapekleDurum = false;
            }
        }
        private kitaguncelle kguncelle;
        private bool kitapguncelleDurum;
        private void kitapguncellebtn_Click(object sender, EventArgs e)
        {
            if(kitapguncelleDurum == false)
            {
                kguncelle = new kitaguncelle();
                kguncelle.MdiParent = this;
                kguncelle.Show();
                kitapguncelleDurum = true;
            }
            else
            {
                kguncelle.Close();
                kitapguncelleDurum = false;
            }
        }
        private kitapsil ksil;
        private bool kitapsilDurum;
        private void kitapsilbtn_Click(object sender, EventArgs e)
        {
           if(kitapsilDurum == false)
            {
                ksil = new kitapsil();
                ksil.MdiParent = this;
                ksil.Show();
                kitapsilDurum = true;
            }
           else
            {
                ksil.Close();
                kitapsilDurum = false;
            }
        }

        private OduncForm odunc;
        private bool oduncverDurum;
        private void OduncVer_btn_Click(object sender, EventArgs e)
        {
            if(oduncverDurum == false)
            {
                odunc = new OduncForm();
                odunc.MdiParent = this;
                odunc.Show();
                oduncverDurum = true;
            }
            else
            {
                odunc.Close();
                oduncverDurum = false;
            }
           

        }
        private GeriAlForm geri;
        private bool gerialDurum;
        private void GeriAl_btn_Click(object sender, EventArgs e)
        {
            if(gerialDurum == false)
            {
                geri = new GeriAlForm();
                geri.MdiParent = this;
                geri.Show();
                gerialDurum = true;
            }
            else
            {
                geri.Close();
                gerialDurum = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raporlar raporlarform = new raporlar();
            raporlarform.MdiParent = this;
            raporlarform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayipkitap kkitapform = new kayipkitap();
            kkitapform.MdiParent = this;
            kkitapform.Show();
        }
    }
}
