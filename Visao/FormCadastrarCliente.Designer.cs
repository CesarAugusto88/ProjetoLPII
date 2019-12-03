namespace Projeto_Pizzaria_das_Couves.Visao
{
    partial class FormCadastrarCliente
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
            this.lblNomeC = new System.Windows.Forms.Label();
            this.lblCpfC = new System.Windows.Forms.Label();
            this.lblRgC = new System.Windows.Forms.Label();
            this.lblCelC = new System.Windows.Forms.Label();
            this.lblGenC = new System.Windows.Forms.Label();
            this.lblLograC = new System.Windows.Forms.Label();
            this.lblNumC = new System.Windows.Forms.Label();
            this.lblCompC = new System.Windows.Forms.Label();
            this.lblBairroC = new System.Windows.Forms.Label();
            this.lblEmailC = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.txbNomeC = new System.Windows.Forms.TextBox();
            this.txbCpfC = new System.Windows.Forms.TextBox();
            this.txbRgC = new System.Windows.Forms.TextBox();
            this.txbCelC = new System.Windows.Forms.TextBox();
            this.txbGeneroC = new System.Windows.Forms.TextBox();
            this.txbEmailC = new System.Windows.Forms.TextBox();
            this.txbBairroC = new System.Windows.Forms.TextBox();
            this.txbCompC = new System.Windows.Forms.TextBox();
            this.txbNumC = new System.Windows.Forms.TextBox();
            this.txbLograC = new System.Windows.Forms.TextBox();
            this.listVclientes = new System.Windows.Forms.ListView();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.btnDeletarCliente = new System.Windows.Forms.Button();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.celular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logradouro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeC.Location = new System.Drawing.Point(67, 57);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(79, 29);
            this.lblNomeC.TabIndex = 0;
            this.lblNomeC.Text = "Nome";
            // 
            // lblCpfC
            // 
            this.lblCpfC.AutoSize = true;
            this.lblCpfC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfC.Location = new System.Drawing.Point(85, 110);
            this.lblCpfC.Name = "lblCpfC";
            this.lblCpfC.Size = new System.Drawing.Size(61, 29);
            this.lblCpfC.TabIndex = 1;
            this.lblCpfC.Text = "CPF";
            // 
            // lblRgC
            // 
            this.lblRgC.AutoSize = true;
            this.lblRgC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgC.Location = new System.Drawing.Point(98, 161);
            this.lblRgC.Name = "lblRgC";
            this.lblRgC.Size = new System.Drawing.Size(48, 29);
            this.lblRgC.TabIndex = 2;
            this.lblRgC.Text = "RG";
            // 
            // lblCelC
            // 
            this.lblCelC.AutoSize = true;
            this.lblCelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelC.Location = new System.Drawing.Point(56, 214);
            this.lblCelC.Name = "lblCelC";
            this.lblCelC.Size = new System.Drawing.Size(90, 29);
            this.lblCelC.TabIndex = 3;
            this.lblCelC.Text = "Celular";
            // 
            // lblGenC
            // 
            this.lblGenC.AutoSize = true;
            this.lblGenC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenC.Location = new System.Drawing.Point(52, 265);
            this.lblGenC.Name = "lblGenC";
            this.lblGenC.Size = new System.Drawing.Size(94, 29);
            this.lblGenC.TabIndex = 4;
            this.lblGenC.Text = "Genero";
            // 
            // lblLograC
            // 
            this.lblLograC.AutoSize = true;
            this.lblLograC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLograC.Location = new System.Drawing.Point(453, 59);
            this.lblLograC.Name = "lblLograC";
            this.lblLograC.Size = new System.Drawing.Size(138, 29);
            this.lblLograC.TabIndex = 5;
            this.lblLograC.Text = "Logradouro";
            this.lblLograC.Click += new System.EventHandler(this.LblLograC_Click);
            // 
            // lblNumC
            // 
            this.lblNumC.AutoSize = true;
            this.lblNumC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumC.Location = new System.Drawing.Point(491, 110);
            this.lblNumC.Name = "lblNumC";
            this.lblNumC.Size = new System.Drawing.Size(100, 29);
            this.lblNumC.TabIndex = 6;
            this.lblNumC.Text = "Número";
            this.lblNumC.Click += new System.EventHandler(this.LblNumC_Click);
            // 
            // lblCompC
            // 
            this.lblCompC.AutoSize = true;
            this.lblCompC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompC.Location = new System.Drawing.Point(426, 159);
            this.lblCompC.Name = "lblCompC";
            this.lblCompC.Size = new System.Drawing.Size(165, 29);
            this.lblCompC.TabIndex = 7;
            this.lblCompC.Text = "Complemento";
            // 
            // lblBairroC
            // 
            this.lblBairroC.AutoSize = true;
            this.lblBairroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroC.Location = new System.Drawing.Point(513, 214);
            this.lblBairroC.Name = "lblBairroC";
            this.lblBairroC.Size = new System.Drawing.Size(78, 29);
            this.lblBairroC.TabIndex = 8;
            this.lblBairroC.Text = "Bairro";
            // 
            // lblEmailC
            // 
            this.lblEmailC.AutoSize = true;
            this.lblEmailC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailC.Location = new System.Drawing.Point(64, 316);
            this.lblEmailC.Name = "lblEmailC";
            this.lblEmailC.Size = new System.Drawing.Size(82, 29);
            this.lblEmailC.TabIndex = 9;
            this.lblEmailC.Text = "E-mail";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(597, 255);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(214, 45);
            this.btnCadastrarCliente.TabIndex = 10;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrarCliente_Click);
            // 
            // txbNomeC
            // 
            this.txbNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeC.Location = new System.Drawing.Point(152, 58);
            this.txbNomeC.Name = "txbNomeC";
            this.txbNomeC.Size = new System.Drawing.Size(249, 29);
            this.txbNomeC.TabIndex = 11;
            // 
            // txbCpfC
            // 
            this.txbCpfC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpfC.Location = new System.Drawing.Point(152, 111);
            this.txbCpfC.Name = "txbCpfC";
            this.txbCpfC.Size = new System.Drawing.Size(249, 29);
            this.txbCpfC.TabIndex = 13;
            // 
            // txbRgC
            // 
            this.txbRgC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRgC.Location = new System.Drawing.Point(152, 161);
            this.txbRgC.Name = "txbRgC";
            this.txbRgC.Size = new System.Drawing.Size(249, 29);
            this.txbRgC.TabIndex = 14;
            // 
            // txbCelC
            // 
            this.txbCelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCelC.Location = new System.Drawing.Point(152, 214);
            this.txbCelC.Name = "txbCelC";
            this.txbCelC.Size = new System.Drawing.Size(249, 29);
            this.txbCelC.TabIndex = 15;
            // 
            // txbGeneroC
            // 
            this.txbGeneroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGeneroC.Location = new System.Drawing.Point(152, 265);
            this.txbGeneroC.Name = "txbGeneroC";
            this.txbGeneroC.Size = new System.Drawing.Size(249, 29);
            this.txbGeneroC.TabIndex = 16;
            // 
            // txbEmailC
            // 
            this.txbEmailC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailC.Location = new System.Drawing.Point(152, 316);
            this.txbEmailC.Name = "txbEmailC";
            this.txbEmailC.Size = new System.Drawing.Size(249, 29);
            this.txbEmailC.TabIndex = 17;
            // 
            // txbBairroC
            // 
            this.txbBairroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBairroC.Location = new System.Drawing.Point(597, 214);
            this.txbBairroC.Name = "txbBairroC";
            this.txbBairroC.Size = new System.Drawing.Size(249, 29);
            this.txbBairroC.TabIndex = 18;
            // 
            // txbCompC
            // 
            this.txbCompC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCompC.Location = new System.Drawing.Point(597, 160);
            this.txbCompC.Name = "txbCompC";
            this.txbCompC.Size = new System.Drawing.Size(249, 29);
            this.txbCompC.TabIndex = 19;
            // 
            // txbNumC
            // 
            this.txbNumC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumC.Location = new System.Drawing.Point(597, 111);
            this.txbNumC.Name = "txbNumC";
            this.txbNumC.Size = new System.Drawing.Size(249, 29);
            this.txbNumC.TabIndex = 20;
            this.txbNumC.TextChanged += new System.EventHandler(this.TextBox10_TextChanged);
            // 
            // txbLograC
            // 
            this.txbLograC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLograC.Location = new System.Drawing.Point(597, 58);
            this.txbLograC.Name = "txbLograC";
            this.txbLograC.Size = new System.Drawing.Size(249, 29);
            this.txbLograC.TabIndex = 21;
            this.txbLograC.TextChanged += new System.EventHandler(this.TextBox11_TextChanged);
            // 
            // listVclientes
            // 
            this.listVclientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.celular,
            this.logradouro,
            this.numero,
            this.bairro});
            this.listVclientes.HideSelection = false;
            this.listVclientes.Location = new System.Drawing.Point(117, 410);
            this.listVclientes.Name = "listVclientes";
            this.listVclientes.Size = new System.Drawing.Size(694, 141);
            this.listVclientes.TabIndex = 22;
            this.listVclientes.UseCompatibleStateImageBehavior = false;
            this.listVclientes.View = System.Windows.Forms.View.Details;
            this.listVclientes.SelectedIndexChanged += new System.EventHandler(this.ListVclientes_SelectedIndexChanged);
            // 
            // btnEditarC
            // 
            this.btnEditarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarC.Location = new System.Drawing.Point(597, 308);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(214, 45);
            this.btnEditarC.TabIndex = 23;
            this.btnEditarC.Text = "Editar Cliente";
            this.btnEditarC.UseVisualStyleBackColor = true;
            // 
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarCliente.Location = new System.Drawing.Point(597, 359);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(214, 45);
            this.btnDeletarCliente.TabIndex = 24;
            this.btnDeletarCliente.Text = "Deletar Cliente";
            this.btnDeletarCliente.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 29;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 164;
            // 
            // celular
            // 
            this.celular.Text = "Celular";
            this.celular.Width = 106;
            // 
            // logradouro
            // 
            this.logradouro.Text = "Rua";
            this.logradouro.Width = 109;
            // 
            // numero
            // 
            this.numero.Text = "Numero";
            this.numero.Width = 53;
            // 
            // bairro
            // 
            this.bairro.Text = "Bairro";
            this.bairro.Width = 184;
            // 
            // FormCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 576);
            this.Controls.Add(this.btnDeletarCliente);
            this.Controls.Add(this.btnEditarC);
            this.Controls.Add(this.listVclientes);
            this.Controls.Add(this.txbLograC);
            this.Controls.Add(this.txbNumC);
            this.Controls.Add(this.txbCompC);
            this.Controls.Add(this.txbBairroC);
            this.Controls.Add(this.txbEmailC);
            this.Controls.Add(this.txbGeneroC);
            this.Controls.Add(this.txbCelC);
            this.Controls.Add(this.txbRgC);
            this.Controls.Add(this.txbCpfC);
            this.Controls.Add(this.txbNomeC);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.lblEmailC);
            this.Controls.Add(this.lblBairroC);
            this.Controls.Add(this.lblCompC);
            this.Controls.Add(this.lblNumC);
            this.Controls.Add(this.lblLograC);
            this.Controls.Add(this.lblGenC);
            this.Controls.Add(this.lblCelC);
            this.Controls.Add(this.lblRgC);
            this.Controls.Add(this.lblCpfC);
            this.Controls.Add(this.lblNomeC);
            this.Name = "FormCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarCliente";
            this.Load += new System.EventHandler(this.FormCadastrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.Label lblCpfC;
        private System.Windows.Forms.Label lblRgC;
        private System.Windows.Forms.Label lblCelC;
        private System.Windows.Forms.Label lblGenC;
        private System.Windows.Forms.Label lblLograC;
        private System.Windows.Forms.Label lblNumC;
        private System.Windows.Forms.Label lblCompC;
        private System.Windows.Forms.Label lblBairroC;
        private System.Windows.Forms.Label lblEmailC;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.TextBox txbNomeC;
        private System.Windows.Forms.TextBox txbCpfC;
        private System.Windows.Forms.TextBox txbRgC;
        private System.Windows.Forms.TextBox txbCelC;
        private System.Windows.Forms.TextBox txbGeneroC;
        private System.Windows.Forms.TextBox txbEmailC;
        private System.Windows.Forms.TextBox txbBairroC;
        private System.Windows.Forms.TextBox txbCompC;
        private System.Windows.Forms.TextBox txbNumC;
        private System.Windows.Forms.TextBox txbLograC;
        private System.Windows.Forms.ListView listVclientes;
        private System.Windows.Forms.Button btnEditarC;
        private System.Windows.Forms.Button btnDeletarCliente;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader celular;
        private System.Windows.Forms.ColumnHeader logradouro;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader bairro;
    }
}