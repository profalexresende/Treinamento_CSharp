
namespace doacaoDolar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoacao = new System.Windows.Forms.TextBox();
            this.txtCotacaoDolar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Doação:";
            // 
            // txtDoacao
            // 
            this.txtDoacao.Location = new System.Drawing.Point(13, 32);
            this.txtDoacao.Name = "txtDoacao";
            this.txtDoacao.Size = new System.Drawing.Size(95, 23);
            this.txtDoacao.TabIndex = 1;
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.Location = new System.Drawing.Point(131, 32);
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(105, 23);
            this.txtCotacaoDolar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cotação do Dólar:";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(13, 75);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(220, 25);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter para R$";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 122);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(38, 15);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 160);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtCotacaoDolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoacao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoacao;
        private System.Windows.Forms.TextBox txtCotacaoDolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
    }
}

