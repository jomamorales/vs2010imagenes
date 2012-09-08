using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using OpenPop;
using Helpers;
using iTextSharp;

namespace Helpers
{
    public class Mailer
    {
        public Mailer()
        {

        }
        
        public bool enviar(Form Formulario){
            
            if ((Formulario.Controls["promotor"].Text == "") || (Formulario.Controls["ejecutivo"].Text == ""))
            {
                MessageBox.Show("Los Campos PROMOTOR o EJECUTIVO No pueden estar en BLANCO");
                return false;
            }
            else
            {
                //MessageBox.Show(Formulario.Controls["facilidad"].Text);
                MailMessage mensaje = new MailMessage(
                    Formulario.Controls["promotor"].Text,
                    //Envia
                    //"adminsitm@sitm.mil.ar",
                    //Recibe
                    //"tdbairesc@sitm.mil.ar"
                    Formulario.Controls["ejecutivo"].Text
                    //"test@xeta.com.ar",
                    // "emgesitm@gmail.com",
                    // "emgesitm@gmail.com"
                    );
            //Asignacion de lo que se envía
            //mensaje.Bcc = "aca va el mail de auditoria";
            //mensaje.CC = Formulario.Controls["informativo"].Text;
                //"acouorejercito@sitm.mil.ar";
            mensaje.Body = Formulario.Controls["texto"].Text;
            //mensaje.Subject = Formulario.Controls["canal"].Text;
                //"Prueba de Envio de MMC";
            
            //metadata en el header
            //problema: SOLO PASA LA KEY => el valor (parametro no sirve de nada) y no se pueden poner espacios
            mensaje.Headers.Add("facilidad", Formulario.Controls["facilidad"].Text); 
            mensaje.Headers.Add("canal", Formulario.Controls["canal"].Text); 
            mensaje.Headers.Add("NR", Formulario.Controls["nroregistro"].Text);
            mensaje.Headers.Add("instransmision", Formulario.Controls["instransmision"].Text); 
            mensaje.Headers.Add("clasiseguridad", Formulario.Controls["clasiseguridad"].Text); 
            mensaje.Headers.Add("precedencia", Formulario.Controls["precedencia"].Text);
            mensaje.Headers.Add("nrocontrol", Formulario.Controls["nrocontrol"].Text);
            mensaje.Headers.Add("clickgfh", Formulario.Controls["clickgfh"].Text);
            mensaje.Headers.Add("promotor", Formulario.Controls["promotor"].Text);
            mensaje.Headers.Add("ejecutivo", Formulario.Controls["ejecutivo"].Text);
            mensaje.Headers.Add("informativo", Formulario.Controls["informativo"].Text);
            mensaje.Headers.Add("exceptuado", Formulario.Controls["exceptuado"].Text);
            mensaje.Headers.Add("grupo", Formulario.Controls["grupo"].Text);
            mensaje.Headers.Add("texto", Formulario.Controls["texto"].Text);
            mensaje.Headers.Add("transmitio", Formulario.Controls["transmitio"].Text);
            mensaje.Headers.Add("gfhtrahsmitio", Formulario.Controls["gfhtrahsmitio"].Text);
            
            SmtpClient client = new SmtpClient();
            /* Mail de Pruebas
            client.Credentials = new System.Net.NetworkCredential("test@xeta.com.ar", "test712as");
            client.Host = "mail.xeta.com.ar";
            client.Port = 26;
            */
            /* Mail de Gmail de Pruebas
            client.Credentials = new System.Net.NetworkCredential("emgesitm@gmail.com", "sitmemge");
            client.Host = "smtp.googlemail.com";
            client.Port = 587;
            client.EnableSsl = true;
            */

            //IP Servidor maquina virtual   
            //"sitmadmin@sitm.mil.ar", "redise"

            client.Credentials = new System.Net.NetworkCredential(Formulario.Controls["promotor"].Text, "redise");
            //client.Credentials = new System.Net.NetworkCredential("adminsitm@genesis.sitm.mil.ar", "redise");
            //client.Credentials = new System.Net.NetworkCredential("tdbairesc@genesis.sitm.mil.ar", "redise");
            //client.Credentials = new System.Net.NetworkCredential("tdemgea@genesis.sitm.mil.ar", "redise");
            //client.Credentials = new System.Net.NetworkCredential("jemge@genesis.sitm.mil.ar", "redise");
            //client.Credentials = new System.Net.NetworkCredential("dirgrlcominfo@genesis.sitm.mil.ar", "redise");
            //client.Credentials = new System.Net.NetworkCredential("cacomparac4c@pandora.sitm.mil.ar", "redise");
            //client.Host = "10.90.19.8";    
                
            client.Host = "10.90.19.5";
            client.Port = 25;

            try
            {
                client.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
            };    
        }

        public OpenPop.Mime.Message[] recibir()
        {
            OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client();

            /* Mail de Pruebas*/
            //client.Connect("mail.xeta.com.ar", 110, false);
            //client.Authenticate("test@xeta.com.ar", "test712as");

            /* Mail de Pruebas en Gmail */
            //client.Connect("pop.googlemail.com", 110, false);
            //client.Authenticate("emgesitm@gmail.com", "sitmemge");

            client.Connect("10.90.19.5", 110, false);
            client.Authenticate("tdbairesc@genesis.sitm.mil.ar", "redise");
//            client.Authenticate("tdemgea@genesis.sitm.mil.ar", "redise");
//            client.Authenticate("jemge@genesis.sitm.mil.ar", "redise");
//            client.Authenticate("dirgrlcominfo@genesis.sitm.mil.ar", "redise");
//            client.Authenticate("adminsitm@genesis.sitm.mil.ar", "redise");
//            client.Connect("10.90.19.8", 110, false);
//            client.Authenticate("cacomparac4c@pandora.sitm.mil.ar", "redise");

            int messageCount = client.GetMessageCount();
            OpenPop.Mime.Message[] allMessages = new OpenPop.Mime.Message[messageCount];
            /*
            if (messageCount == 0)
            {
                MessageBox.Show("No existen mensajes para descargar");
            }
            else
            {

                MessageBox.Show("mensajes recibidos", messageCount.ToString());
            };
            */
            Form formulario = new Form();
            
            if (client.Connected && messageCount > 0)
            {
                int i = 0;
                for (int j = messageCount; j > 0; j--)
                {
                    OpenPop.Mime.Message TEST = client.GetMessage(j);
                    allMessages[i] = TEST;
                    i++;
                }   
            }
            else {
                if (!(client.Connected))
                {
                    MessageBox.Show("No conectado");
                }
                else
                {
                    MessageBox.Show("No existen mensajes para descargar");
                }
            }
            return allMessages;
        }
    }
}