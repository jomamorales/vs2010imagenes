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


namespace Helpers
{
    public class Cargador
    {
        Form formulario = new Form();
        OpenPop.Pop3.Pop3Client cliente = new OpenPop.Pop3.Pop3Client();

        public Cargador()
        {
           
        }

        public void carga(Form formulario, OpenPop.Pop3.Pop3Client cliente) 
        {
            formulario.Controls["promotor"].Text = cliente.GetMessage(1).Headers.To.ToString();
        }
    }
}
