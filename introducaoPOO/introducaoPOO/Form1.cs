using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introducaoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Instanciar um objeto da classe Usuario
            Usuario user = new Usuario(txtNome.Text, txtEMail.Text, txtLogin.Text, txtSenha.Text);

            //Executando o método
            user.provarExistencia();
        }
    }
}
