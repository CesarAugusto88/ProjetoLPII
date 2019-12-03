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
    public partial class FormFazerPedido : Form
    {
        public FormFazerPedido()
        {
            InitializeComponent();
        }


        private void FormFazerPedido_Load(object sender, EventArgs e)
        {
            PreencherListViewCli();
            PreencherListViewPizza();
            PreencherListView();
            
        }

        public void PreencherListViewCli()
        {
            listVclientesPedido.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleCliente cc = new ControleCliente();
            dr = cc.RetornarClientes(); //Chama o método responsável pela realização da consulta. 



            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    // esta aparecendo o Id do Cliente e é o "Id identity" ?
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());//Id
                    lv.SubItems.Add(dr.GetString(1));//Nome
                    lv.SubItems.Add(dr.GetString(2));//celular
                    lv.SubItems.Add(dr.GetString(3));//Rua
                    lv.SubItems.Add(dr.GetInt32(4).ToString());//Numero
                    lv.SubItems.Add(dr.GetString(5));//Bairro

                    listVclientesPedido.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }
        public void PreencherListViewPizza()
        {
            listVpizzasPedido.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControlePizza pp = new ControlePizza();
            dr = pp.RetornarPizzas(txbNomepizzaPedido.Text); //Chama o método responsável pela realização da consulta. 



            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                   
                    ListViewItem lv = new ListViewItem(dr.GetString(0).ToString());// Nome Pizza
                    lv.SubItems.Add(dr.GetDecimal(1).ToString());//Valor Pizza.
                    listVpizzasPedido.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }


        public void PreencherListView()
        {
            listVpedidos.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleFazerPedido pp = new ControleFazerPedido();
            dr = pp.RetornarFazerPedidos(txbNomepizzaPedido.Text); //Chama o método responsável pela realização da consulta. 
                                                                   


            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    // não aparece os valores. Ver o tabela no banco de dados
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());// FkIdCliente
                    lv.SubItems.Add(dr.GetString(1));//Nome Pizza.
                   // lv.SubItems.Add(dr.GetDecimal(2).ToString());//Valor Pizza não aparece 
                   // lv.SubItems.Add(dr.GetDecimal(3).ToString());//Valor Entrega não aparece
                    listVpedidos.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbPedidoParcial_Click(object sender, EventArgs e)
        {
            
        }

       
        


        public void LimparCamposFazerPedido()
        {
            txbIdCpedido.Text = String.Empty;
            txbNomepizzaPedido.Text = String.Empty;
            txbValorpizzaPedido.Text = String.Empty;
            txbValorentregaPedido.Text = String.Empty;
            
        }

        private void BtnCadastrarPedido_Click(object sender, EventArgs e)
        {
            if (txbIdCpedido.Text == "" || txbNomepizzaPedido.Text == "" || txbValorentregaPedido.Text == "" || txbValorpizzaPedido.Text == "")
            {

                MessageBox.Show("Os campos são Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show("O Campo de Nome é Obrigatorio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Txt_Nome.Focus();
            }
            else
            {
                FazerPedido pedido = new FazerPedido(int.Parse(txbIdCpedido.Text), txbNomepizzaPedido.Text, double.Parse(txbValorpizzaPedido.Text), double.Parse(txbValorentregaPedido.Text));

                ControleFazerPedido fpedido = new ControleFazerPedido();
                string mensagem = fpedido.AdicionarFazerPedido(pedido);

                MessageBox.Show(mensagem);
                void PreencherListView()
                {
                    listVpedidos.Items.Clear();

                    SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
                    ControleFazerPedido pp = new ControleFazerPedido();
                    dr = pp.RetornarFazerPedidos(txbNomepizzaPedido.Text); //Chama o método responsável pela realização da consulta. 
                                                               // tres lugares para alterar RetornarPizzas


                    if (dr != null) //Verifico 
                    {
                        while (dr.Read())
                        {
                            ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());// FkIdCliente
                            lv.SubItems.Add(dr.GetString(1));//Nome Pizza
                           //  lv.SubItems.Add(dr.GetDecimal(2).ToString());//Valor Pizza 
                           // lv.SubItems.Add(dr.GetDecimal(3).ToString());//Valor Entrega

                            listVpedidos.Items.Add(lv); //Adiciona a linha criada à listview.
                        }
                    }
                }

                PreencherListView();
                

                LimparCamposFazerPedido();
            }

            //FormBemVindo BvC = new FormBemVindo();
            //BvC.ShowDialog();
            PreencherListView();
        }        
        
    }
}
