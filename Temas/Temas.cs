using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temas
{
    class Temas
    {
        public delegate void colorTema(Color panelSuperior, Color panelLateral, Color panelContenedor,Color font);
        public colorTema cambiarColor;
        public void cambiarColorTema(string tema)
        {
            switch (tema)
            {
                case "Default":
                    cambiarColor(Color.FromArgb(74, 29, 122), Color.FromArgb(121, 48, 199), Color.FromArgb(93, 66, 122), Color.FromArgb(191, 135, 251));
                    break;
                case "Azul":
                    cambiarColor(Color.FromArgb(28, 37, 87), Color.FromArgb(52, 80, 240), Color.FromArgb(54, 59, 87), Color.FromArgb(101, 110, 163));
                    break;
                case "Rojo":
                    cambiarColor(Color.FromArgb(250, 66, 57), Color.FromArgb(199, 53, 46), Color.FromArgb(122, 33, 28), Color.FromArgb(251, 139, 133));
                    break;
                case "Naranja":
                    cambiarColor(Color.FromArgb(250, 154, 21), Color.FromArgb(199, 123, 16), Color.FromArgb(122, 75, 10), Color.FromArgb(251, 186, 95));
                    break;
                case "Rosa":
                    cambiarColor(Color.FromArgb(250, 34, 213), Color.FromArgb(199, 28, 170), Color.FromArgb(122, 17, 105), Color.FromArgb(251, 110, 227));
                    break;
                case "Gris":
                    cambiarColor(Color.FromArgb(107, 105, 122), Color.FromArgb(153, 140, 251), Color.FromArgb(75, 69, 122), Color.FromArgb(174, 171, 199));
                    break;
                case "Verde":
                    cambiarColor(Color.FromArgb(42, 245, 39), Color.FromArgb(34, 194, 31), Color.FromArgb(20, 117, 19), Color.FromArgb(116, 247, 113));
                    break;
            }
        }
    }
}
