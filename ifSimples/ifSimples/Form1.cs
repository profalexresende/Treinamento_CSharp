using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte idade;

            idade = byte.Parse(txtIdade.Text);
            //idade = Convert.ToByte(txtIdade.Text);

            if (idade>=12)
            {
                MessageBox.Show("Você pode jogar!!!", "Jogo - Drogas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            /*OPERADORES RELACIONAIS
             * == compara igualdade
             * > maior que
             * < menor que
             * >= maior ou igual a 
             * <= menor ou igual a
             * != diferente
             */
        }
    }
}
