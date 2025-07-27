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
    public partial class Lenguajes : Form
    {
        Alfabetos alfabetoss = new Alfabetos();
        string alfabetoseleccionado = "";
        char[] alfabeto;
        char[] alfabetonumerico;
        public Lenguajes()
        {
            InitializeComponent();
            grpselec.Location = new Point(175, 100);
        }

        private void btnesp_Click(object sender, EventArgs e)
        {
            alfabetoseleccionado = btnesp.Text;
            lblalfa.Text = alfabetoseleccionado;
            grpselec.Visible = false;
            grpalfa.Visible = true;
            grpmenu.Visible = true;
            alfabeto = alfabetoss.obtenerAlfabeto(alfabetoseleccionado);
            alfabetonumerico = alfabetoss.obtenerAlfabeto("Num");
            grpalfa.Location = new Point(323, 80);
        }

        private void btning_Click(object sender, EventArgs e)
        {
            alfabetoseleccionado = btning.Text;
            lblalfa.Text = alfabetoseleccionado;
            grpselec.Visible = false;
            grpalfa.Visible = true;
            grpmenu.Visible = true;
            alfabeto = alfabetoss.obtenerAlfabeto(alfabetoseleccionado);
            alfabetonumerico = alfabetoss.obtenerAlfabeto("Num");
            grpalfa.Location = new Point(323, 80);
        }

        private void btncamalfa_Click(object sender, EventArgs e)
        {
            grpmenu.Visible = false;
            grpalfa.Visible = false;
            grpselec.Visible = true;
            grpselec.Location = new Point(175, 100);
            pnlcon.Visible = false;
            pnlpot.Visible = false;
            pnlinv.Visible = false;
        }

        private void brncon_Click(object sender, EventArgs e)
        {
            pnlcon.Visible = true;
            pnlpot.Visible = false;
            pnlinv.Visible = false;
            txtl1con.Text = string.Empty;
            txtl2con.Text = string.Empty;
            lblconca.Text = "{ }";
        }

        private void txtl1con_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtl2con_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void btnconca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtl1con.Text) && string.IsNullOrEmpty(txtl2con.Text))
            {
                lblconca.Text = "λ";
                return;
            }
            lblconca.Text = "{ " + txtl1con.Text + txtl2con.Text + " }";
        }

        private void btnpot_Click(object sender, EventArgs e)
        {
            pnlpot.Visible = true;
            pnlcon.Visible = false;
            pnlinv.Visible = false;
            txtl1pot.Text = string.Empty;
            txtl2pot.Text = string.Empty;
            txtexp.Text = string.Empty;
            lbll1pot.Text = "= { }";
            lbll2pot.Text = "= { }";
            lbll1exp.Text = "*";
            lbll2exp.Text = "*";
        }

        private void txtexp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtl1pot_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void txtl2pot_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado))
            {
                e.Handled = true;
            }
        }

        private void btnpote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtexp.Text))
            {
                MessageBox.Show("Por favor, ingrese un exponente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int potencia = Convert.ToInt32(txtexp.Text);
                string cadenaresultado1 = "";
                string cadenaresultado2 = "";
                lbll1exp.Text = txtexp.Text;
                lbll2exp.Text = txtexp.Text;
                string cadenaoriginal1 = txtl1pot.Text;
                string cadenaoriginal2 = txtl2pot.Text;
                if (potencia == 0)
                {
                    cadenaresultado1 = "λ";
                    cadenaresultado2 = "λ";
                }
                else if (cadenaoriginal1 == string.Empty && cadenaoriginal2 == string.Empty)
                {
                    // Ambos vacíos con potencia > 0
                    cadenaresultado1 = "λ";
                    cadenaresultado2 = "λ";
                }
                else if (cadenaoriginal1 == string.Empty)
                {
                    cadenaresultado1 = "λ";
                    for (int n = 1; n <= potencia; n++)
                    {
                        cadenaresultado2 += cadenaoriginal2;
                    }
                }
                else if (cadenaoriginal2 == string.Empty)
                {
                    cadenaresultado2 = "λ";
                    for (int n = 1; n <= potencia; n++)
                    {
                        cadenaresultado1 += cadenaoriginal1;
                    }
                }
                else if (potencia > 0)
                {

                    for (int n = 1; n <= potencia; n++)
                    {
                        cadenaresultado1 += cadenaoriginal1;
                        cadenaresultado2 += cadenaoriginal2;
                    }
                }
                else
                {
                    cadenaresultado1 = "Inválido";
                    cadenaresultado2 = "Inválido";
                }

                lbll1pot.Text = $"= {{ {cadenaresultado1} }}";
                lbll2pot.Text = $"= {{ {cadenaresultado2} }}";
            }
        }

        private void btninv_Click(object sender, EventArgs e)
        {
            pnlinv.Visible = true;
            pnlpot.Visible = false;
            pnlcon.Visible = false;
            txtl1inv.Text = string.Empty;
            txtl2inv.Text = string.Empty;
            lbll1pot.Text = "= { }";
            lbll2pot.Text = "= { }";
        }

        private void btninver_Click(object sender, EventArgs e)
        {
            string textooriginal1 = txtl1inv.Text;
            string textooriginal2 = txtl2inv.Text;

            if (string.IsNullOrEmpty(textooriginal1) && string.IsNullOrEmpty(textooriginal2))
            {
                lbll1inver.Text = "= { λ }";
                lbll2inver.Text = "= { λ }";
            }
            else if (string.IsNullOrEmpty(textooriginal1))
            {
                lbll1inver.Text = "= { λ }";
                char[] caracteres2 = textooriginal2.ToCharArray();
                Array.Reverse(caracteres2);
                string textoinverso2 = new string(caracteres2);
                lbll2inver.Text = "= { " + textoinverso2 + " }";
            }
            else if (string.IsNullOrEmpty(textooriginal2))
            {
                char[] caracteres1 = textooriginal1.ToCharArray();
                Array.Reverse(caracteres1);
                string textoinverso1 = new string(caracteres1);
                lbll1inver.Text = "= { " + textoinverso1 + " }";
                lbll2inver.Text = "= { λ }";
            }
            else
            {
                char[] caracteres1 = textooriginal1.ToCharArray();
                char[] caracteres2 = textooriginal2.ToCharArray();
                Array.Reverse(caracteres1);
                Array.Reverse(caracteres2);
                string textoinverso1 = new string(caracteres1);
                string textoinverso2 = new string(caracteres2);
                lbll1inver.Text = "= { " + textoinverso1 + " }";
                lbll2inver.Text = "= { " + textoinverso2 + " }";
            }
        }
    }
}
