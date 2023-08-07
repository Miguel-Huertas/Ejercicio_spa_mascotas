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
    public partial class Frmclave : Form
    {
        public Frmclave()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if(textclave.Text != "")
            {
                if (textclave.Text == "123")
                {
                    SPA_Mascotas p = new SPA_Mascotas();
                    p.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ERROR \n Digite clave correcta");
                    textclave.Focus();
                    textclave.Clear();
                }
            }
            else
            {
                MessageBox.Show("Digite clave");
                textclave.Focus();
            }
        }

        private void Frmclave_Load(object sender, EventArgs e)
        {
            

        }
        
        private void txt_hora_Click(object sender, EventArgs e)
        {
            
        }
    }
}
