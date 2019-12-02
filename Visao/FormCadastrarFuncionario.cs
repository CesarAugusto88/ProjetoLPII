using Projeto_Pizzaria_das_Couves.Controle;
using Projeto_Pizzaria_das_Couves.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pizzaria_das_Couves.Visao
{
    public partial class FormCadastrarFuncionario : Form
    {
        public FormCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void FormCadastrarFuncionario_Load(object sender, EventArgs e)
        {
            PreencherListView();

        }

        public void PreencherListView()
        {
            listVfuncionarios.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleCliente cc = new ControleCliente();
            dr = cc.RetornarClientes(); //Chama o método responsável pela realização da consulta. 

            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());
                    lv.SubItems.Add(dr.GetString(1));//Nome
                    lv.SubItems.Add(dr.GetString(2));//CPF
                    lv.SubItems.Add(dr.GetString(3));//RG
                    lv.SubItems.Add(dr.GetString(4));//Email
                    listVfuncionarios.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }

        private void LblConfirmaF_Click(object sender, EventArgs e)
        {

        }

        private void LblSenhaF_Click(object sender, EventArgs e)
        {

        }

        private void LblLoginF_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastrarF_Click(object sender, EventArgs e)
        {
            if (txbNomeF.Text == "" || txbCpfF.Text == "" || txbRgF.Text == "" || txbCelularF.Text == "" || txbEmailF.Text == "" || txbGeneroF.Text == "" || txbLograF.Text == "" || txbNumF.Text == "" || txbCompF.Text == "" || txbBairroF.Text == "")
            {

                MessageBox.Show("Os campos são Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show("O Campo de Nome é Obrigatorio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Txt_Nome.Focus();
                PreencherListView();
            }
            else
            {

                Funcionario funcionario = new Funcionario(txbNomeF.Text, txbCpfF.Text, txbRgF.Text, txbCelularF.Text, txbGeneroF.Text, txbEmailF.Text, txbLograF.Text, int.Parse(txbNumF.Text), txbCompF.Text, txbBairroF.Text);
                ControleFuncionario fun = new ControleFuncionario();
                string mensagem = fun.AdicionarFuncionario(funcionario); //Chama o método que realiza a inserção no banco.
                                                                         // fazer controle login e senha. criado um fk para email e pode-se verificar uma so vez
                                                                         //outra 'mensagem' string mensagem0 = ff.AdicionarFuncionario(funcionario); //Chama o método que realiza a inserção no banco.

                // colocar verificação de mensagem junto no banco
                ControleLogin controle = new ControleLogin();
                string mensagem0 = controle.cadastrar(txbEmailF.Text, txbSenhaF.Text, txbConfirmaSenhaF.Text);
                if (controle.tem)// mensagem de sucesso
                {
                    MessageBox.Show(mensagem0, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(controle.mensagem);// mensagem de erro

                }

                void PreencherListView()
                {
                    listVfuncionarios.Items.Clear();

                    SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
                    ControleCliente cc = new ControleCliente();
                    dr = cc.RetornarClientes(); //Chama o método responsável pela realização da consulta. 

                    if (dr != null) //Verifico 
                    {
                        while (dr.Read())
                        {
                            ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());
                            lv.SubItems.Add(dr.GetString(1));//Nome
                            lv.SubItems.Add(dr.GetString(2));//CPF
                            lv.SubItems.Add(dr.GetString(3));//RG
                            lv.SubItems.Add(dr.GetString(4));//Email
                            listVfuncionarios.Items.Add(lv); //Adiciona a linha criada à listview.
                        }
                    }
                }
                //FormBemVindo BvF = new FormBemVindo();
                //BvF.ShowDialog();
                //PreencherListView();
                //So uma mensagem. MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show(mensagem);
                LimpaTextoFun();
                //FormBemVindo BvC = new FormBemVindo();
                //BvC.ShowDialog();
                PreencherListView();
            }

            
        }

        public void LimpaTextoFun()
        {
            txbNomeF.Text = "";
            txbCpfF.Text = "";
            txbRgF.Text = "";
            txbCelularF.Text = "";
            txbGeneroF.Text = "";
            txbEmailF.Text = "";
            txbLograF.Text = "";
            txbNumF.Text = "";
            txbCompF.Text = "";
            txbBairroF.Text = "";
            txbLoginF.Text = "";
            txbSenhaF.Text = "";
            txbConfirmaSenhaF.Text = "";
        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblCompF_Click(object sender, EventArgs e)
        {

        }

        private void LblBairroF_Click(object sender, EventArgs e)
        {

        }

        private void LblNumF_Click(object sender, EventArgs e)
        {

        }

        private void LblLograF_Click(object sender, EventArgs e)
        {

        }

        private void LblEmailF_Click(object sender, EventArgs e)
        {

        }

        private void LblGeneroF_Click(object sender, EventArgs e)
        {

        }

        private void LblCelularF_Click(object sender, EventArgs e)
        {

        }

        private void LblRgF_Click(object sender, EventArgs e)
        {

        }

        private void LblCpfF_Click(object sender, EventArgs e)
        {

        }

        private void LblNomeF_Click(object sender, EventArgs e)
        {

        }
    }
}
