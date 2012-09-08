using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyProject
{
    public partial class IDoperador : Form
    {
        public IDoperador()
        {
            InitializeComponent();
            this.nombreOP.Focus();
        }

        private void cancelarOP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptarOP_Click(object sender, EventArgs e)
        {
            /*Se deberán validar los siguientes campos:
             * nombreOP
             * contraseñaop
             * contraseñatp
             */
            
            if (this.nombreOP.Text  == "ope2" &&
                this.contraseñaop.Text == "psw2" &&
                this.contraseñatd.Text == "psw3")
            {
                this.Close();
                MessageBox.Show("El Cambio se produjo exitosamente");
                /*Asignar los nuevos valores a los campos correspondientes*/
            }
            else 
            {
                MessageBox.Show("Usuario o Contraseña inválida");

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox text = ctrl as TextBox;
                        text.Clear();
                    }
                }
                this.nombreOP.Focus();
            }
        }
    }
}
