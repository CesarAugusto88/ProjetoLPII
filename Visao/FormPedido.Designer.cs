namespace Projeto_Pizzaria_das_Couves.Visao
{
    partial class FormPedido
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
            this.listBpedidos = new System.Windows.Forms.ListBox();
            this.listVpizzasPedido = new System.Windows.Forms.ListView();
            this.clNomePizzaP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clValorPizzaP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listVclientesPedido = new System.Windows.Forms.ListView();
            this.clIdCliPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNomeCliPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCelPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLograCliPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCliPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCliBairroPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeletarPedido = new System.Windows.Forms.Button();
            this.lblPedidosCadastrados = new System.Windows.Forms.Label();
            this.lblPizzas = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.listVpedidos = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPizza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clvalorpizzaentrega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCadastrarPedido = new System.Windows.Forms.Button();
            this.btnEditarPedido = new System.Windows.Forms.Button();
            this.txbValorentregaPedido = new System.Windows.Forms.TextBox();
            this.lblValorentregaPedido = new System.Windows.Forms.Label();
            this.txbValorpizzaPedido = new System.Windows.Forms.TextBox();
            this.lblValorpizzaPedido = new System.Windows.Forms.Label();
            this.txbNomepizzaPedido = new System.Windows.Forms.TextBox();
            this.lblNomepizzaPedido = new System.Windows.Forms.Label();
            this.txbIdCpedido = new System.Windows.Forms.TextBox();
            this.lblIdclientePedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBpedidos
            // 
            this.listBpedidos.DisplayMember = "Id";
            this.listBpedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBpedidos.FormattingEnabled = true;
            this.listBpedidos.Location = new System.Drawing.Point(686, 334);
            this.listBpedidos.Name = "listBpedidos";
            this.listBpedidos.Size = new System.Drawing.Size(31, 147);
            this.listBpedidos.TabIndex = 38;
            this.listBpedidos.ValueMember = "Id";
            // 
            // listVpizzasPedido
            // 
            this.listVpizzasPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNomePizzaP,
            this.clValorPizzaP});
            this.listVpizzasPedido.HideSelection = false;
            this.listVpizzasPedido.Location = new System.Drawing.Point(442, 308);
            this.listVpizzasPedido.Name = "listVpizzasPedido";
            this.listVpizzasPedido.Size = new System.Drawing.Size(207, 173);
            this.listVpizzasPedido.TabIndex = 37;
            this.listVpizzasPedido.UseCompatibleStateImageBehavior = false;
            this.listVpizzasPedido.View = System.Windows.Forms.View.Details;
            // 
            // clNomePizzaP
            // 
            this.clNomePizzaP.Text = "Nome";
            this.clNomePizzaP.Width = 128;
            // 
            // clValorPizzaP
            // 
            this.clValorPizzaP.Text = "Valor";
            // 
            // listVclientesPedido
            // 
            this.listVclientesPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clIdCliPedido,
            this.clNomeCliPedido,
            this.clCelPedido,
            this.clLograCliPedido,
            this.clCliPedido,
            this.clCliBairroPedido});
            this.listVclientesPedido.HideSelection = false;
            this.listVclientesPedido.Location = new System.Drawing.Point(40, 308);
            this.listVclientesPedido.Name = "listVclientesPedido";
            this.listVclientesPedido.Size = new System.Drawing.Size(370, 173);
            this.listVclientesPedido.TabIndex = 36;
            this.listVclientesPedido.UseCompatibleStateImageBehavior = false;
            this.listVclientesPedido.View = System.Windows.Forms.View.Details;
            // 
            // clIdCliPedido
            // 
            this.clIdCliPedido.Text = "Id Cliente";
            this.clIdCliPedido.Width = 57;
            // 
            // clNomeCliPedido
            // 
            this.clNomeCliPedido.Text = "Nome";
            this.clNomeCliPedido.Width = 80;
            // 
            // clCelPedido
            // 
            this.clCelPedido.Text = "Celular";
            this.clCelPedido.Width = 45;
            // 
            // clLograCliPedido
            // 
            this.clLograCliPedido.Text = "Rua";
            this.clLograCliPedido.Width = 61;
            // 
            // clCliPedido
            // 
            this.clCliPedido.Text = "Nº";
            this.clCliPedido.Width = 26;
            // 
            // clCliBairroPedido
            // 
            this.clCliBairroPedido.Text = "Bairro";
            this.clCliBairroPedido.Width = 97;
            // 
            // btnDeletarPedido
            // 
            this.btnDeletarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarPedido.Location = new System.Drawing.Point(759, 194);
            this.btnDeletarPedido.Name = "btnDeletarPedido";
            this.btnDeletarPedido.Size = new System.Drawing.Size(187, 44);
            this.btnDeletarPedido.TabIndex = 35;
            this.btnDeletarPedido.Text = "Deletar Pedido";
            this.btnDeletarPedido.UseVisualStyleBackColor = true;
            this.btnDeletarPedido.Click += new System.EventHandler(this.BtnDeletarPedido_Click_1);
            // 
            // lblPedidosCadastrados
            // 
            this.lblPedidosCadastrados.AutoSize = true;
            this.lblPedidosCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosCadastrados.Location = new System.Drawing.Point(714, 276);
            this.lblPedidosCadastrados.Name = "lblPedidosCadastrados";
            this.lblPedidosCadastrados.Size = new System.Drawing.Size(245, 29);
            this.lblPedidosCadastrados.TabIndex = 34;
            this.lblPedidosCadastrados.Text = "Pedidos Cadastrados";
            // 
            // lblPizzas
            // 
            this.lblPizzas.AutoSize = true;
            this.lblPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzas.Location = new System.Drawing.Point(508, 274);
            this.lblPizzas.Name = "lblPizzas";
            this.lblPizzas.Size = new System.Drawing.Size(82, 29);
            this.lblPizzas.TabIndex = 33;
            this.lblPizzas.Text = "Pizzas";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(168, 274);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(101, 29);
            this.lblClientes.TabIndex = 32;
            this.lblClientes.Text = "Clientes";
            // 
            // listVpedidos
            // 
            this.listVpedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.clPizza,
            this.clvalorpizzaentrega});
            this.listVpedidos.HideSelection = false;
            this.listVpedidos.Location = new System.Drawing.Point(715, 308);
            this.listVpedidos.Name = "listVpedidos";
            this.listVpedidos.Size = new System.Drawing.Size(244, 173);
            this.listVpedidos.TabIndex = 31;
            this.listVpedidos.UseCompatibleStateImageBehavior = false;
            this.listVpedidos.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 24;
            // 
            // clPizza
            // 
            this.clPizza.Text = "Pizza";
            this.clPizza.Width = 75;
            // 
            // clvalorpizzaentrega
            // 
            this.clvalorpizzaentrega.Text = "Valor total";
            this.clvalorpizzaentrega.Width = 65;
            // 
            // btnCadastrarPedido
            // 
            this.btnCadastrarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPedido.Location = new System.Drawing.Point(597, 94);
            this.btnCadastrarPedido.Name = "btnCadastrarPedido";
            this.btnCadastrarPedido.Size = new System.Drawing.Size(209, 44);
            this.btnCadastrarPedido.TabIndex = 30;
            this.btnCadastrarPedido.Text = "Cadastrar Pedido";
            this.btnCadastrarPedido.UseVisualStyleBackColor = true;
            this.btnCadastrarPedido.Click += new System.EventHandler(this.BtnCadastrarPedido_Click);
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPedido.Location = new System.Drawing.Point(686, 144);
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(187, 44);
            this.btnEditarPedido.TabIndex = 29;
            this.btnEditarPedido.Text = "Editar Pedido";
            this.btnEditarPedido.UseVisualStyleBackColor = true;
            // 
            // txbValorentregaPedido
            // 
            this.txbValorentregaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorentregaPedido.Location = new System.Drawing.Point(233, 217);
            this.txbValorentregaPedido.Name = "txbValorentregaPedido";
            this.txbValorentregaPedido.Size = new System.Drawing.Size(339, 29);
            this.txbValorentregaPedido.TabIndex = 28;
            // 
            // lblValorentregaPedido
            // 
            this.lblValorentregaPedido.AutoSize = true;
            this.lblValorentregaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorentregaPedido.Location = new System.Drawing.Point(35, 217);
            this.lblValorentregaPedido.Name = "lblValorentregaPedido";
            this.lblValorentregaPedido.Size = new System.Drawing.Size(192, 29);
            this.lblValorentregaPedido.TabIndex = 27;
            this.lblValorentregaPedido.Text = "Valor da Entrega";
            // 
            // txbValorpizzaPedido
            // 
            this.txbValorpizzaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorpizzaPedido.Location = new System.Drawing.Point(233, 172);
            this.txbValorpizzaPedido.Name = "txbValorpizzaPedido";
            this.txbValorpizzaPedido.Size = new System.Drawing.Size(339, 29);
            this.txbValorpizzaPedido.TabIndex = 26;
            // 
            // lblValorpizzaPedido
            // 
            this.lblValorpizzaPedido.AutoSize = true;
            this.lblValorpizzaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorpizzaPedido.Location = new System.Drawing.Point(62, 172);
            this.lblValorpizzaPedido.Name = "lblValorpizzaPedido";
            this.lblValorpizzaPedido.Size = new System.Drawing.Size(165, 29);
            this.lblValorpizzaPedido.TabIndex = 25;
            this.lblValorpizzaPedido.Text = "Valor da Pizza";
            // 
            // txbNomepizzaPedido
            // 
            this.txbNomepizzaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomepizzaPedido.Location = new System.Drawing.Point(233, 128);
            this.txbNomepizzaPedido.Name = "txbNomepizzaPedido";
            this.txbNomepizzaPedido.Size = new System.Drawing.Size(339, 29);
            this.txbNomepizzaPedido.TabIndex = 24;
            // 
            // lblNomepizzaPedido
            // 
            this.lblNomepizzaPedido.AutoSize = true;
            this.lblNomepizzaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomepizzaPedido.Location = new System.Drawing.Point(157, 127);
            this.lblNomepizzaPedido.Name = "lblNomepizzaPedido";
            this.lblNomepizzaPedido.Size = new System.Drawing.Size(70, 29);
            this.lblNomepizzaPedido.TabIndex = 23;
            this.lblNomepizzaPedido.Text = "Pizza";
            // 
            // txbIdCpedido
            // 
            this.txbIdCpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdCpedido.Location = new System.Drawing.Point(233, 84);
            this.txbIdCpedido.Name = "txbIdCpedido";
            this.txbIdCpedido.Size = new System.Drawing.Size(339, 29);
            this.txbIdCpedido.TabIndex = 22;
            // 
            // lblIdclientePedido
            // 
            this.lblIdclientePedido.AutoSize = true;
            this.lblIdclientePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdclientePedido.Location = new System.Drawing.Point(78, 84);
            this.lblIdclientePedido.Name = "lblIdclientePedido";
            this.lblIdclientePedido.Size = new System.Drawing.Size(149, 29);
            this.lblIdclientePedido.TabIndex = 21;
            this.lblIdclientePedido.Text = "Id do Cliente";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 565);
            this.Controls.Add(this.listBpedidos);
            this.Controls.Add(this.listVpizzasPedido);
            this.Controls.Add(this.listVclientesPedido);
            this.Controls.Add(this.btnDeletarPedido);
            this.Controls.Add(this.lblPedidosCadastrados);
            this.Controls.Add(this.lblPizzas);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.listVpedidos);
            this.Controls.Add(this.btnCadastrarPedido);
            this.Controls.Add(this.btnEditarPedido);
            this.Controls.Add(this.txbValorentregaPedido);
            this.Controls.Add(this.lblValorentregaPedido);
            this.Controls.Add(this.txbValorpizzaPedido);
            this.Controls.Add(this.lblValorpizzaPedido);
            this.Controls.Add(this.txbNomepizzaPedido);
            this.Controls.Add(this.lblNomepizzaPedido);
            this.Controls.Add(this.txbIdCpedido);
            this.Controls.Add(this.lblIdclientePedido);
            this.Name = "FormPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedido";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBpedidos;
        private System.Windows.Forms.ListView listVpizzasPedido;
        private System.Windows.Forms.ColumnHeader clNomePizzaP;
        private System.Windows.Forms.ColumnHeader clValorPizzaP;
        private System.Windows.Forms.ListView listVclientesPedido;
        private System.Windows.Forms.ColumnHeader clIdCliPedido;
        private System.Windows.Forms.ColumnHeader clNomeCliPedido;
        private System.Windows.Forms.ColumnHeader clCelPedido;
        private System.Windows.Forms.ColumnHeader clLograCliPedido;
        private System.Windows.Forms.ColumnHeader clCliPedido;
        private System.Windows.Forms.ColumnHeader clCliBairroPedido;
        private System.Windows.Forms.Button btnDeletarPedido;
        private System.Windows.Forms.Label lblPedidosCadastrados;
        private System.Windows.Forms.Label lblPizzas;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ListView listVpedidos;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader clPizza;
        private System.Windows.Forms.ColumnHeader clvalorpizzaentrega;
        private System.Windows.Forms.Button btnCadastrarPedido;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.TextBox txbValorentregaPedido;
        private System.Windows.Forms.Label lblValorentregaPedido;
        private System.Windows.Forms.TextBox txbValorpizzaPedido;
        private System.Windows.Forms.Label lblValorpizzaPedido;
        private System.Windows.Forms.TextBox txbNomepizzaPedido;
        private System.Windows.Forms.Label lblNomepizzaPedido;
        private System.Windows.Forms.TextBox txbIdCpedido;
        private System.Windows.Forms.Label lblIdclientePedido;
    }
}