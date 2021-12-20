
namespace inverterVetor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInverter = new System.Windows.Forms.Button();
            this.lstVetorB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(49, 12);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(204, 23);
            this.btnInverter.TabIndex = 0;
            this.btnInverter.Text = "Ler e Inverter";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // lstVetorB
            // 
            this.lstVetorB.FormattingEnabled = true;
            this.lstVetorB.Location = new System.Drawing.Point(92, 55);
            this.lstVetorB.Name = "lstVetorB";
            this.lstVetorB.Size = new System.Drawing.Size(120, 95);
            this.lstVetorB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 178);
            this.Controls.Add(this.lstVetorB);
            this.Controls.Add(this.btnInverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.ListBox lstVetorB;
    }
}

