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
        Temas objTema;
        private void frmTemas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            objTema = new Temas();
            objTema.cambiarColor = cambiarTema;
        }

        private void tick_hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text= DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ColorTema(object sender, EventArgs e)
        {
            objTema.cambiarColorTema(((Button)sender).Text);
           
        }

        void cambiarTema(Color sup,Color lat,Color cont,Color font)
        {
            pnlSuperior.BackColor = sup;
            pnlLateral.BackColor = lat;
            pnlContenedor.BackColor = cont;
            lblFecha.ForeColor = font;
            lbl.ForeColor = font;
            lblHora.ForeColor = font;
        }

    }
}
