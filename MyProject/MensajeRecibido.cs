using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp;

namespace MyProject
{
    public partial class MensajeRecibido : Form
    {
        public MensajeRecibido()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            /* Guardar un archivo*/
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.ShowDialog();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entradaGFH_Click(object sender, EventArgs e)
        {
            //toma la hora del sistema con formato "dhhmmMMMMyy"
            entradaGFH.Text = DateTime.Now.ToString("dhhmmMMMyy").ToUpper();
            this.Select();
            base.OnClick(e);
        }

        private void entregadoGFH_Click(object sender, EventArgs e)
        {
            //toma la hora del sistema con formato "dhhmmMMMMyy"
            entregadoGFH.Text = DateTime.Now.ToString("dhhmmMMMyy").ToUpper();
            this.Select();
            base.OnClick(e);
        }

        private void recibio_TextChanged(object sender, EventArgs e)
        {
            Login login = new Login();
            recibio.Text = login.Controls["user"].Text;
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            // Hacer el *.pdf


        }
    }
}
