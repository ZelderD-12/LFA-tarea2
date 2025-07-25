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
            this.SuspendLayout();
            // 
            // btncadenas
            // 
            this.btncadenas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadenas.Location = new System.Drawing.Point(265, 74);
            this.btncadenas.Name = "btncadenas";
            this.btncadenas.Size = new System.Drawing.Size(249, 65);
            this.btncadenas.TabIndex = 0;
            this.btncadenas.Text = "Operaciones con Cadenas";
            this.btncadenas.UseVisualStyleBackColor = true;
            this.btncadenas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlenguajes
            // 
            this.btnlenguajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlenguajes.Location = new System.Drawing.Point(235, 242);
            this.btnlenguajes.Name = "btnlenguajes";
            this.btnlenguajes.Size = new System.Drawing.Size(279, 38);
            this.btnlenguajes.TabIndex = 1;
            this.btnlenguajes.Text = "Operaciones con Lenguajes";
            this.btnlenguajes.UseVisualStyleBackColor = true;
            this.btnlenguajes.Click += new System.EventHandler(this.btnlenguajes_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 349);
            this.Controls.Add(this.btnlenguajes);
            this.Controls.Add(this.btncadenas);
            this.Name = "frmmenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncadenas;
        private System.Windows.Forms.Button btnlenguajes;
    }
}

