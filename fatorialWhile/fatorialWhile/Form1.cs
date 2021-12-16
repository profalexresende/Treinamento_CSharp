using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatorialWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            int num, fat=1;

            num = int.Parse(txtNum.Text);

            while (num > 1)
            {
                fat = fat * num;
                num--;
            }
            lblFatorial.Text = fat.ToString();
        }
    }
}
