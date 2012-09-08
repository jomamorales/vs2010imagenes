using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Helpers;
using OpenPop;

namespace MyProject
{
    public partial class Recibido : Form
    {
        public Recibido()
        {
            InitializeComponent();
        }

        private void recibir_Load(object sender, EventArgs e)
        {
            Helpers.Mailer mailer = new Helpers.Mailer();
            OpenPop.Mime.Message[] mensajes = mailer.recibir();
                        
            int i = 0, j = 0;
            OpenPop.Mime.Message mensaje = mensajes[i];
            this.dataGridView1.Rows.AddCopy(i);
            DataGridViewRow fila = this.dataGridView1.Rows[i];

            if (i < mensajes.Length)
            {
                //Realizar una busqueda del primer valor para hacer un ciclo
                string ver = mensaje.Headers.UnknownHeaders.AllKeys[i];
                
                while ((i < mensajes.Length) && (ver != "facilidad" ))
                {
                    i++;
                    ver = mensaje.Headers.UnknownHeaders.AllKeys[i];
                }

                //Verificar el resultado de la búsqueda
                if (ver == "facilidad")
                { 
                    string var = mensaje.Headers.UnknownHeaders[(i)].ToString();
                    if (var != "")
                    {
                        j = i;
                        string atributo;

                        fila.Cells[0].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[1].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[6].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[7].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[4].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[8].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[5].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;

                        atributo = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[9].Value = atributo;
                        fila.Cells[20].Value = atributo;

                        fila.Cells[10].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[11].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[12].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[13].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[14].Value = mensaje.Headers.UnknownHeaders[(j)].ToString(); j = j + 2;

                        atributo = mensaje.Headers.UnknownHeaders[(j)].ToString(); j++;
                        fila.Cells[15].Value = atributo;
                        fila.Cells[19].Value = atributo;

                        fila.Cells[16].Value = mensaje.Headers.UnknownHeaders[(j)].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Hay Mensajes para Descargar");
                    }
                }
            }
        }

        private void ver_Click(object sender, EventArgs e)
        {
            //Instancio el formulario de leida de entrada
            int i = 0;
       ///*  
            Helpers.Mailer mailer = new Helpers.Mailer();
            OpenPop.Mime.Message[] mensajes = mailer.recibir();
            OpenPop.Mime.Message mensaje = mensajes[i];
         //*/

            DataGridViewRow fila = this.dataGridView1.Rows[i];
            
            MensajeRecibido form = new MensajeRecibido();

            form.Controls[0].Text = fila.Cells[0].Value.ToString();
           /* 
            form.Controls["facilidad"].Text = mensaje.Headers.UnknownHeaders[(2)].ToString();
            form.Controls["canal"].Text = mensaje.Headers.UnknownHeaders[(3)].ToString();
            form.Controls["nroregistro"].Text = mensaje.Headers.UnknownHeaders[(4)].ToString(); 
            form.Controls["instransmision"].Text = mensaje.Headers.UnknownHeaders[(5)].ToString(); 
            form.Controls["clasiseg"].Text = mensaje.Headers.UnknownHeaders[(6)].ToString();
            form.Controls["precedencia"].Text = mensaje.Headers.UnknownHeaders[(7)].ToString();
            form.Controls["nrocontrol"].Text = mensaje.Headers.UnknownHeaders[(8)].ToString();
            form.Controls["gfh"].Text = mensaje.Headers.UnknownHeaders[(9)].ToString();
            form.Controls["promotor"].Text = mensaje.Headers.UnknownHeaders[(10)].ToString();
            form.Controls["ejecutivo"].Text = mensaje.Headers.UnknownHeaders[(11)].ToString();
            form.Controls["informativo"].Text = mensaje.Headers.UnknownHeaders[(12)].ToString();
            form.Controls["exceptuado"].Text = mensaje.Headers.UnknownHeaders[(13)].ToString();
            form.Controls["grupos"].Text = mensaje.Headers.UnknownHeaders[(14)].ToString();
            form.Controls["texto"].Text = mensaje.Headers.UnknownHeaders[(15)].ToString();
            form.Controls["transmitio"].Text = mensaje.Headers.UnknownHeaders[(16)].ToString();
            form.Controls["transmitioGFH"].Text = mensaje.Headers.UnknownHeaders[(17)].ToString();
            form.Controls["recibioGFH"].Text = DateTime.Now.ToString("dhhmmMMMyy").ToUpper();
            */
            form.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}