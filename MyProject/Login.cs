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
    public partial class Login : Form
    {
        private string usuario;
        
        public Login()
        {
            InitializeComponent();
        }
        
        private void aceptar_Click(object sender, EventArgs e)
        {
            if (this.user.Text == "DEMO" && this.password.Text == "DEMO")
            {
                usuario = this.user.Text;
                this.DialogResult = DialogResult.OK;
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
                this.user.Focus();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
