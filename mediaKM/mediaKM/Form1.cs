using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaKM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double kmInicial, kmFinal, litros,kmPercorrida,media;

            kmInicial = Convert.ToDouble(txtKmInicial.Text);
            kmFinal = Convert.ToDouble(txtKmFinal.Text);
            litros =double.Parse(txtLitros.Text);

            kmPercorrida = kmFinal - kmInicial;

            media = kmPercorrida / litros;

            //lblResposta.Text = "A autonomia deste veículo é de " + media.ToString("0.00") + " km por litro.";
            lblResposta.Text = $"A autonomia deste veículo é de {media.ToString("0.00")} km por litro.";
        }
    }
}
