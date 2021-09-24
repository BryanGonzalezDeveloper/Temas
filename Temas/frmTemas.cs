using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temas
{
    public partial class frmTemas : Form
    {
        public frmTemas()
        {
            InitializeComponent();
        }

        private void frmTemas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void tick_hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {

        }

        private void btnAzul_Click(object sender, EventArgs e)
        {

        }

        private void BtnRojo_Click(object sender, EventArgs e)
        {

        }

        private void BtnNaranja_Click(object sender, EventArgs e)
        {

        }

        private void btnRosa_Click(object sender, EventArgs e)
        {

        }

        private void BtnGris_Click(object sender, EventArgs e)
        {

        }

        private void btnVerde_Click(object sender, EventArgs e)
        {

        }
    }
}
