
namespace calculadoraPOO
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.cmbOperacao = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite dois números:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(13, 45);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(66, 23);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(85, 45);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(66, 23);
            this.txtN2.TabIndex = 2;
            // 
            // cmbOperacao
            // 
            this.cmbOperacao.FormattingEnabled = true;
            this.cmbOperacao.Items.AddRange(new object[] {
            "Soma",
            "Subtração",
            "Multiplicação",
            "Divisão"});
            this.cmbOperacao.Location = new System.Drawing.Point(13, 88);
            this.cmbOperacao.Name = "cmbOperacao";
            this.cmbOperacao.Size = new System.Drawing.Size(138, 23);
            this.cmbOperacao.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(13, 129);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(138, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(13, 172);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(38, 15);
            this.lblRes.TabIndex = 5;
            this.lblRes.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 211);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbOperacao);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.ComboBox cmbOperacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblRes;
    }
}

