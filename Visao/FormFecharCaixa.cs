using Projeto_Pizzaria_das_Couves.Controle;
using Projeto_Pizzaria_das_Couves.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pizzaria_das_Couves.Visao
{
    public partial class FormFecharCaixa : Form
    {
        public FormFecharCaixa()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (txbIdLoginFechar.Text == "" || txbValorFinal.Text == "")
            {

                MessageBox.Show("Os campos são Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show("O Campo de Nome é Obrigatorio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Txt_Nome.Focus();
            }
            else
            {

                FecharCaixa fechar= new FecharCaixa(int.Parse(txbIdLoginFechar.Text), double.Parse(txbValorFinal.Text));
                ControleFecharCaixa fc = new ControleFecharCaixa();
                string mensagem = fc.AdicionarFecharCaixa(fechar);

                MessageBox.Show(mensagem);
                LimparCamposFecharCaixa();
                this.Close();
            }

            //FormBemVindo BvC = new FormBemVindo();
            //BvC.ShowDialog();

           // PreencherListView();
            
        }
        public void LimparCamposFecharCaixa()
        {
            txbIdLoginFechar.Text = String.Empty;
            txbValorFinal.Text = String.Empty;
        }

        private void LblIdUsuarioFC_Click(object sender, EventArgs e)
        {

        }
    }
}
