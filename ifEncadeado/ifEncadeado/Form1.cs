using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifEncadeado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            byte idade;
            string mensagem;
            MessageBoxIcon teste;

            idade = byte.Parse(txtIdade.Text);

            if (idade < 16)
            {
                mensagem = "Você não pode votar e nem embarcar!";
                teste = MessageBoxIcon.Error;
            }
            else if (idade < 18)
            {
                mensagem = "Voto facultativo. Embarque permitido!";
                teste = MessageBoxIcon.Warning;
            }
            else
            {
                mensagem = "Voto obrigatório. Embarque permitido!";
                teste = MessageBoxIcon.Information;
            }
            MessageBox.Show(mensagem, "ONG",MessageBoxButtons.OK, teste);
        }
    }
}
