using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase_2_Luis_Huertas
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void btn_retornar_Click(object sender, EventArgs e)
        {
            SPA_Mascotas p = new SPA_Mascotas();
            p.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_cc_rep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
