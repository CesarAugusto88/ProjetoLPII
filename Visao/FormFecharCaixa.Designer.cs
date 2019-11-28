namespace Projeto_Pizzaria_das_Couves.Visao
{
    partial class FormFecharCaixa
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
            this.txbIdLoginFechar = new System.Windows.Forms.TextBox();
            this.txbValorFinal = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblIdUsuarioFC = new System.Windows.Forms.Label();
            this.lblValorFinalFC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbIdLoginFechar
            // 
            this.txbIdLoginFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdLoginFechar.Location = new System.Drawing.Point(181, 71);
            this.txbIdLoginFechar.Name = "txbIdLoginFechar";
            this.txbIdLoginFechar.Size = new System.Drawing.Size(201, 29);
            this.txbIdLoginFechar.TabIndex = 0;
            // 
            // txbValorFinal
            // 
            this.txbValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorFinal.Location = new System.Drawing.Point(181, 123);
            this.txbValorFinal.Name = "txbValorFinal";
            this.txbValorFinal.Size = new System.Drawing.Size(201, 29);
            this.txbValorFinal.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(470, 273);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(107, 42);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lblIdUsuarioFC
            // 
            this.lblIdUsuarioFC.AutoSize = true;
            this.lblIdUsuarioFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuarioFC.Location = new System.Drawing.Point(47, 71);
            this.lblIdUsuarioFC.Name = "lblIdUsuarioFC";
            this.lblIdUsuarioFC.Size = new System.Drawing.Size(99, 29);
            this.lblIdUsuarioFC.TabIndex = 3;
            this.lblIdUsuarioFC.Text = "Id Login";
            this.lblIdUsuarioFC.Click += new System.EventHandler(this.LblIdUsuarioFC_Click);
            // 
            // lblValorFinalFC
            // 
            this.lblValorFinalFC.AutoSize = true;
            this.lblValorFinalFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinalFC.Location = new System.Drawing.Point(47, 123);
            this.lblValorFinalFC.Name = "lblValorFinalFC";
            this.lblValorFinalFC.Size = new System.Drawing.Size(128, 29);
            this.lblValorFinalFC.TabIndex = 4;
            this.lblValorFinalFC.Text = "Valor Final";
            // 
            // FormFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 327);
            this.Controls.Add(this.lblValorFinalFC);
            this.Controls.Add(this.lblIdUsuarioFC);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txbValorFinal);
            this.Controls.Add(this.txbIdLoginFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFecharCaixa";
            this.Text = "FormFecharCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIdLoginFechar;
        private System.Windows.Forms.TextBox txbValorFinal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblIdUsuarioFC;
        private System.Windows.Forms.Label lblValorFinalFC;
    }
}