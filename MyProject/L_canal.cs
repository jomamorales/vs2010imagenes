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
    public partial class L_canal : Form
    {
        public L_canal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Valores a agregar a la primer columna: "Estafeta", "HF", "Mixta", "Red de Datos", "UHF", "VHF"
            dataGridView1.Rows[1].Cells[1].Value = "hola";
        }
    }
}
