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
    public partial class Principal1 : Form
    {
        public Principal1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Close();
        }

        private void editorMMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoMensaje form = new NuevoMensaje();
            form.Show();
        }

        private void editor_Click(object sender, EventArgs e)
        {
            NuevoMensaje form = new NuevoMensaje();
            form.Show();
        }

        private void Recibo_Click(object sender, EventArgs e)
        {
            new Recibido().Show();
        }

        private void enviarrecibir_Click(object sender, EventArgs e)
        {
            //falta la parte de envío
            new Recibido().Show();
        }

        private void cambiarOP_Click(object sender, EventArgs e)
        {
            new IDoperador().Show();
        }

        private void soporteTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Compañía Redes y Sistemas – Batallón de Comunicaciones 602
            MessageBox.Show("Compañía Redes y Sistemas – Batallón de Comunicaciones 602");
        }

        private void administradorDeMensajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MensajesMilitares().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Login().Close();
        }

        private void cambiarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IDoperador().ShowDialog();
        }

        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Falta la parte de envio
            new Recibido().Show();
        }

        private void borradores_Click(object sender, EventArgs e)
        {
            //new TestRibbon().Show();
        }

        private void archivo_Click(object sender, EventArgs e)
        {
            //new Principal().Show();
        }
    }
}
