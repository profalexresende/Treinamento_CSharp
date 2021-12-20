using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace introducaoPOO
{
    public class Usuario
    {
        //Atributos
        public string nome { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        //CONSTRUTOR
        //Método que é executado quando um objeto é instanciado.
        public Usuario()
        {
            this.nome = "";
            this.email = "";
            this.login = "";
            this.senha = "";
        }

        public Usuario(string nome, string email, string login, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.login = login;
            this.senha = senha;
        }

        public void provarExistencia()
        {
            MessageBox.Show($"Bem vindo {this.nome}");
        }
    }
}
