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
            pnlmenucadenas.Visible = true;
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
            pnlmenucadenas.Visible = true;
            alfabeto = alfabetoss.obtenerAlfabeto(alfabetoseleccionado);
            alfabetonumerico = alfabetoss.obtenerAlfabeto("Num");
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
            pnlalfabeto.Visible = true;
            pnlmenucadenas.Visible = false;
            pnlconcatenacion.Visible = false;
            pnllongitud.Visible = false;
            pnlpotencia.Visible = false;
            pnlinversa.Visible = false;
            txtinversa.Text = string.Empty;
            txtpotencia.Text = string.Empty;
            txtlongitud.Text = string.Empty;
            txtchain1.Text = string.Empty;
            txtchain2.Text = string.Empty;
            txtexponente.Text = "1";
        }

        private void btncalclong_Click(object sender, EventArgs e)
        {
            int longitud = txtlongitud.Text.Length;
            lbllong.Text = "|a| = " + longitud.ToString();
        }

        private void btncalcpot_Click(object sender, EventArgs e)
        {
            int potencia = Convert.ToInt32(txtexponente.Text);
            string cadenaresultado = "";
            lblexponente.Text = txtexponente.Text;
            if (potencia == 0)
            {
                cadenaresultado = $"e = λ";
            }
            else if (potencia > 0)
            {
                string cadenaoriginal = txtpotencia.Text;

                for (int n = 1; n <= potencia; n++)
                {
                    cadenaresultado += cadenaoriginal;
                }
            }
            else
            {
                cadenaresultado = "Inválido";
            }

            lblpotencia.Text = $"e = {cadenaresultado}";
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
            if (!char.IsControl(e.KeyChar) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtpotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtinversa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtlongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtchain2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtchain1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void btnconcat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtchain1.Text) && string.IsNullOrEmpty(txtchain2.Text))
            {
                lblconcat.Text = "λ";
                return;
            }
            lblconcat.Text = txtchain1.Text + txtchain2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnllongitud.Visible = true;
        }

        private void btnconcatenacion_Click(object sender, EventArgs e)
        {
            pnlconcatenacion.Visible = true;
        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            pnlpotencia.Visible = true;
        }

        private void btninversa_Click(object sender, EventArgs e)
        {
            pnlinversa.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlinversa.Visible = false;
            pnlmenucadenas.Visible = true;
            txtinversa.Text = string.Empty;
            lblinversa.Text = "N/A";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlpotencia.Visible = false;
            pnlmenucadenas.Visible = true;
            txtpotencia.Text = string.Empty;
            txtexponente.Text = "1";
            lblpotencia.Text = "N/A";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnllongitud.Visible = false;
            pnlmenucadenas.Visible = true;
            txtlongitud.Text = string.Empty;
            lbllong.Text = "N/A";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlconcatenacion.Visible = false;
            pnlmenucadenas.Visible = true;
            txtchain1.Text = string.Empty;
            txtchain2.Text = string.Empty;
            lblconcat.Text = "N/A";
        }

        private void btncalcinv_Click(object sender, EventArgs e)
        {
            string textooriginal = txtinversa.Text;

            if (string.IsNullOrEmpty(textooriginal))
            {
                lblinversa.Text = "d' = λ";
            }
            else
            {
                char[] caracteres = textooriginal.ToCharArray();
                Array.Reverse(caracteres);
                string textoinverso = new string(caracteres);
                lblinversa.Text = "d' = " + textoinverso;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cadenas_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
