
namespace sobrecarga
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
            this.txtVHora = new System.Windows.Forms.TextBox();
            this.txtTotalHoras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da hora:";
            // 
            // txtVHora
            // 
            this.txtVHora.Location = new System.Drawing.Point(41, 28);
            this.txtVHora.Name = "txtVHora";
            this.txtVHora.Size = new System.Drawing.Size(100, 23);
            this.txtVHora.TabIndex = 1;
            // 
            // txtTotalHoras
            // 
            this.txtTotalHoras.Location = new System.Drawing.Point(41, 82);
            this.txtTotalHoras.Name = "txtTotalHoras";
            this.txtTotalHoras.Size = new System.Drawing.Size(100, 23);
            this.txtTotalHoras.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total de horas:";
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(41, 141);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 23);
            this.txtDolar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cotação dolar";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(41, 191);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 242);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalHoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVHora);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVHora;
        private System.Windows.Forms.TextBox txtTotalHoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
    }
}

