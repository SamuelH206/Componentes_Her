using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes_Her
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Reproductor_Click(object sender, EventArgs e)
        {
            Reproductor reproductor = new Reproductor();
            reproductor.Show();
        }

        private void btn_LectorPDF_Click(object sender, EventArgs e)
        {
            Lector_PDF lector = new Lector_PDF();
            lector.Show();
        }

        private void btn_Navegador_Click(object sender, EventArgs e)
        {
            Navegador_Web navegador = new Navegador_Web();
            navegador.Show();
        }
    }
}
