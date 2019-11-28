namespace Projeto_Pizzaria_das_Couves.Visao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.btnCadastrarPizza = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzaria das Couves";
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerPedido.Location = new System.Drawing.Point(106, 322);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(232, 40);
            this.btnFazerPedido.TabIndex = 1;
            this.btnFazerPedido.Text = "Fazer Pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPizza
            // 
            this.btnCadastrarPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPizza.Location = new System.Drawing.Point(107, 276);
            this.btnCadastrarPizza.Name = "btnCadastrarPizza";
            this.btnCadastrarPizza.Size = new System.Drawing.Size(231, 40);
            this.btnCadastrarPizza.TabIndex = 2;
            this.btnCadastrarPizza.Text = "Cadastrar Pizza";
            this.btnCadastrarPizza.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(108, 230);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(230, 40);
            this.btnCadastrarCliente.TabIndex = 3;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrarCliente_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(108, 184);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(230, 40);
            this.btnCadastrarFuncionario.TabIndex = 4;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.BtnCadastrarFuncionario_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.Location = new System.Drawing.Point(108, 135);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(230, 40);
            this.btnAbrirCaixa.TabIndex = 5;
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.BtnAbrirCaixa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(443, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 41);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(443, 281);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(150, 41);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCaixa.Location = new System.Drawing.Point(443, 375);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(150, 41);
            this.btnFecharCaixa.TabIndex = 8;
            this.btnFecharCaixa.Text = "Fechar Caixa";
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.BtnFecharCaixa_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(108, 368);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(230, 41);
            this.btnEstoque.TabIndex = 9;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // txbLogin
            // 
            this.txbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.Location = new System.Drawing.Point(525, 188);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(199, 29);
            this.txbLogin.TabIndex = 10;
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(525, 233);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(199, 29);
            this.txbSenha.TabIndex = 11;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(427, 188);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 29);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(427, 233);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(82, 29);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnFecharCaixa);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAbrirCaixa);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnCadastrarPizza);
            this.Controls.Add(this.btnFazerPedido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.Button btnCadastrarPizza;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
    }
}