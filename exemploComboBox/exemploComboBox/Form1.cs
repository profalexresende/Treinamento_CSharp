using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            switch (cmbEscolha.SelectedIndex)
            {
                case 0:
                    MessageBox.Show($"Você selecionou a Equipe {cmbEscolha.SelectedItem.ToString()}");
                    break;
                case 1:
                    MessageBox.Show("Você selecionou a Equipe Mercedes");
                    break;
                case 2:
                    MessageBox.Show("Você selecionou a Equipe RedBull");
                    break;
                case 3:
                    MessageBox.Show("Você selecionou a Equipe McLaren");
                    break;
                default:
                    MessageBox.Show("Selecione uma equipe");
                    break;
            }
        }
    }
}
