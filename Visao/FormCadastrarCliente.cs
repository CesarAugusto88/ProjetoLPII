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
    public partial class FormCadastrarCliente : Form
    {
        public FormCadastrarCliente()
        {
            InitializeComponent();
        }

        private void LblLograC_Click(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastrarCliente_Load(object sender, EventArgs e)
        {
            PreencherListView();

        }
        public void PreencherListView()
        {
            listVclientes.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleCliente cc = new ControleCliente();
            dr = cc.RetornarClientes(); //Chama o método responsável pela realização da consulta. 

            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());//Id
                    lv.SubItems.Add(dr.GetString(1));// Nome   
                    lv.SubItems.Add(dr.GetString(2));// Celular
                    lv.SubItems.Add(dr.GetString(3));// Logradouro
                    lv.SubItems.Add(dr.GetInt32(4).ToString());// numero
                    lv.SubItems.Add(dr.GetString(5)); // bairro


                    listVclientes.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNumC_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (txbNomeC.Text == "" || txbCpfC.Text == "" || txbRgC.Text == "" || txbCelC.Text == "" || txbEmailC.Text == "" || txbGeneroC.Text == "" || txbLograC.Text == "" || txbNumC.Text == "" || txbCompC.Text == "" || txbBairroC.Text == "")
            {

                MessageBox.Show("Os campos são Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show("O Campo de Nome é Obrigatorio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Txt_Nome.Focus();
            }
            else
            {


                Cliente cliente = new Cliente(txbNomeC.Text, txbCpfC.Text, txbRgC.Text, txbCelC.Text, txbGeneroC.Text, txbEmailC.Text, txbLograC.Text, int.Parse(txbNumC.Text), txbCompC.Text, txbBairroC.Text);
                ControleCliente cli = new ControleCliente();
                string mensagem = cli.AdicionarCliente(cliente); //Chama o método que realiza a inserção no banco.
                                                                 // fazer controle login e senha. criado um fk para email e pode-se verificar uma so vez
                                                                 //outra 'mensagem' string mensagem0 = ff.AdicionarFuncionario(funcionario); //Chama o método que realiza a inserção no banco.

                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                void PreencherListView()
                {
                    listVclientes.Items.Clear();

                    SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
                    ControleCliente cc = new ControleCliente();
                    dr = cc.RetornarClientes(); //Chama o método responsável pela realização da consulta. 

                    if (dr != null) //Verifico 
                    {
                        while (dr.Read())
                        {
                            ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());//Id
                            lv.SubItems.Add(dr.GetString(1));// Nome  
                            lv.SubItems.Add(dr.GetString(2));// Celular  
                            lv.SubItems.Add(dr.GetString(3));// Logradouro
                            lv.SubItems.Add(dr.GetInt32(4).ToString());// numero
                            lv.SubItems.Add(dr.GetString(5)); // bairro


                            listVclientes.Items.Add(lv); //Adiciona a linha criada à listview.
                        }
                    }
                }
                //FormBemVindo BvF = new FormBemVindo();
                //BvF.ShowDialog();
                //PreencherListView();
                //So uma mensagem. MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show(mensagem);
                LimpaTextoCli();
                //FormBemVindo BvC = new FormBemVindo();
                //BvC.ShowDialog();
                PreencherListView();
            }
            
        }
        public void LimpaTextoCli()
        {
            txbNomeC.Text = "";
            txbCpfC.Text = "";
            txbRgC.Text = "";
            txbCelC.Text = "";
            txbGeneroC.Text = "";
            txbEmailC.Text = "";
            txbLograC.Text = "";
            txbNumC.Text = "";
            txbCompC.Text = "";
            txbBairroC.Text = "";
        }

        private void ListVclientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
