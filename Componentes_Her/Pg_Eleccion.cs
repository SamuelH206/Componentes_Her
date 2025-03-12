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
    public partial class Pg_Eleccion : Form
    {
        public Pg_Eleccion()
        {
            InitializeComponent();
        }

        private void btn_Reproductor_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
