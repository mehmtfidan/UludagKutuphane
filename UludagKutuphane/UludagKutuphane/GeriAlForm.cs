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
    public partial class GeriAlForm : Form
    {
        public GeriAlForm()
        {
            InitializeComponent();
        }

        private void GeriAlFiltre_txt_TextChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedItem == 1)
            //{
            //    con open();
            //    DataTable tbl = new DataTable();

            //    MySqlDataAdapter ara = new MySqlDataAdapter("select * from Kitap Ki_Adi like '%" + NameTb.Text + "%" , con)
            //}
        }
    }
}
