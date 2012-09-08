using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.RibbonHelpers;

namespace MyProject
{
    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoMensaje form1 = new NuevoMensaje();
            form1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            NuevoMensaje form1 = new NuevoMensaje();
            form1.Show();
        }
        
        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            openFileDialog1.Title = "Abrir";
            openFileDialog1.ShowDialog();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            /*Opcion solo para TD - REDISE */
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.ShowDialog();
        }

        private void Anexar_Click(object sender, EventArgs e)
        {
            /*Agregar un archivo adjunto al mensaje */
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Todos *.*|*.*|Documento de Texto *.txt|*.txt|Documento de Word 97-2003 *.doc|*.doc|Documento PDF *.pdf|*.pdf";                                     
            openFileDialog1.Title = "Anexar";
            openFileDialog1.ShowDialog();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Deberá estar parametrizado donde se guardara el docuemnto*/
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.ShowDialog();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            saveFileDialog1.Title = "Guardar como...";
            saveFileDialog1.ShowDialog();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            openFileDialog1.Title = "Abrir";
            openFileDialog1.ShowDialog();
        }

        private void guardarArchivoEnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensajesMilitares formMensaje = new MensajesMilitares();
            formMensaje.Show();
        }

        private void soporteTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Compañía Redes y Sistemas – Batallón de Comunicaciones 602
            MessageBox.Show("Compañía Redes y Sistemas – Batallón de Comunicaciones 602");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
