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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmProveedores P = new frmProveedores();
            this.Hide();
            P.Show();
        }
    }
}
