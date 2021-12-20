using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace operacoesComVetores
{
    public partial class Form1 : Form
    {

        //DECLARAR O ARRAY
        string[] cores = { "branco","amarelo", "verde", "preto", "laranja" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu vetor tem capacidade para {cores.Length.ToString()} elementos");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            Array.Sort(cores);
            for(int i = 0; i < cores.Length; i++)
            {
                lstResultado.Items.Add(cores[i].ToString());
            }
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            Array.Reverse(cores);
            for (int i = 0; i < cores.Length; i++)
            {
                lstResultado.Items.Add(cores[i].ToString());
            }
        }

        private void btnIndice_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();

            string busca = Interaction.InputBox("Digite uma cor");
            int resultado =Array.IndexOf(cores, busca);
            MessageBox.Show($"O índice onde o elemento está é o {resultado.ToString()}");
        }

        private void btnBuscaBinaria_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            Array.Sort(cores);
            object corEscolhida = Interaction.InputBox("Digite uma cor");
            int indice = Array.BinarySearch(cores, corEscolhida);
            if (indice >= 0)
            {
                MessageBox.Show($"Achei o elemento no índice {indice.ToString()}");
            }
            else
            {
                MessageBox.Show("Não encontrei este elemento.");
            }
        }
    }
}
