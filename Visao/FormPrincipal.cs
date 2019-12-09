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
        {// a função só aceita os textboxs que estão no seu form. para aceitar outros deve
         // criar um objeto da clase do form para ver se da certo.
         // Criar uma verificação dos textboxs dos cadastros para Não deixar cadastrar qndo
         // os textboxs estiverem vazios
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
                    // somente botão de abrir caixa, sair fica no click do fechar caixa...
                    lblLogin.Visible = false;
                    lblSenha.Visible = false;
                    btnEntrar.Visible = false;
                    btnSair.Visible = false;
                    txbLogin.Visible = false;
                    txbSenha.Visible = false;
                    btnAbrirCaixa.Visible = true;
                    btnCadastrarCliente.Visible = true;
                    btnCadastrarFuncionario.Visible = true;
                    btnCadastrarPizza.Visible = true;
                    btnFazerPedido.Visible = false;
                    btnSair.Visible = true;

                    /*
                    
                    btnFecharCaixa.Visible = true;*/

                }
                else
                {// fazer para corrigir o login ou a senha, conforme reconhecido
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
            FormCadastrarCliente cadcli = new FormCadastrarCliente();
            cadcli.ShowDialog();
            
        }

       
        

        private void BtnAbrirCaixa_Click(object sender, EventArgs e)
        {
            FormAbrirCaixa AC = new FormAbrirCaixa();
            AC.ShowDialog();
            btnAbrirCaixa.Visible = false;
            btnCadastrarCliente.Visible = true;
            btnCadastrarFuncionario.Visible = true;
            btnCadastrarPizza.Visible = true;
            btnFazerPedido.Visible = true;
            btnFecharCaixa.Visible = true;
            btnFazerPedido.Visible = true;
        }

        private void BtnFecharCaixa_Click(object sender, EventArgs e)
        {
            FormFecharCaixa FC = new FormFecharCaixa();
            FC.ShowDialog();
            btnFecharCaixa.Visible = false;
        }

        

        private void BtnFazerPedido_Click(object sender, EventArgs e)
        {
            FormPedido FP = new FormPedido();
            FP.ShowDialog();
        }

        private void BtnCadastrarPizza_Click(object sender, EventArgs e)
        {
            FormCadastrarPizza CadP = new FormCadastrarPizza();
            CadP.ShowDialog();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
