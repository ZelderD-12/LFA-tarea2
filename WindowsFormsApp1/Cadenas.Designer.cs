namespace WindowsFormsApp1
{
    partial class Cadenas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnconcatenacion = new System.Windows.Forms.Button();
            this.btnpotencia = new System.Windows.Forms.Button();
            this.btninversa = new System.Windows.Forms.Button();
            this.pnlmenucadenas = new System.Windows.Forms.Panel();
            this.pnlalfabeto = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbldefault = new System.Windows.Forms.Label();
            this.lblalfabeto = new System.Windows.Forms.Label();
            this.pnlalfabetoseleccionado = new System.Windows.Forms.Panel();
            this.btnalfabetochange = new System.Windows.Forms.Button();
            this.pnlinversa = new System.Windows.Forms.Panel();
            this.btncalcinv = new System.Windows.Forms.Button();
            this.lblinversa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinversa = new System.Windows.Forms.TextBox();
            this.pnlpotencia = new System.Windows.Forms.Panel();
            this.txtexponente = new System.Windows.Forms.TextBox();
            this.btncalcpot = new System.Windows.Forms.Button();
            this.lblpotencia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpotencia = new System.Windows.Forms.TextBox();
            this.pnlconcatenacion = new System.Windows.Forms.Panel();
            this.lblconcat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnconcat = new System.Windows.Forms.Button();
            this.txtchain2 = new System.Windows.Forms.TextBox();
            this.txtchain1 = new System.Windows.Forms.TextBox();
            this.pnllongitud = new System.Windows.Forms.Panel();
            this.btncalclong = new System.Windows.Forms.Button();
            this.lbllong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.pnlmenucadenas.SuspendLayout();
            this.pnlalfabeto.SuspendLayout();
            this.pnlalfabetoseleccionado.SuspendLayout();
            this.pnlinversa.SuspendLayout();
            this.pnlpotencia.SuspendLayout();
            this.pnlconcatenacion.SuspendLayout();
            this.pnllongitud.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Longitud";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnconcatenacion
            // 
            this.btnconcatenacion.Location = new System.Drawing.Point(39, 93);
            this.btnconcatenacion.Name = "btnconcatenacion";
            this.btnconcatenacion.Size = new System.Drawing.Size(115, 23);
            this.btnconcatenacion.TabIndex = 1;
            this.btnconcatenacion.Text = "Concatenación";
            this.btnconcatenacion.UseVisualStyleBackColor = true;
            // 
            // btnpotencia
            // 
            this.btnpotencia.Location = new System.Drawing.Point(39, 157);
            this.btnpotencia.Name = "btnpotencia";
            this.btnpotencia.Size = new System.Drawing.Size(75, 23);
            this.btnpotencia.TabIndex = 2;
            this.btnpotencia.Text = "Potencia";
            this.btnpotencia.UseVisualStyleBackColor = true;
            // 
            // btninversa
            // 
            this.btninversa.Location = new System.Drawing.Point(39, 235);
            this.btninversa.Name = "btninversa";
            this.btninversa.Size = new System.Drawing.Size(75, 23);
            this.btninversa.TabIndex = 3;
            this.btninversa.Text = "Inversa";
            this.btninversa.UseVisualStyleBackColor = true;
            // 
            // pnlmenucadenas
            // 
            this.pnlmenucadenas.Controls.Add(this.btninversa);
            this.pnlmenucadenas.Controls.Add(this.button1);
            this.pnlmenucadenas.Controls.Add(this.btnpotencia);
            this.pnlmenucadenas.Controls.Add(this.btnconcatenacion);
            this.pnlmenucadenas.Location = new System.Drawing.Point(39, 83);
            this.pnlmenucadenas.Name = "pnlmenucadenas";
            this.pnlmenucadenas.Size = new System.Drawing.Size(231, 319);
            this.pnlmenucadenas.TabIndex = 4;
            this.pnlmenucadenas.Visible = false;
            // 
            // pnlalfabeto
            // 
            this.pnlalfabeto.Controls.Add(this.label1);
            this.pnlalfabeto.Controls.Add(this.button3);
            this.pnlalfabeto.Controls.Add(this.button2);
            this.pnlalfabeto.Location = new System.Drawing.Point(337, 176);
            this.pnlalfabeto.Name = "pnlalfabeto";
            this.pnlalfabeto.Size = new System.Drawing.Size(335, 219);
            this.pnlalfabeto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿Qué alfabeto deseas usar para tus operaciones?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Español";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Inglés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbldefault
            // 
            this.lbldefault.AutoSize = true;
            this.lbldefault.Location = new System.Drawing.Point(26, 25);
            this.lbldefault.Name = "lbldefault";
            this.lbldefault.Size = new System.Drawing.Size(174, 16);
            this.lbldefault.TabIndex = 6;
            this.lbldefault.Text = "El alfabeto seleccionado es";
            this.lbldefault.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblalfabeto
            // 
            this.lblalfabeto.AutoSize = true;
            this.lblalfabeto.Location = new System.Drawing.Point(222, 25);
            this.lblalfabeto.Name = "lblalfabeto";
            this.lblalfabeto.Size = new System.Drawing.Size(30, 16);
            this.lblalfabeto.TabIndex = 7;
            this.lblalfabeto.Text = "N/A";
            this.lblalfabeto.Click += new System.EventHandler(this.lblalfabeto_Click);
            // 
            // pnlalfabetoseleccionado
            // 
            this.pnlalfabetoseleccionado.Controls.Add(this.btnalfabetochange);
            this.pnlalfabetoseleccionado.Controls.Add(this.lbldefault);
            this.pnlalfabetoseleccionado.Controls.Add(this.lblalfabeto);
            this.pnlalfabetoseleccionado.Location = new System.Drawing.Point(327, 12);
            this.pnlalfabetoseleccionado.Name = "pnlalfabetoseleccionado";
            this.pnlalfabetoseleccionado.Size = new System.Drawing.Size(425, 65);
            this.pnlalfabetoseleccionado.TabIndex = 8;
            this.pnlalfabetoseleccionado.Visible = false;
            // 
            // btnalfabetochange
            // 
            this.btnalfabetochange.Location = new System.Drawing.Point(281, 11);
            this.btnalfabetochange.Name = "btnalfabetochange";
            this.btnalfabetochange.Size = new System.Drawing.Size(127, 45);
            this.btnalfabetochange.TabIndex = 8;
            this.btnalfabetochange.Text = "Cambiar Alfabeto";
            this.btnalfabetochange.UseVisualStyleBackColor = true;
            this.btnalfabetochange.Click += new System.EventHandler(this.btnalfabetochange_Click);
            // 
            // pnlinversa
            // 
            this.pnlinversa.Controls.Add(this.btncalcinv);
            this.pnlinversa.Controls.Add(this.lblinversa);
            this.pnlinversa.Controls.Add(this.label2);
            this.pnlinversa.Controls.Add(this.txtinversa);
            this.pnlinversa.Location = new System.Drawing.Point(758, 37);
            this.pnlinversa.Name = "pnlinversa";
            this.pnlinversa.Size = new System.Drawing.Size(579, 210);
            this.pnlinversa.TabIndex = 9;
            // 
            // btncalcinv
            // 
            this.btncalcinv.Location = new System.Drawing.Point(394, 74);
            this.btncalcinv.Name = "btncalcinv";
            this.btncalcinv.Size = new System.Drawing.Size(153, 65);
            this.btncalcinv.TabIndex = 5;
            this.btncalcinv.Text = "Obtener Inversa";
            this.btncalcinv.UseVisualStyleBackColor = true;
            // 
            // lblinversa
            // 
            this.lblinversa.AutoSize = true;
            this.lblinversa.Location = new System.Drawing.Point(74, 139);
            this.lblinversa.Name = "lblinversa";
            this.lblinversa.Size = new System.Drawing.Size(30, 16);
            this.lblinversa.TabIndex = 4;
            this.lblinversa.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese una cadena para obtener su inversa";
            // 
            // txtinversa
            // 
            this.txtinversa.Location = new System.Drawing.Point(43, 82);
            this.txtinversa.Name = "txtinversa";
            this.txtinversa.Size = new System.Drawing.Size(236, 22);
            this.txtinversa.TabIndex = 2;
            this.txtinversa.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtinversa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinversa_KeyPress);
            // 
            // pnlpotencia
            // 
            this.pnlpotencia.Controls.Add(this.txtexponente);
            this.pnlpotencia.Controls.Add(this.btncalcpot);
            this.pnlpotencia.Controls.Add(this.lblpotencia);
            this.pnlpotencia.Controls.Add(this.label3);
            this.pnlpotencia.Controls.Add(this.txtpotencia);
            this.pnlpotencia.Location = new System.Drawing.Point(758, 265);
            this.pnlpotencia.Name = "pnlpotencia";
            this.pnlpotencia.Size = new System.Drawing.Size(579, 218);
            this.pnlpotencia.TabIndex = 0;
            // 
            // txtexponente
            // 
            this.txtexponente.Location = new System.Drawing.Point(325, 88);
            this.txtexponente.Name = "txtexponente";
            this.txtexponente.Size = new System.Drawing.Size(48, 22);
            this.txtexponente.TabIndex = 7;
            this.txtexponente.Text = "1";
            this.txtexponente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtexponente_KeyPress);
            // 
            // btncalcpot
            // 
            this.btncalcpot.Location = new System.Drawing.Point(394, 30);
            this.btncalcpot.Name = "btncalcpot";
            this.btncalcpot.Size = new System.Drawing.Size(163, 68);
            this.btncalcpot.TabIndex = 6;
            this.btncalcpot.Text = "Obtener Potencia";
            this.btncalcpot.UseVisualStyleBackColor = true;
            this.btncalcpot.Click += new System.EventHandler(this.btncalcpot_Click);
            // 
            // lblpotencia
            // 
            this.lblpotencia.AutoSize = true;
            this.lblpotencia.Location = new System.Drawing.Point(144, 135);
            this.lblpotencia.Name = "lblpotencia";
            this.lblpotencia.Size = new System.Drawing.Size(30, 16);
            this.lblpotencia.TabIndex = 5;
            this.lblpotencia.Text = "N/A";
            this.lblpotencia.Click += new System.EventHandler(this.lblpotencia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese una cadena para obtener su potencia";
            // 
            // txtpotencia
            // 
            this.txtpotencia.Location = new System.Drawing.Point(43, 78);
            this.txtpotencia.Name = "txtpotencia";
            this.txtpotencia.Size = new System.Drawing.Size(254, 22);
            this.txtpotencia.TabIndex = 0;
            this.txtpotencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtpotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpotencia_KeyPress);
            // 
            // pnlconcatenacion
            // 
            this.pnlconcatenacion.Controls.Add(this.lblconcat);
            this.pnlconcatenacion.Controls.Add(this.label5);
            this.pnlconcatenacion.Controls.Add(this.btnconcat);
            this.pnlconcatenacion.Controls.Add(this.txtchain2);
            this.pnlconcatenacion.Controls.Add(this.txtchain1);
            this.pnlconcatenacion.Location = new System.Drawing.Point(39, 449);
            this.pnlconcatenacion.Name = "pnlconcatenacion";
            this.pnlconcatenacion.Size = new System.Drawing.Size(410, 247);
            this.pnlconcatenacion.TabIndex = 10;
            // 
            // lblconcat
            // 
            this.lblconcat.AutoSize = true;
            this.lblconcat.Location = new System.Drawing.Point(158, 193);
            this.lblconcat.Name = "lblconcat";
            this.lblconcat.Size = new System.Drawing.Size(38, 20);
            this.lblconcat.TabIndex = 15;
            this.lblconcat.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingrese las cadenas a unir";
            // 
            // btnconcat
            // 
            this.btnconcat.Location = new System.Drawing.Point(113, 139);
            this.btnconcat.Name = "btnconcat";
            this.btnconcat.Size = new System.Drawing.Size(118, 23);
            this.btnconcat.TabIndex = 13;
            this.btnconcat.Text = "Concatenar";
            this.btnconcat.UseVisualStyleBackColor = true;
            this.btnconcat.Click += new System.EventHandler(this.btnconcat_Click);
            // 
            // txtchain2
            // 
            this.txtchain2.Location = new System.Drawing.Point(208, 71);
            this.txtchain2.Name = "txtchain2";
            this.txtchain2.Size = new System.Drawing.Size(100, 22);
            this.txtchain2.TabIndex = 12;
            this.txtchain2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtchain2_KeyPress);
            // 
            // txtchain1
            // 
            this.txtchain1.Location = new System.Drawing.Point(39, 71);
            this.txtchain1.Name = "txtchain1";
            this.txtchain1.Size = new System.Drawing.Size(100, 22);
            this.txtchain1.TabIndex = 11;
            this.txtchain1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtchain1_KeyPress);
            // 
            // pnllongitud
            // 
            this.pnllongitud.Controls.Add(this.btncalclong);
            this.pnllongitud.Controls.Add(this.lbllong);
            this.pnllongitud.Controls.Add(this.label4);
            this.pnllongitud.Controls.Add(this.txtlongitud);
            this.pnllongitud.Location = new System.Drawing.Point(504, 506);
            this.pnllongitud.Name = "pnllongitud";
            this.pnllongitud.Size = new System.Drawing.Size(512, 190);
            this.pnllongitud.TabIndex = 0;
            // 
            // btncalclong
            // 
            this.btncalclong.Location = new System.Drawing.Point(326, 82);
            this.btncalclong.Name = "btncalclong";
            this.btncalclong.Size = new System.Drawing.Size(158, 38);
            this.btncalclong.TabIndex = 7;
            this.btncalclong.Text = "Obtener Longitud";
            this.btncalclong.UseVisualStyleBackColor = true;
            this.btncalclong.Click += new System.EventHandler(this.btncalclong_Click);
            // 
            // lbllong
            // 
            this.lbllong.AutoSize = true;
            this.lbllong.Location = new System.Drawing.Point(234, 147);
            this.lbllong.Name = "lbllong";
            this.lbllong.Size = new System.Drawing.Size(30, 16);
            this.lbllong.TabIndex = 6;
            this.lbllong.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese una cadena para obtener su longitud";
            // 
            // txtlongitud
            // 
            this.txtlongitud.Location = new System.Drawing.Point(61, 84);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(232, 22);
            this.txtlongitud.TabIndex = 1;
            this.txtlongitud.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtlongitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlongitud_KeyPress);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(40, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(113, 41);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Cadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 758);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pnllongitud);
            this.Controls.Add(this.pnlconcatenacion);
            this.Controls.Add(this.pnlpotencia);
            this.Controls.Add(this.pnlinversa);
            this.Controls.Add(this.pnlalfabetoseleccionado);
            this.Controls.Add(this.pnlalfabeto);
            this.Controls.Add(this.pnlmenucadenas);
            this.Name = "Cadenas";
            this.Text = "Cadenas";
            this.pnlmenucadenas.ResumeLayout(false);
            this.pnlalfabeto.ResumeLayout(false);
            this.pnlalfabeto.PerformLayout();
            this.pnlalfabetoseleccionado.ResumeLayout(false);
            this.pnlalfabetoseleccionado.PerformLayout();
            this.pnlinversa.ResumeLayout(false);
            this.pnlinversa.PerformLayout();
            this.pnlpotencia.ResumeLayout(false);
            this.pnlpotencia.PerformLayout();
            this.pnlconcatenacion.ResumeLayout(false);
            this.pnlconcatenacion.PerformLayout();
            this.pnllongitud.ResumeLayout(false);
            this.pnllongitud.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnconcatenacion;
        private System.Windows.Forms.Button btnpotencia;
        private System.Windows.Forms.Button btninversa;
        private System.Windows.Forms.Panel pnlmenucadenas;
        private System.Windows.Forms.Panel pnlalfabeto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldefault;
        private System.Windows.Forms.Label lblalfabeto;
        private System.Windows.Forms.Panel pnlalfabetoseleccionado;
        private System.Windows.Forms.Panel pnlinversa;
        private System.Windows.Forms.Panel pnlpotencia;
        private System.Windows.Forms.Panel pnlconcatenacion;
        private System.Windows.Forms.Panel pnllongitud;
        private System.Windows.Forms.TextBox txtpotencia;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.TextBox txtinversa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblinversa;
        private System.Windows.Forms.Label lblpotencia;
        private System.Windows.Forms.Label lbllong;
        private System.Windows.Forms.Button btncalclong;
        private System.Windows.Forms.Button btncalcinv;
        private System.Windows.Forms.Button btncalcpot;
        private System.Windows.Forms.Button btnalfabetochange;
        private System.Windows.Forms.TextBox txtexponente;
        private System.Windows.Forms.Label lblconcat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnconcat;
        private System.Windows.Forms.TextBox txtchain2;
        private System.Windows.Forms.TextBox txtchain1;
        private System.Windows.Forms.Button btnback;
    }
}