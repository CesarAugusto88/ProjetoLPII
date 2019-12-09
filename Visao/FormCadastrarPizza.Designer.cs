namespace Projeto_Pizzaria_das_Couves.Visao
{
    partial class FormCadastrarPizza
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
            this.btnCadPizza = new System.Windows.Forms.Button();
            this.lblIng1 = new System.Windows.Forms.Label();
            this.txbIng1 = new System.Windows.Forms.TextBox();
            this.lblIng2 = new System.Windows.Forms.Label();
            this.lblIng3 = new System.Windows.Forms.Label();
            this.lblIng4 = new System.Windows.Forms.Label();
            this.txbIng2 = new System.Windows.Forms.TextBox();
            this.txbIng3 = new System.Windows.Forms.TextBox();
            this.txbIng4 = new System.Windows.Forms.TextBox();
            this.lblValorP = new System.Windows.Forms.Label();
            this.txbValorP = new System.Windows.Forms.TextBox();
            this.txbNomePizza = new System.Windows.Forms.TextBox();
            this.lblNomePizza = new System.Windows.Forms.Label();
            this.listVpizzas = new System.Windows.Forms.ListView();
            this.clNomeP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clValorP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditarPizza = new System.Windows.Forms.Button();
            this.btnDeletarPizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadPizza
            // 
            this.btnCadPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadPizza.Location = new System.Drawing.Point(483, 186);
            this.btnCadPizza.Name = "btnCadPizza";
            this.btnCadPizza.Size = new System.Drawing.Size(191, 41);
            this.btnCadPizza.TabIndex = 0;
            this.btnCadPizza.Text = "Cadastrar Pizza";
            this.btnCadPizza.UseVisualStyleBackColor = true;
            this.btnCadPizza.Click += new System.EventHandler(this.BtnCadPizza_Click);
            // 
            // lblIng1
            // 
            this.lblIng1.AutoSize = true;
            this.lblIng1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng1.Location = new System.Drawing.Point(71, 97);
            this.lblIng1.Name = "lblIng1";
            this.lblIng1.Size = new System.Drawing.Size(154, 29);
            this.lblIng1.TabIndex = 1;
            this.lblIng1.Text = "Ingrediente 1";
            // 
            // txbIng1
            // 
            this.txbIng1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIng1.Location = new System.Drawing.Point(240, 97);
            this.txbIng1.Name = "txbIng1";
            this.txbIng1.Size = new System.Drawing.Size(219, 29);
            this.txbIng1.TabIndex = 2;
            // 
            // lblIng2
            // 
            this.lblIng2.AutoSize = true;
            this.lblIng2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng2.Location = new System.Drawing.Point(71, 147);
            this.lblIng2.Name = "lblIng2";
            this.lblIng2.Size = new System.Drawing.Size(154, 29);
            this.lblIng2.TabIndex = 3;
            this.lblIng2.Text = "Ingrediente 2";
            // 
            // lblIng3
            // 
            this.lblIng3.AutoSize = true;
            this.lblIng3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng3.Location = new System.Drawing.Point(71, 193);
            this.lblIng3.Name = "lblIng3";
            this.lblIng3.Size = new System.Drawing.Size(154, 29);
            this.lblIng3.TabIndex = 4;
            this.lblIng3.Text = "Ingrediente 3";
            // 
            // lblIng4
            // 
            this.lblIng4.AutoSize = true;
            this.lblIng4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng4.Location = new System.Drawing.Point(71, 240);
            this.lblIng4.Name = "lblIng4";
            this.lblIng4.Size = new System.Drawing.Size(154, 29);
            this.lblIng4.TabIndex = 5;
            this.lblIng4.Text = "Ingrediente 4";
            this.lblIng4.Click += new System.EventHandler(this.LblIng4_Click);
            // 
            // txbIng2
            // 
            this.txbIng2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIng2.Location = new System.Drawing.Point(240, 147);
            this.txbIng2.Name = "txbIng2";
            this.txbIng2.Size = new System.Drawing.Size(219, 29);
            this.txbIng2.TabIndex = 6;
            // 
            // txbIng3
            // 
            this.txbIng3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIng3.Location = new System.Drawing.Point(240, 193);
            this.txbIng3.Name = "txbIng3";
            this.txbIng3.Size = new System.Drawing.Size(219, 29);
            this.txbIng3.TabIndex = 7;
            // 
            // txbIng4
            // 
            this.txbIng4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIng4.Location = new System.Drawing.Point(240, 240);
            this.txbIng4.Name = "txbIng4";
            this.txbIng4.Size = new System.Drawing.Size(219, 29);
            this.txbIng4.TabIndex = 8;
            // 
            // lblValorP
            // 
            this.lblValorP.AutoSize = true;
            this.lblValorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorP.Location = new System.Drawing.Point(120, 286);
            this.lblValorP.Name = "lblValorP";
            this.lblValorP.Size = new System.Drawing.Size(105, 29);
            this.lblValorP.TabIndex = 9;
            this.lblValorP.Text = "Valor R$";
            // 
            // txbValorP
            // 
            this.txbValorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorP.Location = new System.Drawing.Point(240, 286);
            this.txbValorP.Name = "txbValorP";
            this.txbValorP.Size = new System.Drawing.Size(219, 29);
            this.txbValorP.TabIndex = 10;
            // 
            // txbNomePizza
            // 
            this.txbNomePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomePizza.Location = new System.Drawing.Point(240, 47);
            this.txbNomePizza.Name = "txbNomePizza";
            this.txbNomePizza.Size = new System.Drawing.Size(219, 29);
            this.txbNomePizza.TabIndex = 12;
            // 
            // lblNomePizza
            // 
            this.lblNomePizza.AutoSize = true;
            this.lblNomePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePizza.Location = new System.Drawing.Point(50, 47);
            this.lblNomePizza.Name = "lblNomePizza";
            this.lblNomePizza.Size = new System.Drawing.Size(175, 29);
            this.lblNomePizza.TabIndex = 11;
            this.lblNomePizza.Text = "Nome da Pizza";
            // 
            // listVpizzas
            // 
            this.listVpizzas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNomeP,
            this.clValorP});
            this.listVpizzas.HideSelection = false;
            this.listVpizzas.Location = new System.Drawing.Point(230, 357);
            this.listVpizzas.Name = "listVpizzas";
            this.listVpizzas.Size = new System.Drawing.Size(339, 175);
            this.listVpizzas.TabIndex = 13;
            this.listVpizzas.UseCompatibleStateImageBehavior = false;
            this.listVpizzas.View = System.Windows.Forms.View.Details;
            this.listVpizzas.SelectedIndexChanged += new System.EventHandler(this.ListVpizzas_SelectedIndexChanged);
            // 
            // clNomeP
            // 
            this.clNomeP.Text = "Nome";
            this.clNomeP.Width = 170;
            // 
            // clValorP
            // 
            this.clValorP.Text = "Valor";
            // 
            // btnEditarPizza
            // 
            this.btnEditarPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPizza.Location = new System.Drawing.Point(541, 233);
            this.btnEditarPizza.Name = "btnEditarPizza";
            this.btnEditarPizza.Size = new System.Drawing.Size(191, 41);
            this.btnEditarPizza.TabIndex = 14;
            this.btnEditarPizza.Text = "Editar Pizza";
            this.btnEditarPizza.UseVisualStyleBackColor = true;
            // 
            // btnDeletarPizza
            // 
            this.btnDeletarPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarPizza.Location = new System.Drawing.Point(603, 280);
            this.btnDeletarPizza.Name = "btnDeletarPizza";
            this.btnDeletarPizza.Size = new System.Drawing.Size(191, 41);
            this.btnDeletarPizza.TabIndex = 15;
            this.btnDeletarPizza.Text = "Deletar Pizza";
            this.btnDeletarPizza.UseVisualStyleBackColor = true;
            // 
            // FormCadastrarPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 569);
            this.Controls.Add(this.btnDeletarPizza);
            this.Controls.Add(this.btnEditarPizza);
            this.Controls.Add(this.listVpizzas);
            this.Controls.Add(this.txbNomePizza);
            this.Controls.Add(this.lblNomePizza);
            this.Controls.Add(this.txbValorP);
            this.Controls.Add(this.lblValorP);
            this.Controls.Add(this.txbIng4);
            this.Controls.Add(this.txbIng3);
            this.Controls.Add(this.txbIng2);
            this.Controls.Add(this.lblIng4);
            this.Controls.Add(this.lblIng3);
            this.Controls.Add(this.lblIng2);
            this.Controls.Add(this.txbIng1);
            this.Controls.Add(this.lblIng1);
            this.Controls.Add(this.btnCadPizza);
            this.Name = "FormCadastrarPizza";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarPizza";
            this.Load += new System.EventHandler(this.FormCadastrarPizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadPizza;
        private System.Windows.Forms.Label lblIng1;
        private System.Windows.Forms.TextBox txbIng1;
        private System.Windows.Forms.Label lblIng2;
        private System.Windows.Forms.Label lblIng3;
        private System.Windows.Forms.Label lblIng4;
        private System.Windows.Forms.TextBox txbIng2;
        private System.Windows.Forms.TextBox txbIng3;
        private System.Windows.Forms.TextBox txbIng4;
        private System.Windows.Forms.Label lblValorP;
        private System.Windows.Forms.TextBox txbValorP;
        private System.Windows.Forms.TextBox txbNomePizza;
        private System.Windows.Forms.Label lblNomePizza;
        private System.Windows.Forms.ListView listVpizzas;
        private System.Windows.Forms.Button btnEditarPizza;
        private System.Windows.Forms.Button btnDeletarPizza;
        private System.Windows.Forms.ColumnHeader clNomeP;
        private System.Windows.Forms.ColumnHeader clValorP;
    }
}