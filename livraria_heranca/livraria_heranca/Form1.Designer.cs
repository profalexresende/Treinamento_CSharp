
namespace livraria_heranca
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabPageLivro = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageCD = new System.Windows.Forms.TabPage();
            this.btnVenderCD = new System.Windows.Forms.Button();
            this.btnComprarCD = new System.Windows.Forms.Button();
            this.btnCadCD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.Label();
            this.txtGravadora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageDVD = new System.Windows.Forms.TabPage();
            this.btnVenderDVD = new System.Windows.Forms.Button();
            this.btnComprarDVD = new System.Windows.Forms.Button();
            this.btnCadDVD = new System.Windows.Forms.Button();
            this.txtCensura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCompraVenda = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnListarCD = new System.Windows.Forms.Button();
            this.ListarDVD = new System.Windows.Forms.Button();
            this.tabProdutos.SuspendLayout();
            this.tabPageLivro.SuspendLayout();
            this.tabPageCD.SuspendLayout();
            this.tabPageDVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do Produto:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(13, 32);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(294, 23);
            this.txtDesc.TabIndex = 1;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(13, 77);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(294, 23);
            this.txtGenero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gênero:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(12, 132);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(125, 23);
            this.txtEstoque.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtde em Estoque:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(182, 132);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(125, 23);
            this.txtPreco.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço:";
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabPageLivro);
            this.tabProdutos.Controls.Add(this.tabPageCD);
            this.tabProdutos.Controls.Add(this.tabPageDVD);
            this.tabProdutos.Location = new System.Drawing.Point(12, 204);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(318, 231);
            this.tabProdutos.TabIndex = 8;
            // 
            // tabPageLivro
            // 
            this.tabPageLivro.Controls.Add(this.btnListar);
            this.tabPageLivro.Controls.Add(this.btnVender);
            this.tabPageLivro.Controls.Add(this.btnComprar);
            this.tabPageLivro.Controls.Add(this.btnCadastrar);
            this.tabPageLivro.Controls.Add(this.txtEdicao);
            this.tabPageLivro.Controls.Add(this.label7);
            this.tabPageLivro.Controls.Add(this.txtEditora);
            this.tabPageLivro.Controls.Add(this.label6);
            this.tabPageLivro.Controls.Add(this.txtAutor);
            this.tabPageLivro.Controls.Add(this.label5);
            this.tabPageLivro.Location = new System.Drawing.Point(4, 24);
            this.tabPageLivro.Name = "tabPageLivro";
            this.tabPageLivro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLivro.Size = new System.Drawing.Size(310, 203);
            this.tabPageLivro.TabIndex = 0;
            this.tabPageLivro.Text = "Livro";
            this.tabPageLivro.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(232, 159);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(60, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(157, 159);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(60, 23);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(80, 159);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(61, 23);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(7, 159);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(67, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(7, 116);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(284, 23);
            this.txtEdicao.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Edição:";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(7, 71);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(284, 23);
            this.txtEditora.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Editora";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(7, 26);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(284, 23);
            this.txtAutor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Autor:";
            // 
            // tabPageCD
            // 
            this.tabPageCD.Controls.Add(this.btnListarCD);
            this.tabPageCD.Controls.Add(this.btnVenderCD);
            this.tabPageCD.Controls.Add(this.btnComprarCD);
            this.tabPageCD.Controls.Add(this.btnCadCD);
            this.tabPageCD.Controls.Add(this.textBox1);
            this.tabPageCD.Controls.Add(this.txtOrigem);
            this.tabPageCD.Controls.Add(this.txtGravadora);
            this.tabPageCD.Controls.Add(this.label9);
            this.tabPageCD.Controls.Add(this.txtArtista);
            this.tabPageCD.Controls.Add(this.label10);
            this.tabPageCD.Location = new System.Drawing.Point(4, 24);
            this.tabPageCD.Name = "tabPageCD";
            this.tabPageCD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCD.Size = new System.Drawing.Size(310, 203);
            this.tabPageCD.TabIndex = 1;
            this.tabPageCD.Text = "CD";
            this.tabPageCD.UseVisualStyleBackColor = true;
            // 
            // btnVenderCD
            // 
            this.btnVenderCD.Location = new System.Drawing.Point(166, 166);
            this.btnVenderCD.Name = "btnVenderCD";
            this.btnVenderCD.Size = new System.Drawing.Size(61, 23);
            this.btnVenderCD.TabIndex = 17;
            this.btnVenderCD.Text = "Vender";
            this.btnVenderCD.UseVisualStyleBackColor = true;
            this.btnVenderCD.Click += new System.EventHandler(this.btnVenderCD_Click);
            // 
            // btnComprarCD
            // 
            this.btnComprarCD.Location = new System.Drawing.Point(92, 166);
            this.btnComprarCD.Name = "btnComprarCD";
            this.btnComprarCD.Size = new System.Drawing.Size(68, 23);
            this.btnComprarCD.TabIndex = 16;
            this.btnComprarCD.Text = "Comprar";
            this.btnComprarCD.UseVisualStyleBackColor = true;
            this.btnComprarCD.Click += new System.EventHandler(this.btnComprarCD_Click);
            // 
            // btnCadCD
            // 
            this.btnCadCD.Location = new System.Drawing.Point(13, 166);
            this.btnCadCD.Name = "btnCadCD";
            this.btnCadCD.Size = new System.Drawing.Size(73, 23);
            this.btnCadCD.TabIndex = 15;
            this.btnCadCD.Text = "Cadastrar";
            this.btnCadCD.UseVisualStyleBackColor = true;
            this.btnCadCD.Click += new System.EventHandler(this.btnCadCD_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 23);
            this.textBox1.TabIndex = 14;
            // 
            // txtOrigem
            // 
            this.txtOrigem.AutoSize = true;
            this.txtOrigem.Location = new System.Drawing.Point(13, 104);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(90, 15);
            this.txtOrigem.TabIndex = 13;
            this.txtOrigem.Text = "País de Origem:";
            // 
            // txtGravadora
            // 
            this.txtGravadora.Location = new System.Drawing.Point(13, 78);
            this.txtGravadora.Name = "txtGravadora";
            this.txtGravadora.Size = new System.Drawing.Size(284, 23);
            this.txtGravadora.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Gravadora:";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(13, 33);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(284, 23);
            this.txtArtista.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Artista:";
            // 
            // tabPageDVD
            // 
            this.tabPageDVD.Controls.Add(this.ListarDVD);
            this.tabPageDVD.Controls.Add(this.btnVenderDVD);
            this.tabPageDVD.Controls.Add(this.btnComprarDVD);
            this.tabPageDVD.Controls.Add(this.btnCadDVD);
            this.tabPageDVD.Controls.Add(this.txtCensura);
            this.tabPageDVD.Controls.Add(this.label8);
            this.tabPageDVD.Controls.Add(this.txtDuracao);
            this.tabPageDVD.Controls.Add(this.label11);
            this.tabPageDVD.Controls.Add(this.txtDiretor);
            this.tabPageDVD.Controls.Add(this.label12);
            this.tabPageDVD.Location = new System.Drawing.Point(4, 24);
            this.tabPageDVD.Name = "tabPageDVD";
            this.tabPageDVD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDVD.Size = new System.Drawing.Size(310, 203);
            this.tabPageDVD.TabIndex = 2;
            this.tabPageDVD.Text = "DVD";
            this.tabPageDVD.UseVisualStyleBackColor = true;
            // 
            // btnVenderDVD
            // 
            this.btnVenderDVD.Location = new System.Drawing.Point(162, 166);
            this.btnVenderDVD.Name = "btnVenderDVD";
            this.btnVenderDVD.Size = new System.Drawing.Size(69, 23);
            this.btnVenderDVD.TabIndex = 26;
            this.btnVenderDVD.Text = "Vender";
            this.btnVenderDVD.UseVisualStyleBackColor = true;
            this.btnVenderDVD.Click += new System.EventHandler(this.btnVenderDVD_Click);
            // 
            // btnComprarDVD
            // 
            this.btnComprarDVD.Location = new System.Drawing.Point(89, 166);
            this.btnComprarDVD.Name = "btnComprarDVD";
            this.btnComprarDVD.Size = new System.Drawing.Size(67, 23);
            this.btnComprarDVD.TabIndex = 25;
            this.btnComprarDVD.Text = "Comprar";
            this.btnComprarDVD.UseVisualStyleBackColor = true;
            this.btnComprarDVD.Click += new System.EventHandler(this.btnComprarDVD_Click);
            // 
            // btnCadDVD
            // 
            this.btnCadDVD.Location = new System.Drawing.Point(13, 166);
            this.btnCadDVD.Name = "btnCadDVD";
            this.btnCadDVD.Size = new System.Drawing.Size(70, 23);
            this.btnCadDVD.TabIndex = 24;
            this.btnCadDVD.Text = "Cadastrar";
            this.btnCadDVD.UseVisualStyleBackColor = true;
            this.btnCadDVD.Click += new System.EventHandler(this.btnCadDVD_Click);
            // 
            // txtCensura
            // 
            this.txtCensura.Location = new System.Drawing.Point(13, 123);
            this.txtCensura.Name = "txtCensura";
            this.txtCensura.Size = new System.Drawing.Size(284, 23);
            this.txtCensura.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Censura:";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(13, 78);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(284, 23);
            this.txtDuracao.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Duração:";
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(13, 33);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(284, 23);
            this.txtDiretor.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Diretor:";
            // 
            // txtCompraVenda
            // 
            this.txtCompraVenda.Location = new System.Drawing.Point(12, 176);
            this.txtCompraVenda.Name = "txtCompraVenda";
            this.txtCompraVenda.Size = new System.Drawing.Size(125, 23);
            this.txtCompraVenda.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Qtde Compra ou Venda";
            // 
            // btnListarCD
            // 
            this.btnListarCD.Location = new System.Drawing.Point(233, 166);
            this.btnListarCD.Name = "btnListarCD";
            this.btnListarCD.Size = new System.Drawing.Size(61, 23);
            this.btnListarCD.TabIndex = 18;
            this.btnListarCD.Text = "Listar";
            this.btnListarCD.UseVisualStyleBackColor = true;
            this.btnListarCD.Click += new System.EventHandler(this.btnListarCD_Click);
            // 
            // ListarDVD
            // 
            this.ListarDVD.Location = new System.Drawing.Point(236, 166);
            this.ListarDVD.Name = "ListarDVD";
            this.ListarDVD.Size = new System.Drawing.Size(61, 23);
            this.ListarDVD.TabIndex = 27;
            this.ListarDVD.Text = "Listar";
            this.ListarDVD.UseVisualStyleBackColor = true;
            this.ListarDVD.Click += new System.EventHandler(this.ListarDVD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 447);
            this.Controls.Add(this.txtCompraVenda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabProdutos.ResumeLayout(false);
            this.tabPageLivro.ResumeLayout(false);
            this.tabPageLivro.PerformLayout();
            this.tabPageCD.ResumeLayout(false);
            this.tabPageCD.PerformLayout();
            this.tabPageDVD.ResumeLayout(false);
            this.tabPageDVD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabPageLivro;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageCD;
        private System.Windows.Forms.Button btnVenderCD;
        private System.Windows.Forms.Button btnComprarCD;
        private System.Windows.Forms.Button btnCadCD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtOrigem;
        private System.Windows.Forms.TextBox txtGravadora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPageDVD;
        private System.Windows.Forms.Button btnVenderDVD;
        private System.Windows.Forms.Button btnComprarDVD;
        private System.Windows.Forms.Button btnCadDVD;
        private System.Windows.Forms.TextBox txtCensura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCompraVenda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnListarCD;
        private System.Windows.Forms.Button ListarDVD;
    }
}

