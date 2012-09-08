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
    public partial class administrarmensaje : Form
    {
        public administrarmensaje()
        {
            InitializeComponent();
        }
                
        private void button4_Click(object sender, EventArgs e)
        {
            NuevoMensaje formulario = new NuevoMensaje();
            formulario.Show();

            //this.dataGridView1_CellContentClick(formulario);
            /*Helpers.Agregadora agrega = new Helpers.Agregadora();
            agrega.agregar(frm4, );*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {     
            //Elimina un mensaje de la lista
            this.enviados.Rows.Clear();
        }
        
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        private void dataGridView1_CellContentClick(Form formulario)
        {
         /*   this.enviados.Rows.Add(this.Controls["facilidad"].Text,
                this.Controls["canal"].Text);*/
            
        }
    }
}
