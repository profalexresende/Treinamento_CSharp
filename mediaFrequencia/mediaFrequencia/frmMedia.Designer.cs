
namespace mediaFrequencia
{
    partial class frmMedia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalAulas = new System.Windows.Forms.TextBox();
            this.txtAssistidas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite suas duas notas:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(13, 32);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(54, 23);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(86, 32);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(54, 23);
            this.txtN2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total de aulas:";
            // 
            // txtTotalAulas
            // 
            this.txtTotalAulas.Location = new System.Drawing.Point(165, 32);
            this.txtTotalAulas.Name = "txtTotalAulas";
            this.txtTotalAulas.Size = new System.Drawing.Size(54, 23);
            this.txtTotalAulas.TabIndex = 4;
            // 
            // txtAssistidas
            // 
            this.txtAssistidas.Location = new System.Drawing.Point(252, 32);
            this.txtAssistidas.Name = "txtAssistidas";
            this.txtAssistidas.Size = new System.Drawing.Size(54, 23);
            this.txtAssistidas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aulas assistidas:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(13, 73);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(293, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRes.Location = new System.Drawing.Point(13, 109);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(50, 20);
            this.lblRes.TabIndex = 8;
            this.lblRes.Text = "label4";
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 220);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAssistidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalAulas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "frmMedia";
            this.Text = "frmMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalAulas;
        private System.Windows.Forms.TextBox txtAssistidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblRes;
    }
}