using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria_heranca
{
    class Livro : Produto
    {
        

        //ATRIBUTOS ESPECÍFICOS DA CLASSE LIVRO
        public string autor { get; set; }
        public string editora { get; set; }
        public string edicao { get; set; }

        //CONSTRUTORES
        public Livro(string autor,string editora, string edicao,string descricao, string genero, 
            int estoqueDisponivel, double precoCusto) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.autor = autor;
            this.editora = editora;
            this.edicao = edicao;
        }

        public Livro()
        {
            this.autor = "";
            this.editora = "";
            this.edicao = "";
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
        }

        public void listarProduto()
        {
            MessageBox.Show($"Dados do livro cadastrado\n\n" +
                $"Descrição: {this.descricao}\n" +
                $"Gênero: {this.genero}\n" +
                $"Estoque: {this.estoqueDisponivel.ToString()}\n" +
                $"Preço de Custo: {this.precoCusto:f2}\n" +
                $"Autor: {this.autor}\n" +
                $"Editora: {this.editora}\n" +
                $"Edição: {this.edicao}");
        }
    }
}
