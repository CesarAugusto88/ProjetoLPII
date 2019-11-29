namespace Projeto_Pizzaria_das_Couves.Visao
{
    partial class FormAbrirCaixa
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
            this.lblValorInicial = new System.Windows.Forms.Label();
            this.lblIdLogin = new System.Windows.Forms.Label();
            this.txbIdLoginAbrir = new System.Windows.Forms.TextBox();
            this.txbValorInicial = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.AutoSize = true;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicial.Location = new System.Drawing.Point(65, 153);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(137, 29);
            this.lblValorInicial.TabIndex = 0;
            this.lblValorInicial.Text = "Valor Inicial";
            // 
            // lblIdLogin
            // 
            this.lblIdLogin.AutoSize = true;
            this.lblIdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLogin.Location = new System.Drawing.Point(65, 83);
            this.lblIdLogin.Name = "lblIdLogin";
            this.lblIdLogin.Size = new System.Drawing.Size(99, 29);
            this.lblIdLogin.TabIndex = 1;
            this.lblIdLogin.Text = "Id Login";
            // 
            // txbIdLoginAbrir
            // 
            this.txbIdLoginAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdLoginAbrir.Location = new System.Drawing.Point(210, 83);
            this.txbIdLoginAbrir.Name = "txbIdLoginAbrir";
            this.txbIdLoginAbrir.Size = new System.Drawing.Size(160, 29);
            this.txbIdLoginAbrir.TabIndex = 2;
            // 
            // txbValorInicial
            // 
            this.txbValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorInicial.Location = new System.Drawing.Point(210, 153);
            this.txbValorInicial.Name = "txbValorInicial";
            this.txbValorInicial.Size = new System.Drawing.Size(160, 29);
            this.txbValorInicial.TabIndex = 3;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(473, 293);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(127, 43);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // FormAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 365);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txbValorInicial);
            this.Controls.Add(this.txbIdLoginAbrir);
            this.Controls.Add(this.lblIdLogin);
            this.Controls.Add(this.lblValorInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbrirCaixa";
            this.Text = "FormAbrirCaixa";
            this.Load += new System.EventHandler(this.FormAbrirCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorInicial;
        private System.Windows.Forms.Label lblIdLogin;
        private System.Windows.Forms.TextBox txbIdLoginAbrir;
        private System.Windows.Forms.TextBox txbValorInicial;
        private System.Windows.Forms.Button btnAbrir;
    }
}