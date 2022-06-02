using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UludagKutuphane
{
    public partial class kitaguncelle : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlCommand cmd1;
        int YazarId;
        int YayineviId;
        int CevirmenId;
        int BaskiId;

        public kitaguncelle()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void KitapGuncelle_Load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KitapGuncelle_dgv.DataSource = dt;
            con.Close();

            DateTime dtn = new DateTime();
            dtn = DateTime.Now;
            Kayit_Trihi_txt.Text = Convert.ToString(dtn);
        }

        private void KitapGuncelle_CellCenter(object sender, DataGridViewCellEventArgs e)
        {
            KitapAdi_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[1].Value.ToString();
            DemirbasNo_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[2].Value.ToString();
            YazarAdi_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[3].Value.ToString();
            YazarSoyadi_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[4].Value.ToString();
            BaskiNo_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[5].Value.ToString();
            Yayinevi_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[6].Value.ToString();
            CevirmenAdi_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[7].Value.ToString();
            CevirmenSoyadi_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[8].Value.ToString();
            ISBN_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[9].Value.ToString();
            YayimYili_txt.Text = KitapGuncelle_dgv.CurrentRow.Cells[10].Value.ToString();
            Durum_cmb.Text = KitapGuncelle_dgv.CurrentRow.Cells[11].Value.ToString();
            Kategori_cmb.Text = KitapGuncelle_dgv.CurrentRow.Cells[12].Value.ToString();
            Kitaaplik_cmb.Text = KitapGuncelle_dgv.CurrentRow.Cells[13].Value.ToString();
            Raf_cmb.Text = KitapGuncelle_dgv.CurrentRow.Cells[14].Value.ToString();
 
        }

        public int VarMi(string sorgu)
        {
            int sonuc;
            if(con.State != ConnectionState.Open)
                con.Open();
            cmd = new MySqlCommand(sorgu, con);
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc;
        }

        private void KitapGüncelle_Btn_Click(object sender, EventArgs e)
        {
            string KitapAdi = KitapAdi_txt.Text;
            string YazarAdi = YazarAdi_txt.Text;
            string YazarSoyadi = YazarSoyadi_txt.Text;
            string Cevirmen_Adi = CevirmenAdi_txt.Text;
            string Cevirmen_Soyadi = CevirmenSoyadi_txt.Text;
            string Yayinevi = Yayinevi_txt.Text;
            string Kayit_Tarihi = Kayit_Trihi_txt.Text;
            string Baski = BaskiNo_txt.Text;
            string YayimYili = YayimYili_txt.Text;
            string Demirbas = DemirbasNo_txt.Text;
            string ISBN = ISBN_txt.Text;
            int Kategori = Kategori_cmb.SelectedIndex;
            int Durum = Durum_cmb.SelectedIndex;
            int Kitaplik = Kitaaplik_cmb.SelectedIndex;
            int Raf = Raf_cmb.SelectedIndex;

            if (VarMi("SELECT COUNT(*) From Cevirmen WHERE C_Adi='" + Cevirmen_Adi + "'") == 0 && VarMi("Select COUNT(*) from Cevirmen WHERE C_Soyadi='" + Cevirmen_Soyadi + "'") == 0)
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Cevirmen (C_Adi, C_Soyadi) VALUES ('" + Cevirmen_Adi + "', '" + Cevirmen_Soyadi + "')", con);
                cmd.ExecuteNonQuery();
                cmd1 = new MySqlCommand("Select LAST_INSERT_ID()", con);
                CevirmenId = Convert.ToInt32(cmd1.ExecuteScalar());
                con.Close();
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand("Select Id from Cevirmen where C_Adi like '%" + Cevirmen_Adi + "%' AND C_Soyadi like '%" + Cevirmen_Soyadi + "%'", con);
                CevirmenId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }

            if (VarMi("Select COUNT('') from Yayinevi WHERE Yayin_Adi='" + Yayinevi + "'") == 0)
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Yayinevi (Yayin_Adi) VALUES ('" + Yayinevi + "')", con);
                cmd.ExecuteNonQuery();
                cmd1 = new MySqlCommand("Select LAST_INSERT_ID()", con);
                YayineviId = Convert.ToInt32(cmd1.ExecuteScalar());
                con.Close();
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand("Select Id from Yayinevi WHERE Yayin_Adi like '%" + Yayinevi + "%'", con);
                YayineviId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }

            if (VarMi("Select COUNT('') from Yazar WHERE Y_Adi='" + YazarAdi + "'") == 0 || VarMi("Select COUNT('') from Yazar WHERE Y_Soyadi='" + YazarSoyadi + "'") == 0)
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Yazar (Y_Adi, Y_Soyadi) VALUES ('" + YazarAdi + "', '" + YazarSoyadi + "')", con);
                cmd.ExecuteNonQuery();
                cmd1 = new MySqlCommand("Select LAST_INSERT_ID()", con);
                YazarId = Convert.ToInt32(cmd1.ExecuteScalar());
                con.Close();
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand("Select Id from Yazar where Y_Adi like '%" + YazarAdi + "%' AND Y_Soyadi like '%" + YazarSoyadi + "%'", con);
                YazarId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }

            con.Open();
            int SecilenId = Convert.ToInt32(KitapGuncelle_dgv.CurrentRow.Cells[0].Value);

            MySqlCommand Komut = new MySqlCommand("Select Baski_Id from Kitap where Id like '%" + SecilenId + "%'", con);
            BaskiId = Convert.ToInt32(Komut.ExecuteScalar());
            
            cmd = new MySqlCommand("UPDATE Baski SET Baski_Sayisi = '" + Baski + "', Yayinevi_Id = '" + YayineviId + "', Cevirmen_Id = '" + CevirmenId + "' WHERE Id = '" + BaskiId +"'", con);
            cmd.ExecuteNonQuery();

            string guncelleme = "UPDATE Kitap SET Ki_Adi = '" + KitapAdi + "', Demirbas_No = '" + Demirbas + "', Yazar_Id = '" + YazarId + "', Baski_Id = '" + BaskiId + "', ISBN = '" + ISBN + "', Yayim_Yili = '" + YayimYili + "', Kategori_Id = '"+ Kategori +"', Durum_Id = '"+ Durum +"', Kitaplik_Id = '"+ Kitaplik +"', Raf_Id = '"+ Raf +"', Kayit_Tarihi = '"+ Kayit_Tarihi +"' WHERE Id = '" + SecilenId + "'";
            MySqlCommand Komut1 = new MySqlCommand(guncelleme, con);
            Komut1.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");

            
            string Komut2 = "Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut2, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KitapGuncelle_dgv.DataSource = dt;
            con.Close();
        }

        private void KitapGFiltre_txt_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex== 1)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Ki_Adi, Kitap.Demirbas_No, Kitap.ISBN, Kitap.Yayim_Yili, Kitap.Kayit_Tarihi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Yazar.Y_Adi, Yazar.Y_Soyadi, Durum.D_Adi, Kitaplik.Kitaplik_Adi, Kategori.K_Adi, Yayinevi.Yayin_Adi, Raf.Raf_No From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = `132030020`.Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id where Ki_Adi like '%" + KitapGFiltre_txt.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapGuncelle_dgv.DataSource = tbl;           
            
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_Id, Kitap.Raf_Id, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id where Y_Adi like '%" + KitapGFiltre_txt.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapGuncelle_dgv.DataSource = tbl;

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_Id, Kitap.Raf_Id, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id where Demirbas_No like '%" + KitapGFiltre_txt.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapGuncelle_dgv.DataSource = tbl;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_Id, Kitap.Raf_Id, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id where C_Adi like '%" + KitapGFiltre_txt.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapGuncelle_dgv.DataSource = tbl;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_Id, Kitap.Raf_Id, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id where Yayin_Adi like '%" + KitapGFiltre_txt.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapGuncelle_dgv.DataSource = tbl;
            }
        }

        private void KitapGFiltreBtn_Click(object sender, EventArgs e)
        {
            KitapGFiltre_txt.Text = "";
        }
    }
}
