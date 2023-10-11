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
    public partial class frmCargar : Form
    {
        public frmCargar()
        {
            InitializeComponent();
        }

        private void frmCargar_Load(object sender, EventArgs e)
        {

        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            //Carga el progressbar y oculta este formulario y muestra el de login
            prbCarga.Increment(5);
            if (prbCarga.Value < 100)
            {
                prbCarga.Value++;
            }
            if (prbCarga.Value == 100)
            {
                timerCarga.Enabled = false;
                frmLogIn L = new frmLogIn();
                this.Hide();
                L.Show();
            }
        }
    }
}
