using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace UludagKutuphane
{
    public partial class OduncForm : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        int KisiId;
        string alis;

        public OduncForm()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        public int VarMi(string sorgu)
        {
            int sonuc;
            con.Open();
            cmd = new MySqlCommand(sorgu, con);
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc;
        }

        private void OduncForm_Load(object sender, EventArgs e)
        {
            UyeAdi_lbl.Visible = false;
            con.Open();
            string Komut = "Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            Filtrele_dgv.DataSource = dt;
            con.Close();

            //MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No, Kitap.Kayit_Tarihi From Kitap Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Kitap Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Uye On Odunc.Uye_Id = Uye.Id WHERE Teslim_Durumu = '1'", con);
            //DataTable dt1 = new DataTable();
            //ShowinDgv.Fill(dt1);
            //Odunc_dgv.DataSource = dt1;
        }

        private void Ara_txt_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable tbl = new DataTable();
            MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id where Ki_Adi like '%" + Ara_txt.Text + "%' ", con);
            ara.Fill(tbl);
            con.Close();
            Filtrele_dgv.DataSource = tbl;
        }

        private void OduncVerBtn_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(Filtrele_dgv.CurrentRow.Cells[0].Value);

            con.Open();
            MySqlCommand query = new MySqlCommand("SELECT Durum_Id FROM Kitap WHERE Id = '"+ SecilenId +"'", con);
            int Durum = Convert.ToInt32(query.ExecuteScalar());
            con.Close();

            if (Durum == 1)
            {
                DateTime Alis = new DateTime();
                Alis = DateTime.Today;
                alis = Convert.ToString(Alis);
                DateTime Teslim = new DateTime();
                Teslim = Alis.AddDays(15);
                DateTime dtn = new DateTime();
                dtn = DateTime.Today;

                string deger = "";

                if (Teslim.DayOfWeek == DayOfWeek.Saturday)
                {
                    Teslim.AddDays(2);
                    String teslim = Convert.ToString(Teslim);
                    con.Open();
                    MySqlCommand Insert1 = new MySqlCommand("INSERT INTO Odunc (Uye_Id, Kitap_Id, Alis_Tarihi, Son_Teslim_Tarihi, Teslim_Ettigi_Tarih) VALUES ('" + KisiId + "', '" + SecilenId + "', '" + alis + "', '" + teslim + "','"+ "" +"'", con);
                    Insert1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kitap emanet edildi.");
                }
                else if (Teslim.DayOfWeek == DayOfWeek.Sunday)
                {
                    Teslim.AddDays(1);
                    String teslim = Convert.ToString(Teslim);
                    con.Open();
                    MySqlCommand Insert2 = new MySqlCommand("INSERT INTO Odunc (Uye_Id, Kitap_Id, Alis_Tarihi, Son_Teslim_Tarihi, Teslim_Ettigi_Tarih) VALUES ('" + KisiId + "', '" + SecilenId + "', '" + alis + "', '" + teslim + "', '" + "" +"'", con);
                    Insert2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kitap emanet edildi.");
                }
                else
                {
                    con.Open();
                    MySqlCommand Insert3 = new MySqlCommand("INSERT INTO Odunc (Uye_Id, Kitap_Id, Alis_Tarihi, Son_Teslim_Tarihi, Teslim_Ettigi_Tarih, Teslim_Durumu) VALUES (" + KisiId + ", " + SecilenId + ", '" + alis + "', '" + Teslim + "', '"+ deger +"', "+ 1+")", con);
                    Insert3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kitap emanet edildi.");
                }

                con.Open();

                MySqlCommand update = new MySqlCommand("UPDATE Kitap SET Durum_Id = '" + 2 + "' WHERE Id = '" + SecilenId + "'", con);
                update.ExecuteNonQuery();

                MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("Select Odunc.Alis_Tarihi, Odunc.Son_Teslim_Tarihi, Odunc.Uye_Id, Odunc.Kitap_Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Kitap.Durum_Id, Durum.D_Adi, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta From Odunc Inner Join Kitap On Odunc.Kitap_Id = Kitap.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Uye On Odunc.Uye_Id = Uye.Id WHERE Durum.Id = '2'", con);
                DataTable dt = new DataTable();
                ShowinDgv.Fill(dt);
                Odunc_dgv.DataSource = dt;

                con.Close();
            }
            else if (Durum == 2)
            {
                MessageBox.Show("Kitap başka bir üyede emanette.");
            }
            else if (Durum == 3)
            {
                MessageBox.Show("Kitap kayıp olduğundan dolayı emanet edilemez!!");
            }           
        }

        private void UyeNo_txt_TextChanged(object sender, EventArgs e)
        {
            string SecilenKisi = UyeNo_txt.Text;

            if (VarMi("SELECT COUNT(*) From Uye WHERE Uye_Numarasi = '" + SecilenKisi + "'") == 0)
            {
                //MessageBox.Show("Bu numara ile kayıtlı üye yoktur!!");
            }
            else
            {
                con.Open();
                MySqlCommand Komut = new MySqlCommand("SELECT Adi FROM Uye WHERE Uye_Numarasi = '" + SecilenKisi + "'", con);
                string Adi = Convert.ToString(Komut.ExecuteScalar());
                MySqlCommand Komut1 = new MySqlCommand("SELECT Soyadi FROM Uye WHERE Uye_Numarasi = '" + SecilenKisi + "'", con);
                string Soyadi = Convert.ToString(Komut1.ExecuteScalar());
                MySqlCommand Komut2 = new MySqlCommand("SELECT Id FROM Uye WHERE Uye_Numarasi = '" + SecilenKisi + "'", con);
                KisiId = Convert.ToInt32(Komut2.ExecuteScalar());
                UyeAdi_lbl.Visible = true;
                UyeAdi_lbl.Text = Adi + " " + Soyadi;
            }
            con.Close();
        }
    }
}
