using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mediaFrequencia
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, media, freq;
            int assistidas, totalAulas;

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            assistidas = int.Parse(txtAssistidas.Text);
            totalAulas = int.Parse(txtTotalAulas.Text);

            media = (n1 + n2) / 2;
            freq = ((double)assistidas / (double)totalAulas) * 100;

            if(media>=7 && freq >= 75)
            {
                lblRes.ForeColor = Color.Blue;
                lblRes.Text=$"Média: {media.ToString("0.00")}\nFrequência: {freq.ToString("0.00")}%\nAprovado";
            }
            else
            {
                lblRes.ForeColor = Color.Red;
                lblRes.Text = $"Média: {media.ToString("0.00")}\nFrequência: {freq.ToString("0.00")}%\nReprovado";
            }
        }
    }
}
