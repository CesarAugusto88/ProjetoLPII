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
    public partial class FormAbrirCaixa : Form
    {
        public FormAbrirCaixa()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (txbIdLoginAbrir.Text == "" || txbValorInicial.Text == "")
            {

                MessageBox.Show("Os campos são Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show("O Campo de Nome é Obrigatorio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Txt_Nome.Focus();
            }
            else
            {

                AbrirCaixa abrir = new AbrirCaixa(int.Parse(txbIdLoginAbrir.Text), double.Parse(txbValorInicial.Text));
                ControleAbrirCaixa ac = new ControleAbrirCaixa();
                string mensagem = ac.AdicionarAbrirCaixa(abrir);

                MessageBox.Show(mensagem);
                LimparCamposAbrirCaixa();
                this.Close();
            }

            //FormBemVindo BvC = new FormBemVindo();
            //BvC.ShowDialog();

            // PreencherListView();

        }
        public void LimparCamposAbrirCaixa()
        {
            txbIdLoginAbrir.Text = String.Empty;
            txbValorInicial.Text = String.Empty;
        }

        private void FormAbrirCaixa_Load(object sender, EventArgs e)
        {
            //btnFecharCaixa.Visible = true;
            //btnCadastrarCliente.Visible = true;
            //btnCadastrarFuncionario.Visible = true;

            

        }
    }
}
