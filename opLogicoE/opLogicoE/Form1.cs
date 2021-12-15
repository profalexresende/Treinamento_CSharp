using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opLogicoE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtUsuario.Text.ToUpper();
            senha = txtSenha.Text.ToUpper();

            if (login == "ADMINISTRADOR" && senha == "123")
            {
                MessageBox.Show("Bem vindo Administrador");
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha inválidos");
            }
        }
    }
}
