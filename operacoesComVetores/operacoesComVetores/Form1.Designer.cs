
namespace operacoesComVetores
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
            this.btnTamanho = new System.Windows.Forms.Button();
            this.btnIndice = new System.Windows.Forms.Button();
            this.btnBuscaBinaria = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTamanho
            // 
            this.btnTamanho.Location = new System.Drawing.Point(12, 23);
            this.btnTamanho.Name = "btnTamanho";
            this.btnTamanho.Size = new System.Drawing.Size(302, 23);
            this.btnTamanho.TabIndex = 0;
            this.btnTamanho.Text = "Tamanho do Array";
            this.btnTamanho.UseVisualStyleBackColor = true;
            this.btnTamanho.Click += new System.EventHandler(this.btnTamanho_Click);
            // 
            // btnIndice
            // 
            this.btnIndice.Location = new System.Drawing.Point(12, 139);
            this.btnIndice.Name = "btnIndice";
            this.btnIndice.Size = new System.Drawing.Size(302, 23);
            this.btnIndice.TabIndex = 1;
            this.btnIndice.Text = "Obtendo um índice";
            this.btnIndice.UseVisualStyleBackColor = true;
            this.btnIndice.Click += new System.EventHandler(this.btnIndice_Click);
            // 
            // btnBuscaBinaria
            // 
            this.btnBuscaBinaria.Location = new System.Drawing.Point(12, 110);
            this.btnBuscaBinaria.Name = "btnBuscaBinaria";
            this.btnBuscaBinaria.Size = new System.Drawing.Size(302, 23);
            this.btnBuscaBinaria.TabIndex = 2;
            this.btnBuscaBinaria.Text = "Busca Binária";
            this.btnBuscaBinaria.UseVisualStyleBackColor = true;
            this.btnBuscaBinaria.Click += new System.EventHandler(this.btnBuscaBinaria_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(12, 81);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(302, 23);
            this.btnInverter.TabIndex = 3;
            this.btnInverter.Text = "Inverter o Array";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(12, 52);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(302, 23);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar o Array";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(13, 169);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(301, 199);
            this.lstResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 390);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnBuscaBinaria);
            this.Controls.Add(this.btnIndice);
            this.Controls.Add(this.btnTamanho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTamanho;
        private System.Windows.Forms.Button btnIndice;
        private System.Windows.Forms.Button btnBuscaBinaria;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lstResultado;
    }
}

