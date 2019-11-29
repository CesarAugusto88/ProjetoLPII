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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {            
            btnAbrirCaixa.Visible = false;
            btnFecharCaixa.Visible = false;
            btnCadastrarPizza.Visible = false;
            btnCadastrarFuncionario.Visible = false;
            btnCadastrarCliente.Visible = false;
            btnCadastrarPizza.Visible = false;
            btnFazerPedido.Visible = false;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {// fazer igual form cadastrar cliente ok. No cabeçalho tem q ter todas as pastas (.controle, .modelo, .visao)

            //ver os txb do funcionario em FormCadastrarFuncionario.Designer.cs
            Funcionario funcionario = new Funcionario();// (colocar os txb...)
            ControleFuncionario ff = new ControleFuncionario();
            string mensagem = ff.AdicionarFuncionario(funcionario); //Chama o método que realiza a inserção no banco.

            //MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ControleLogin controle = new ControleLogin();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            // loginDAO.mensagem.Equals("") não funciona
            if (controle.mensagem == "")
            {
                // verifica se na classe controle se verdadeiro
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormBemVindo WC = new FormBemVindo();
                    WC.ShowDialog();
                   // somente botão de abrir caixa e sair...
                    lblLogin.Visible = false;
                    lblSenha.Visible = false;
                    btnEntrar.Visible = false;
                    btnSair.Visible = false;
                    txbLogin.Visible = false;
                    txbSenha.Visible = false;
                    btnAbrirCaixa.Visible = true;
                    btnSair.Visible = true;
                    btnCadastrarCliente.Visible = true;
                    btnCadastrarFuncionario.Visible = true;
                    btnCadastrarPizza.Visible = true;
                    btnFazerPedido.Visible = true;
                    btnFecharCaixa.Visible = true;


                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastrarFuncionario Func = new FormCadastrarFuncionario();
            Func.ShowDialog();
        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            ControleCliente cc = new ControleCliente();
            string mensagem = cc.AdicionarCliente(cliente); //Chama o método que realiza a inserção no banco.

            MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //MessageBox.Show(mensagem);
            LimpaTextoCliente();


            //FormBemVindo BvC = new FormBemVindo();
            //BvC.ShowDialog();
            //PreencherListView();
        }

        // Não está reconhecendo os txb... nem no objeto.
        public void LimpaTextoCliente()
        {
           // txbNomeC.Text = "";
           // txbCpfC.Text = "";
           // txbRgC.Text = "";
           // txbGeneroC.Text = "";
           // txbCelularC.Text = "";
           // txbEmailC.Text = "";
           // txbLograC.Text = "";
           // txbNumeroC.Text = "";
           // txbCompC.Text = "";
           // txbBairroC.Text = "";
        }

        private void BtnAbrirCaixa_Click(object sender, EventArgs e)
        {
            FormAbrirCaixa AC = new FormAbrirCaixa();
            AC.ShowDialog();
        }

        private void BtnFecharCaixa_Click(object sender, EventArgs e)
        {
            FormFecharCaixa FC = new FormFecharCaixa();
            FC.ShowDialog();
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
