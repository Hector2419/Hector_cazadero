namespace Login_cuenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.boton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Facebook = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo Electronico:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(194, 110);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(209, 20);
            this.correo.TabIndex = 3;
            this.correo.TextChanged += new System.EventHandler(this.Correo_TextChanged);
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(194, 144);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(209, 20);
            this.contrasena.TabIndex = 4;
            this.contrasena.UseSystemPasswordChar = true;
            // 
            // boton
            // 
            this.boton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton.Image = global::Login_cuenta.Properties.Resources.botton;
            this.boton.Location = new System.Drawing.Point(41, 240);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(326, 71);
            this.boton.TabIndex = 5;
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = global::Login_cuenta.Properties.Resources.f1;
            this.pictureBox1.Location = new System.Drawing.Point(435, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 229);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Facebook
            // 
            this.Facebook.AutoSize = true;
            this.Facebook.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facebook.ForeColor = System.Drawing.Color.Cornsilk;
            this.Facebook.Location = new System.Drawing.Point(87, 22);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(280, 59);
            this.Facebook.TabIndex = 7;
            this.Facebook.Text = "Facebook";
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(736, 293);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(156, 40);
            this.salir.TabIndex = 8;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::Login_cuenta.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(921, 355);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Facebook);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Cartel1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Facebook;
        private System.Windows.Forms.Button salir;
    }
}

