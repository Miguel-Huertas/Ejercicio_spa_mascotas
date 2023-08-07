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
    public partial class Confirmar : Form
    {
        public Confirmar()
        {
            InitializeComponent();
        }

        private void bnt_no_Click(object sender, EventArgs e)
        {
            SPA_Mascotas p = new SPA_Mascotas();
            p.ShowDialog();
            this.Hide();
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el codigo\n \nRegresa pronto.");
            Application.Exit();
        }
    }
}
