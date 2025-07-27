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
            pnlunion.Visible = false;
            pnlinter.Visible = false;
            pnldif.Visible = false;
            pnlcomp.Visible = false;
            pnlkle.Visible = false;
            pnlpos.Visible = false;
        }

        private void brncon_Click(object sender, EventArgs e)
        {
            pnlcon.Visible = true;
            pnlpot.Visible = false;
            pnlinv.Visible = false;
            pnlunion.Visible = false;
            pnlinter.Visible = false;
            pnldif.Visible = false;
            pnlcomp.Visible = false;
            pnlkle.Visible = false;
            pnlpos.Visible = false;
            txtl1con.Text = string.Empty;
            txtl2con.Text = string.Empty;
            lblconca.Text = "{ }";
        }

        private void txtl1con_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) &&
        ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void txtl2con_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) &&
        ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void btnconca_Click(object sender, EventArgs e)
        {
            // Verificar si ambos campos están vacíos
            if (string.IsNullOrWhiteSpace(txtl1con.Text) && string.IsNullOrWhiteSpace(txtl2con.Text))
            {
                lblconca.Text = "{ λ }";
                return;
            }

            // Preparar los elementos, usando "λ" si alguno está vacío
            string[] elementos1 = string.IsNullOrWhiteSpace(txtl1con.Text)
                ? new string[] { "λ" }
                : txtl1con.Text.Split(',').Select(x => x.Trim()).ToArray();

            string[] elementos2 = string.IsNullOrWhiteSpace(txtl2con.Text)
                ? new string[] { "λ" }
                : txtl2con.Text.Split(',').Select(x => x.Trim()).ToArray();

            List<string> combinaciones = new List<string>();

            // Generar todas las combinaciones entre los dos conjuntos
            foreach (string item1 in elementos1)
            {
                foreach (string item2 in elementos2)
                {
                    combinaciones.Add(item1 + item2);
                }
            }

            // Mostrar resultado formateado
            lblconca.Text = "{ " + string.Join(", ", combinaciones) + " }";
        }

        private void btnpot_Click(object sender, EventArgs e)
        {
            pnlpot.Visible = true;
            pnlcon.Visible = false;
            pnlinv.Visible = false;
            pnlunion.Visible = false;
            pnlinter.Visible = false;
            pnldif.Visible = false;
            pnlcomp.Visible = false;
            pnlkle.Visible = false;
            pnlpos.Visible = false;
            txtl1pot.Text = string.Empty;
            txtl2pot.Text = string.Empty;
            txtexp.Text = string.Empty;
            lbll1pot.Text = "= { }";
            lbll2pot.Text = "= { }";
            lbll1exp.Text = "n";
            lbll2exp.Text = "n";
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
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void txtl2pot_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void btnpote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtexp.Text))
            {
                MessageBox.Show("Por favor, ingrese un exponente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int potencia = Convert.ToInt32(txtexp.Text);
            lbll1exp.Text = txtexp.Text;
            lbll2exp.Text = txtexp.Text;

            List<string> resultado1 = new List<string>();
            List<string> resultado2 = new List<string>();

            bool campo1Vacio = string.IsNullOrWhiteSpace(txtl1pot.Text);
            bool campo2Vacio = string.IsNullOrWhiteSpace(txtl2pot.Text);

            if (potencia < 0)
            {
                resultado1.Add("Inválido");
                resultado2.Add("Inválido");
            }
            else if (potencia == 0)
            {
                resultado1.Add("λ");
                resultado2.Add("λ");
            }
            else
            {
                string[] elementos1 = campo1Vacio ? new string[] { "λ" } : txtl1pot.Text.Split(',').Select(x => x.Trim()).ToArray();
                string[] elementos2 = campo2Vacio ? new string[] { "λ" } : txtl2pot.Text.Split(',').Select(x => x.Trim()).ToArray();

                resultado1 = PotenciaDeLenguaje(elementos1, potencia);
                resultado2 = PotenciaDeLenguaje(elementos2, potencia);
            }

            lbll1pot.Text = $"= {{ {string.Join(", ", resultado1)} }}";
            lbll2pot.Text = $"= {{ {string.Join(", ", resultado2)} }}";
        }

        private List<string> PotenciaDeLenguaje(string[] lenguaje, int potencia)
        {
            List<string> resultado = new List<string> { "" };

            for (int i = 0; i < potencia; i++)
            {
                resultado = resultado.SelectMany(r => lenguaje.Select(e => r + e)).ToList();
            }

            // Si el resultado contiene solo cadena vacía, se representa como λ
            return resultado.Select(r => string.IsNullOrEmpty(r) ? "λ" : r).ToList();
        }

        private void btninv_Click(object sender, EventArgs e)
        {
            pnlinv.Visible = true;
            pnlpot.Visible = false;
            pnlcon.Visible = false;
            pnlunion.Visible = false;
            pnlinter.Visible = false;
            pnldif.Visible = false;
            pnlcomp.Visible = false;
            pnlkle.Visible = false;
            pnlpos.Visible = false;
            txtl1inv.Text = string.Empty;
            txtl2inv.Text = string.Empty;
            lbll1pot.Text = "= { }";
            lbll2pot.Text = "= { }";
        }

        private void txtl1inv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void txtl2inv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void btninver_Click(object sender, EventArgs e)
        {
            string textooriginal1 = txtl1inv.Text;
            string textooriginal2 = txtl2inv.Text;

            List<string> resultado1 = new List<string>();
            List<string> resultado2 = new List<string>();

            bool campo1Vacio = string.IsNullOrWhiteSpace(textooriginal1);
            bool campo2Vacio = string.IsNullOrWhiteSpace(textooriginal2);

            if (campo1Vacio && campo2Vacio)
            {
                lbll1inver.Text = "= { λ }";
                lbll2inver.Text = "= { λ }";
            }
            else
            {
                // Procesar campo 1
                if (campo1Vacio)
                {
                    resultado1.Add("λ");
                }
                else
                {
                    string[] elementos1 = textooriginal1.Split(',');
                    for (int i = 0; i < elementos1.Length; i++)
                    {
                        string limpio = elementos1[i].Trim();
                        char[] chars = limpio.ToCharArray();
                        Array.Reverse(chars);
                        resultado1.Add(new string(chars));
                    }
                }

                // Procesar campo 2
                if (campo2Vacio)
                {
                    resultado2.Add("λ");
                }
                else
                {
                    string[] elementos2 = textooriginal2.Split(',');
                    for (int i = 0; i < elementos2.Length; i++)
                    {
                        string limpio = elementos2[i].Trim();
                        char[] chars = limpio.ToCharArray();
                        Array.Reverse(chars);
                        resultado2.Add(new string(chars));
                    }
                }

                lbll1inver.Text = "= { " + string.Join(", ", resultado1) + " }";
                lbll2inver.Text = "= { " + string.Join(", ", resultado2) + " }";
            }
        }

        private void btnuni_Click(object sender, EventArgs e)
        {
            pnlunion.Visible = true;
            pnlinv.Visible = false;
            pnlpot.Visible = false;
            pnlcon.Visible = false;
            pnlinter.Visible = false;
            pnldif.Visible = false;
            pnlcomp.Visible = false;
            pnlkle.Visible = false;
            pnlpos.Visible = false;
            txtl1uni.Text = string.Empty;
            txtl2uni.Text = string.Empty;
            lblunion.Text = "{ }";
        }

        private void btnunion_Click(object sender, EventArgs e)
        {
            string textooriginal1 = txtl1uni.Text;
            string textooriginal2 = txtl2uni.Text;

            List<string> unionTotal = new List<string>();

            bool campo1Vacio = string.IsNullOrWhiteSpace(textooriginal1);
            bool campo2Vacio = string.IsNullOrWhiteSpace(textooriginal2);

            if (campo1Vacio && campo2Vacio)
            {
                lblunion.Text = "{ λ }";
                return;
            }

            HashSet<string> elementosUnicos = new HashSet<string>();

            if (campo1Vacio)
            {
                elementosUnicos.Add("λ");
            }
            else
            {
                string[] elementos1 = textooriginal1.Split(',');
                foreach (string elem in elementos1)
                {
                    elementosUnicos.Add(elem.Trim());
                }
            }

            if (campo2Vacio)
            {
                elementosUnicos.Add("λ");
            }
            else
            {
                string[] elementos2 = textooriginal2.Split(',');
                foreach (string elem in elementos2)
                {
                    elementosUnicos.Add(elem.Trim());
                }
            }

            // Mostrar la unión sin duplicados
            lblunion.Text = "{ " + string.Join(", ", elementosUnicos) + " }";
        }

        private void btnint_Click(object sender, EventArgs e)
        {
            pnlinter.Visible = true;
            pnlinv.Visible = false;
            pnlpot.Visible = false;
            pnlcon.Visible = false;
            pnlunion.Visible = false;
            pnldif.Visible = false;
            pnlcomp.Visible = false;
            pnlkle.Visible = false;
            pnlpos.Visible = false;
            txtl1inter.Text = string.Empty;
            txtl2inter.Text = string.Empty;
            lblinter.Text = "{ }";
        }

        private void txtl1inter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void txtl2inter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void btninter_Click(object sender, EventArgs e)
        {
            string textooriginal1 = txtl1inter.Text;
            string textooriginal2 = txtl2inter.Text;

            bool campo1Vacio = string.IsNullOrWhiteSpace(textooriginal1);
            bool campo2Vacio = string.IsNullOrWhiteSpace(textooriginal2);

            if (campo1Vacio && campo2Vacio)
            {
                lblinter.Text = "{ λ }";
                return;
            }

            // Convertir ambos textos en conjuntos
            HashSet<string> conjunto1 = new HashSet<string>();
            HashSet<string> conjunto2 = new HashSet<string>();

            if (!campo1Vacio)
            {
                string[] elementos1 = textooriginal1.Split(',');
                foreach (string elem in elementos1)
                {
                    conjunto1.Add(elem.Trim());
                }
            }

            if (!campo2Vacio)
            {
                string[] elementos2 = textooriginal2.Split(',');
                foreach (string elem in elementos2)
                {
                    conjunto2.Add(elem.Trim());
                }
            }

            // Si alguno de los conjuntos está vacío, simulamos como {λ} vacío
            if (conjunto1.Count == 0 || conjunto2.Count == 0)
            {
                lblinter.Text = "{ λ }";
                return;
            }

            // Calcular intersección
            var interseccion = conjunto1.Intersect(conjunto2).ToList();

            if (interseccion.Count == 0)
            {
                lblinter.Text = "{ λ }";
            }
            else
            {
                lblinter.Text = "{ " + string.Join(", ", interseccion) + " }";
            }
        }

        private void btndif_Click(object sender, EventArgs e)
        {
            pnldif.Visible = true;
            pnlinv.Visible = false;
            pnlpot.Visible = false;
            pnlcon.Visible = false;
            pnlunion.Visible = false;
            pnlinter.Visible = false;
            pnlcomp.Visible = false;
            pnlkle.Visible = false;
            pnlpos.Visible = false;
            txtl1dif.Text = string.Empty;
            txtl2dif.Text = string.Empty;
            lbldif.Text = "{ }";
        }

        private void txtl1dif_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void txtl2dif_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textooriginal1 = txtl1dif.Text;
            string textooriginal2 = txtl2dif.Text;

            bool campo1Vacio = string.IsNullOrWhiteSpace(textooriginal1);
            bool campo2Vacio = string.IsNullOrWhiteSpace(textooriginal2);

            // Si ambos campos están vacíos, la diferencia es { λ }
            if (campo1Vacio && campo2Vacio)
            {
                lbldif.Text = "{ λ }";
                return;
            }

            HashSet<string> conjunto1 = new HashSet<string>();
            HashSet<string> conjunto2 = new HashSet<string>();

            if (!campo1Vacio)
            {
                string[] elementos1 = textooriginal1.Split(',');
                foreach (string elem in elementos1)
                {
                    conjunto1.Add(elem.Trim());
                }
            }

            if (!campo2Vacio)
            {
                string[] elementos2 = textooriginal2.Split(',');
                foreach (string elem in elementos2)
                {
                    conjunto2.Add(elem.Trim());
                }
            }

            // Si L1 está vacío, no hay elementos que quitar → { λ }
            if (conjunto1.Count == 0)
            {
                lbldif.Text = "{ λ }";
                return;
            }

            // Calcular diferencia L1 – L2
            var diferencia = conjunto1.Except(conjunto2).ToList();

            lbldif.Text = diferencia.Count > 0
                ? "{ " + string.Join(", ", diferencia) + " }"
                : "{ λ }";
        }

        private void btncom_Click(object sender, EventArgs e)
        {
            pnlcomp.Visible = true;
            pnlinv.Visible = false;
            pnlpot.Visible = false;
            pnlcon.Visible = false;
            pnlunion.Visible = false;
            pnlinter.Visible = false;
            pnldif.Visible = false;
            pnlkle.Visible = false;
            pnlpos.Visible = false;
            txtl1comp.Text = string.Empty;
            lblcomp.Text = "{ }";
        }

        private void txtl1comp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void btncomp_Click(object sender, EventArgs e)
        {
            string textooriginal1 = txtl1comp.Text;
            bool campo1Vacio = string.IsNullOrWhiteSpace(textooriginal1);

            // Si el campo está vacío, complemento es todo el alfabeto
            if (campo1Vacio)
            {
                lblcomp.Text = "{ λ, " + string.Join(", ", alfabeto) + " }";
                return;
            }

            // Convertir alfabeto de char[] a string[]
            List<string> alfabetoStr = alfabeto.Select(c => c.ToString()).ToList();

            // Cargar elementos del lenguaje
            HashSet<string> lenguajeL = new HashSet<string>();
            string[] elementos = textooriginal1.Split(',');
            foreach (string elem in elementos)
            {
                lenguajeL.Add(elem.Trim());
            }

            // Calcular complemento correctamente
            var complemento = alfabetoStr.Except(lenguajeL).ToList();

            lblcomp.Text = complemento.Count > 0
                ? "{ λ, " + string.Join(", ", complemento) + " }"
                : "{ λ }";
        }

        private void btnkle_Click(object sender, EventArgs e)
        {
            pnlkle.Visible = true;
            pnlinv.Visible = false;
            pnlpot.Visible = false;
            pnlcon.Visible = false;
            pnlunion.Visible = false;
            pnlinter.Visible = false;
            pnldif.Visible = false;
            pnlcomp.Visible = false;
            pnlpos.Visible = false;
            txtl1kle.Text = string.Empty;
            lblkle.Text = "{ }";
        }

        private void txtl1kle_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void btnklee_Click(object sender, EventArgs e)
        {
            string textooriginal1 = txtl1kle.Text;
            bool campo1Vacio = string.IsNullOrWhiteSpace(textooriginal1);

            HashSet<string> lenguajeL = new HashSet<string>();

            if (!campo1Vacio)
            {
                string[] elementos = textooriginal1.Split(',');
                foreach (string elem in elementos)
                {
                    lenguajeL.Add(elem.Trim());
                }
            }

            int profundidad = 3; // Puedes cambiar el nivel de repeticiones
            HashSet<string> cierreKleene = new HashSet<string> { "λ" };

            for (int i = 1; i <= profundidad; i++)
            {
                var nuevos = GenerarCombinaciones(lenguajeL.ToList(), i);
                foreach (string s in nuevos)
                {
                    cierreKleene.Add(s);
                }
            }

            lblkle.Text = "{ " + string.Join(", ", cierreKleene) + ", ... }";
        }

        private List<string> GenerarCombinaciones(List<string> lenguaje, int longitud)
        {
            if (longitud == 1)
                return new List<string>(lenguaje);

            List<string> resultado = new List<string>();
            var anteriores = GenerarCombinaciones(lenguaje, longitud - 1);

            foreach (string previo in anteriores)
            {
                foreach (string actual in lenguaje)
                {
                    resultado.Add(previo + actual);
                }
            }

            return resultado;
        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            pnlpos.Visible = true;
            pnlinv.Visible = false;
            pnlpot.Visible = false;
            pnlcon.Visible = false;
            pnlunion.Visible = false;
            pnlinter.Visible = false;
            pnldif.Visible = false;
            pnlcomp.Visible = false;
            pnlkle.Visible = false;
            txtl1pos.Text = string.Empty;
            lblpos.Text = "{ }";
        }

        private void txtl1pos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ingresado = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !alfabeto.Contains(ingresado) && !alfabetonumerico.Contains(ingresado) && ingresado != ',')
            {
                e.Handled = true;
            }
        }

        private void btnposi_Click(object sender, EventArgs e)
        {
            string textooriginal1 = txtl1pos.Text;
            bool campo1Vacio = string.IsNullOrWhiteSpace(textooriginal1);

            HashSet<string> lenguajeL = new HashSet<string>();

            if (!campo1Vacio)
            {
                string[] elementos = textooriginal1.Split(',');
                foreach (string elem in elementos)
                {
                    lenguajeL.Add(elem.Trim());
                }
            }

            int profundidad = 3; // Puedes aumentar para más combinaciones
            HashSet<string> cierrePositivo = new HashSet<string>(); // SIN λ

            for (int i = 1; i <= profundidad; i++)
            {
                var nuevos = GenerarCombinaciones(lenguajeL.ToList(), i);
                foreach (string s in nuevos)
                {
                    cierrePositivo.Add(s);
                }
            }

            lblpos.Text = "{ " + string.Join(", ", cierrePositivo) + ", ... }";
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu form = new frmmenu();
            form.Show();
        }
    }
}
