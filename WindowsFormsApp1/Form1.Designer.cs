namespace WindowsFormsApp1
{
    partial class frmmenu
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
            this.btncadenas = new System.Windows.Forms.Button();
            this.btnlenguajes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncadenas
            // 
            this.btncadenas.BackColor = System.Drawing.Color.Thistle;
            this.btncadenas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadenas.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btncadenas.FlatAppearance.BorderSize = 3;
            this.btncadenas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadenas.Location = new System.Drawing.Point(111, 105);
            this.btncadenas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncadenas.Name = "btncadenas";
            this.btncadenas.Size = new System.Drawing.Size(187, 53);
            this.btncadenas.TabIndex = 0;
            this.btncadenas.Text = "Operaciones con Cadenas";
            this.btncadenas.UseVisualStyleBackColor = false;
            this.btncadenas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlenguajes
            // 
            this.btnlenguajes.BackColor = System.Drawing.Color.Thistle;
            this.btnlenguajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlenguajes.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnlenguajes.FlatAppearance.BorderSize = 3;
            this.btnlenguajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlenguajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlenguajes.Location = new System.Drawing.Point(111, 175);
            this.btnlenguajes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlenguajes.Name = "btnlenguajes";
            this.btnlenguajes.Size = new System.Drawing.Size(187, 53);
            this.btnlenguajes.TabIndex = 1;
            this.btnlenguajes.Text = "Operaciones con Lenguajes";
            this.btnlenguajes.UseVisualStyleBackColor = false;
            this.btnlenguajes.Click += new System.EventHandler(this.btnlenguajes_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operaciones con Lenguajes Formales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(399, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlenguajes);
            this.Controls.Add(this.btncadenas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmmenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncadenas;
        private System.Windows.Forms.Button btnlenguajes;
        private System.Windows.Forms.Label label1;
    }
}

