using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lacosRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num, res;

            num = int.Parse(txtNum.Text);

            res = num * 1;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            res = num * 2;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            res = num * 3;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            res = num * 4;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            res = num * 5;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            res = num * 6;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            res = num * 7;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            res = num * 8;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            res = num * 9;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            res = num * 10;
            lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num, res;
            int cont=1;

            num = int.Parse(txtNum.Text);

            while (cont<=10)
            {
                res = num * cont;
                lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
                cont++;//Adicionando 1 ao contador
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num, res;
            int cont = 1;

            num = int.Parse(txtNum.Text);

            do
            {
                res = num * cont;
                lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
                cont++;//Adicionando 1 ao contador
            } while (cont <= 10);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num, res;
            int cont;

            num = int.Parse(txtNum.Text);

            for(cont=1;cont<=10;cont++)
            {
                res = num * cont;
                lstTabuada.Items.Add(res.ToString());//Inserindo um valor a list box
            } 
        }
    }
}
