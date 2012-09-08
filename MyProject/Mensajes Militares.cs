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
    public partial class MensajesMilitares : Form
    {
        public MensajesMilitares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = "Hello, World!";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void generarMensajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarMensaje frm = new GenerarMensaje();

            frm.ShowDialog();
            //frm2.Show();
        }

        private void administrarMensajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            administrarmensaje frm1 = new administrarmensaje();
            
            frm1.Show();
        }

        private void listaFacilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_facil frm2 = new L_facil();

            frm2.Show();
        }

        private void listaClasificacionSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Clasificacion_de_Seguridad frm3 = new L_Clasificacion_de_Seguridad();

            frm3.Show();
        }

        private void listaDePromotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_prom frm4 = new L_prom();

            frm4.Show();
        }

        private void listaDeTransmisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_transmi frm5 = new L_transmi();

            frm5.Show();
        }

        private void listaDeCanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_canal frm6 = new L_canal();

            frm6.Show();
        }

        private void listaDeProcedenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_proce frm7 = new L_proce();

            frm7.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Recibido().Show();
        }

        private void administrarMensajesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new administrarmensaje().ShowDialog();
        }
    }
}
