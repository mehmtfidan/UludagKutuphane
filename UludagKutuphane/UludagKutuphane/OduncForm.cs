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
    public partial class OduncForm : Form
    {
        public OduncForm()
        {
            InitializeComponent();
        }

        

        private void OduncForm_Load(object sender, EventArgs e)
        {


            Ara_dgv.Columns[6].Visible = false;
            Ara_dgv.Columns[7].Visible = false;

        }
    }
}
