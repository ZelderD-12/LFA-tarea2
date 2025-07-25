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
        char[] alfabeto;
        char[] alfabetonumerico;
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
            alfabeto = alfabetoss.obtenerAlfabeto(alfabetoseleccionado);
            alfabetonumerico = alfabetoss.obtenerAlfabeto("Num");
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
            char[] alfabetonumerico = alfabetoss.obtenerAlfabeto("Num");
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu form = new frmmenu();
            form.Show();
        }

        private void txtexponente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtpotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabeto.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtinversa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabeto.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtlongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabeto.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtchain2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabeto.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtchain1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabeto.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void btnconcat_Click(object sender, EventArgs e)
        {
            lblconcat.Text = txtchain1.Text + txtchain2.Text;
        }
    }
}
