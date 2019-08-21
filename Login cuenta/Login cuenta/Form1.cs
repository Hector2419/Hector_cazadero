using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_cuenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string co = correo.Text;
            string cn = contrasena.Text;
            if (co == "juancho"&& cn == "123frijoles")
            {
                MessageBox.Show("Accediste con exito!");
                this.Close();
            }
            else
            {
                MessageBox.Show("tu correo o tu contraseña son incorrectos");
            }
        }

        private void Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
  
}
