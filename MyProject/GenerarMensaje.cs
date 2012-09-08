using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Helpers;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.error_messages;


namespace MyProject
{
    public partial class GenerarMensaje : Form
    {
        int cont = 0;

        public GenerarMensaje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Por cada elemento enviado se debe incrementar el contador, se debe
             * guardar en algun lado para que cuente todos los mensajes enviados 
             * desde el TD*/
            this.cont = this.cont+1;
            nrocontrol.Text = (this.cont).ToString();
            Helpers.Mailer mailer = new Helpers.Mailer();
            if (mailer.enviar((Form)this))
            {
                MessageBox.Show("Mensaje enviado");

                /* El formulario enviado se deberá guaradar en el 
                 * dataGridView1_CellContent de la clase "administrarmensaje"
                 */
                administrarmensaje newmessage = new administrarmensaje();
                Helpers.Agregadora agrega = new Helpers.Agregadora();
                
            }
            else {
                MessageBox.Show("Error de mensaje");
            };
            /*Completar el Atributo	"Entrada a la Central de Tráfico – GFH"
             * textBox4.Text = DateTime.Now.ToString("dhhmmMMMyy").ToUpper();
             * this.Select();
             * base.OnClick(e);*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Muestra el contador de mensajes enviados
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            /*Esta caja debe contar la cantidad de palabras del mensaje 
             * en "richTextBox1_TextChanged"*/
            grupo.Text = Convert.ToString(texto.Text.Split());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Aca se escribe el mensaje
            if (texto.Text.Length == 0)
            {
                asunto.Clear();
            }
        }

        private void asunto_TextChanged(object sender, EventArgs e)
        {
            //Se debe corresponder con la primera parte del mensaje
            texto.Text = asunto.Text;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            //Toma la hora del sistema con formato "dhhmmMMMMyy"
            clickgfh.Text = DateTime.Now.ToString("dhhmmMMMyy").ToUpper();
            this.Select();
            base.OnClick(e);
        }

        private void richTextBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            //Suma la cantidad de palabras (boton "Grupo")
            string excp = @"\b(\w+?)\b";
            grupo.Text = System.Text.RegularExpressions.Regex.Matches(texto.Text.Trim(),excp).Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Abrir un archivo
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            openFileDialog1.Title = "Abrir";
            openFileDialog1.ShowDialog();
            //MessageBox.Show(this.Controls[17].Text); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Guardar un archivo
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Agregar un archivo adjunto al mensaje 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Todos *.*|*.*|Documento de Texto *.txt|*.txt|Documento de Word 97-2003 *.doc|*.doc|Documento PDF *.pdf|*.pdf";
            openFileDialog1.Title = "Adjuntar";
            openFileDialog1.ShowDialog();
        }

        public string getPromotor() 
        {
            return this.promotor.SelectedValue.ToString();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {

                if (!(ctrl.Enabled))
                {
                    ctrl.Enabled = true;
                }

                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }

                if (ctrl is ComboBox) 
                { 
                    ComboBox text = ctrl as ComboBox;
                    text.Text = "";                    
                }

                if (ctrl is CheckBox)
                {
                    CheckBox text = ctrl as CheckBox;
                    text.Checked = false;
                }

                if (ctrl is RichTextBox)
                {
                    RichTextBox text = ctrl as RichTextBox;
                    text.Clear();
                }

                if (ctrl is MaskedTextBox)
                {
                    MaskedTextBox text = ctrl as MaskedTextBox;
                    text.Text = "0";
                }
            }
            this.facilidad.Focus();
        }

        private void facilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(facilidad.Text)
            {
                case "ESTAFETA":
                    canal.Text = "....";
                    canal.Enabled = false;
                    autenticar.Enabled = false;
                    autenticado.Enabled = false;
                    break;

                case "SATELITAL":
                    canal.Text = "....";
                    canal.Enabled = false;
                    autenticar.Enabled = false;
                    autenticado.Enabled = false;
                    break;

                case "ALAMBRICA":
                    canal.Text = "";
                    canal.Enabled = true;
                    autenticar.Enabled = false;
                    autenticado.Enabled = false;
                    break;

                case "MIXTA":
                    canal.Text = "";
                    canal.Enabled = true;
                    autenticar.Enabled = false;
                    autenticado.Enabled = false;
                    break;

                case "RADIOELECTRICA":
                    canal.Text = "";
                    canal.Enabled = true;
                    autenticar.Enabled = true;
                    autenticado.Enabled = true;
                    break;
            };
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            //Hacer *.pdf
            
            /*ruta de acceso por Defaul? 
             * Mostramos el dialogo asi elije ruta de guardado?
             */

            SaveFileDialog imprimir = new SaveFileDialog();
            imprimir.AddExtension = true;
            imprimir.Filter = "*.pdf|*.pdf";
            imprimir.Title = "Guardar MMC en formato PDF";
            imprimir.FileName = this.asunto.Text;

            imprimir.ShowDialog();

            //var welcomeParagraph = new ParamArrayAttribute();

            var welcomeParagraph = new Paragraph();
            // Crear una instancia del Documento
            var document = new Document(PageSize.A4, 50, 50, 25, 25);

            // Crear una instancia de PdfWriter, especificando la cadena de salida
            var Output = new FileStream(Path.GetFullPath(imprimir.FileName), FileMode.Create);
            var writer = PdfWriter.GetInstance(document, Output);

            // Abrir el Documento
            document.Open();
            
            // Agregar elementos
            welcomeParagraph.Add(this.facilidad.Text);
            welcomeParagraph.Add(" " + this.canal.Text);
            welcomeParagraph.Add(" " + this.autenticar.Text);
            welcomeParagraph.Add(" " + this.autenticado.Text);
            welcomeParagraph.Add(" " + this.instransmision.Text);
            welcomeParagraph.Add(" " + this.clasiseguridad.Text);
            welcomeParagraph.Add(" " + this.precedencia.Text);
            welcomeParagraph.Add(" " + this.nrocontrol.Text);
            welcomeParagraph.Add(" " + this.clickgfh.Text);
            welcomeParagraph.Add(" " + this.promotor.Text);
            welcomeParagraph.Add(" " + this.ejecutivo.Text);
            welcomeParagraph.Add(" " + this.informativo.Text);
            welcomeParagraph.Add(" " + this.exceptuado.Text);
            welcomeParagraph.Add(" " + this.asunto.Text);
            welcomeParagraph.Add(" " + this.grupo.Text);
            welcomeParagraph.Add(" " + this.texto.Text);
            welcomeParagraph.Add(" " + this.transmitio.Text);
            welcomeParagraph.Add(" " + this.gfhtransmitio.Text);

            document.Add(welcomeParagraph);

            // Cerrar el documento
            document.Close();
        }
    }
}
