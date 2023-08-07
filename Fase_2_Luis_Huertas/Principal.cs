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
    public partial class SPA_Mascotas : Form
    {
        
        SPA sPA = new SPA();
        public SPA_Mascotas()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Identificación_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            
            if (txt_Ide.Text != "" && txt_Nbre.Text !="" && txt_N_Mtas.Text !="" && combo_Estrato.Text !="" && (opt_1.Checked == true || ops_2.Checked == true || opt_3.Checked == true ))
            {
                bool error = false;
                foreach (char caracter in txt_Ide.Text)
                {
                    if (char.IsLetter(caracter))
                    {
                        error = true;
                        break;
                    }

                }
                if (error == true)
                {
                    error_id.SetError(txt_Ide, "No se admiten letras");
                }
                
                else if (error == false)
                {
                    error_id.Clear();
                    
                }
                bool erro = false;
                foreach (char caracter in txt_Nbre.Text)
                {
                    if (char.IsDigit(caracter))
                    {
                        erro = true;
                        break;
                    }

                }
                if (erro == true)
                {
                    error_nom.SetError(txt_Nbre, "No se admiten numeros");
                }
                else if (erro == false)
                {
                    error_nom.Clear();
                    
                }
                bool err = false;
                foreach (char caracter in txt_N_Mtas.Text)
                {
                    if (char.IsDigit(caracter))
                    {
                        err = true;
                        break;
                    }

                }
                if (err == true)
                {
                    error_nom_mas.SetError(txt_N_Mtas, "No se admiten numeros");
                }

                else if (err == false)
                {
                    error_nom_mas.Clear();
                    if (error == false && erro == false && err == false)
                    {
                        btn_Mostrar.Enabled = true;
                    }

                }


            }
            if (validar() == 1)
            {

                sPA.Identificacion = txt_Ide.Text;
                sPA.Nombre = txt_Nbre.Text;
                sPA.Nombre_Mascota = txt_N_Mtas.Text;
 
                if (opt_1.Checked == true)
                {
                    sPA.Opcion = "Baño y corte, $ 45.000";
                    sPA.Servicio = 1;
                    
                }
                else if (ops_2.Checked == true)
                {
                    sPA.Opcion = "Baño, corte y vacuna antigarrapatas, $80.000";
                    sPA.Servicio = 2;
                    
                }
                else if (opt_3.Checked == true)
                {
                    sPA.Opcion = "Baño, corte, Vacunas antigarrapatas y Antiparásitos $100.000";
                    sPA.Servicio =  3;
                }
                


            }

        }

            public int validar()
            {
                int b = 0;
                if(txt_Ide.Text == "")
                {
                
                    MessageBox.Show("Falta documento identidad");
                    txt_Ide.Focus();
                }
                else if(txt_Nbre.Text == "")
                {
                    MessageBox.Show("Falta nombre propietario");
                    txt_Nbre.Focus();
                }
                else if (txt_N_Mtas.Text == "")
                {
                    MessageBox.Show("Falta nombre mascota");
                    txt_N_Mtas.Focus();
                }
                else if (combo_Estrato.Text == "")
                {
                    MessageBox.Show("Falta estrato");
                    combo_Estrato.Focus();
                }
                else if (opt_1.Checked == false && ops_2.Checked == false && opt_3.Checked == false)
                {
                    MessageBox.Show("Falta seleccionar servicio");
                    
                }
                
                b = 1;
                return b;
                
            }


        private void combo_Estrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            sPA.Estrato = int.Parse(combo_Estrato.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_Costo_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void opt_1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Costo.Text = "$45000";

        }

        private void ops_2_CheckedChanged(object sender, EventArgs e)
        {
            txt_Costo.Text = "$80.000";
        }

        private void opt_3_CheckedChanged(object sender, EventArgs e)
        {
            txt_Costo.Text = "$100.000";
        }


        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
            reporte.txt_valor_rep.Text = sPA.Calcular().ToString();
            reporte.txt_nom_rep.Text = sPA.Nombre;
            reporte.txt_nom_mas_rep.Text = sPA.Nombre_Mascota;
            reporte.txt_ser_rep.Text = sPA.Opcion;
            sPA.Estrato = Convert.ToInt32(combo_Estrato.Text);
            reporte.txt_est_rep.Text = sPA.Estrato.ToString();
            reporte.txt_cc_rep.Text = sPA.Identificacion;

        }

        private void bnt_Salir_Click(object sender, EventArgs e)
        {
            Confirmar p = new Confirmar();
            p.ShowDialog();
            this.Hide();
        }
        private void txt_hora_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
