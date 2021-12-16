using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (rdbFem.Checked==true)
            {
                MessageBox.Show("Selecionado sexo feminino");
            }
            else
            {
                MessageBox.Show("Selecionado sexo masculino");
            }
        }
    }
}
