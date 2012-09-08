using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using OpenPop;

namespace Helpers
{
    public class Agregadora
    {

        public Agregadora()
        {
        }

        public void agregar(Form formulario, DataGridView celda)
        {
            celda.Rows.Add(formulario.Controls["facilidad"].Text,
                formulario.Controls["canal"].Text,
                formulario.Controls["nroregistro"].Text,
                formulario.Controls[" "].Text,
                formulario.Controls[" "].Text,
                formulario.Controls["instransmision"].Text,
                formulario.Controls["clasiseguridad"].Text,
                formulario.Controls["procedencia"].Text,
                formulario.Controls["nrocontrol"].Text,
                formulario.Controls["clickgfh"].Text,
                formulario.Controls["promotor"].Text,
                formulario.Controls["informado"].Text,
                formulario.Controls["ejecutivo"].Text,
                formulario.Controls["exceptuado"].Text,
                formulario.Controls["grupo"].Text,
                formulario.Controls["entradatraficogfh"].Text,
                formulario.Controls["transmitió"].Text,
                formulario.Controls["gfhtrahsmitio"].Text,
                formulario.Controls["entregadodestinogfh"].Text,
                formulario.Controls[" "].Text,
                formulario.Controls[" "].Text,
                formulario.Controls["usuario"].Text,
                DateTime.Now.ToString("dhhmmMMMyy").ToUpper());
        }
    }
}

