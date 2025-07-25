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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadenas cad = new Cadenas();
            cad.Show();
        }

        private void btnlenguajes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lenguajes leng = new Lenguajes();
            leng.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
