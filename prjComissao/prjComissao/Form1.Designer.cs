
namespace prjComissao
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
            this.btnComissao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComissao
            // 
            this.btnComissao.Location = new System.Drawing.Point(62, 122);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(149, 23);
            this.btnComissao.TabIndex = 0;
            this.btnComissao.Text = "Calcular Comissão";
            this.btnComissao.UseVisualStyleBackColor = true;
            this.btnComissao.Click += new System.EventHandler(this.btnComissao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Vendedor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(257, 23);
            this.txtNome.TabIndex = 2;
            // 
            // txtSBase
            // 
            this.txtSBase.Location = new System.Drawing.Point(13, 77);
            this.txtSBase.Name = "txtSBase";
            this.txtSBase.Size = new System.Drawing.Size(98, 23);
            this.txtSBase.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salário Base:";
            // 
            // txtVendas
            // 
            this.txtVendas.Location = new System.Drawing.Point(172, 76);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(98, 23);
            this.txtVendas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total em vendas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 157);
            this.Controls.Add(this.txtVendas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComissao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.Label label3;
    }
}

