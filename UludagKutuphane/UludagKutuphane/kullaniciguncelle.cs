using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace UludagKutuphane
{
    public partial class kullaniciguncelle : Form
    {
        MySqlConnection con;

        public kullaniciguncelle()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Uye.Id, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Bolum.Adi As Adi1 From Bolum Inner Join Uye On Uye.Bolum_Id = Bolum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KullaniciGuncelle_dgv.DataSource = dt;
            con.Close();


            con.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM Bolum", con);
            MySqlDataReader dr;
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                Bolum_cmb.Items.Add(dr["Adi"]);
            }
            con.Close();
        }

        public void KullaniciGuncelle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            KullaniciAdi_txt.Text = KullaniciGuncelle_dgv.CurrentRow.Cells[1].Value.ToString();
            KullaniciSoyadi_txt.Text = KullaniciGuncelle_dgv.CurrentRow.Cells[2].Value.ToString();
            KullaniciUyeNumara_txt.Text = KullaniciGuncelle_dgv.CurrentRow.Cells[3].Value.ToString();
            KullaniciTelNo_txt.Text = KullaniciGuncelle_dgv.CurrentRow.Cells[4].Value.ToString();
            KullaniciMail_txt.Text = KullaniciGuncelle_dgv.CurrentRow.Cells[5].Value.ToString();
            Bolum_cmb.Text = KullaniciGuncelle_dgv.CurrentRow.Cells[6].Value.ToString();
            int Bolum = Bolum_cmb.SelectedIndex;            
        }

        private void Guncelle_txt_Click(object sender, EventArgs e)
        {
            int Bolum = Bolum_cmb.SelectedIndex;
            int SecilenId = Convert.ToInt32(KullaniciGuncelle_dgv.CurrentRow.Cells[0].Value);

            if (KullaniciAdi_txt.Text == "" || KullaniciSoyadi_txt.Text == "" || KullaniciUyeNumara_txt.Text == "" || KullaniciTelNo_txt.Text == "" || KullaniciMail_txt.Text == "" || KullaniciMail_txt.Text == "" || Bolum_cmb.SelectedIndex == 0)
            {
                System.Windows.Forms.MessageBox.Show("Bilgileri eksiksiz giriniz!!");
            }
            else
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Confirmation", (MessageBoxButtons)MessageBoxButton.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    string guncelleme = "UPDATE Uye SET Adi = '" + KullaniciAdi_txt.Text + "', Soyadi = '" + KullaniciSoyadi_txt.Text + "', Uye_Numarasi = '" + KullaniciUyeNumara_txt.Text + "', Telefon_No = '" + KullaniciTelNo_txt.Text + "', E_Posta = '" + KullaniciMail_txt.Text + "', Bolum_Id = '" + Bolum + "' WHERE Id = '" + SecilenId + "'";
                    MySqlCommand Komut = new MySqlCommand(guncelleme, con);
                    Komut.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");
                }                
            }
            string Komut1 = "Select Uye.Id, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Bolum.Adi As Adi1 From Bolum Inner Join Uye On Uye.Bolum_Id = Bolum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut1, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KullaniciGuncelle_dgv.DataSource = dt;
            con.Close();
        }       
    }
}
