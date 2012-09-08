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
    public partial class TestRibbon : Form
    {
        public TestRibbon()
        {
            InitializeComponent();
        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.ShowDialog();
        }
    }
}
