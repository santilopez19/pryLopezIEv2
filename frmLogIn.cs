using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezIE
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnInisiarSesion_Click(object sender, EventArgs e)
        {
            frmMenu M = new frmMenu();
            this.Hide();
            M.Show();
        }
    }
}
