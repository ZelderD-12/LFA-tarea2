using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cadenas : Form
    {
        Alfabetos alfabetoss = new Alfabetos();
        string alfabetoseleccionado = "";
        public Cadenas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            alfabetoseleccionado = button2.Text;
            lblalfabeto.Text = alfabetoseleccionado;
            pnlalfabeto.Visible = false;
            pnlalfabetoseleccionado.Visible = true;
            char[] alfabeto = alfabetoss.obtenerAlfabeto(alfabetoseleccionado);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            alfabetoseleccionado = button3.Text;
            lblalfabeto.Text = alfabetoseleccionado;
            pnlalfabeto.Visible = false;
            pnlalfabetoseleccionado.Visible = true;
            char[] alfabeto = alfabetoss.obtenerAlfabeto(alfabetoseleccionado);
        }

        private void lblalfabeto_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpotencia_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnalfabetochange_Click(object sender, EventArgs e)
        {

        }

        private void btncalclong_Click(object sender, EventArgs e)
        {
            int longitud = txtlongitud.Text.Length;
            lbllong.Text = "La longitud de la cadena es: " + longitud.ToString();
        }

        private void btncalcpot_Click(object sender, EventArgs e)
        {
            int potencia = Convert.ToInt32(txtexponente.Text);
            string cadenaresultado = "";

            if (potencia == 0)
            {
                cadenaresultado = $"R{potencia} = λ";
            }
            else if (potencia > 0)
            {
               string cadenaoriginal = txtpotencia.Text;

                for(int n = 1; n<= potencia; n++)
                {
                    cadenaresultado += cadenaoriginal;
                }
            }
            else
            {
                cadenaresultado = "Inválido";
            }

                lblpotencia.Text = cadenaresultado;
        }
    }
}
