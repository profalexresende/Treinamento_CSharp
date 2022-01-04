using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria_heranca
{
    class CD:Produto
    {
        public string artista { get; set; }
        public string gravadora { get; set; }
        public string paisOrigem { get; set; }

        public CD(string artista,string gravadora, string paisOrigem,string descricao, string genero, 
            int estoqueDisponivel, double precoCusto) 
            : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.artista = artista;
            this.gravadora = gravadora;
            this.paisOrigem = paisOrigem;
        }

        public CD()
        {
            this.artista = "";
            this.gravadora = "";
            this.paisOrigem = "";
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
        }

        public void listarProduto()
        {
            MessageBox.Show($"Dados do CD cadastrado\n\n" +
                $"Descrição: {this.descricao}\n" +
                $"Gênero: {this.genero}\n" +
                $"Estoque: {this.estoqueDisponivel.ToString()}\n" +
                $"Preço de Custo: {this.precoCusto:f2}\n" +
                $"Artista: {this.artista}\n" +
                $"Gravadora: {this.gravadora}\n" +
                $"País de Origem: {this.paisOrigem}");
        }
    }
}
