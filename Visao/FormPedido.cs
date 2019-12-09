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
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
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

                    if (dr != null) //Verifico 
                    {
                        while (dr.Read())
                        {
                            ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());// Id pedido

                            lv.SubItems.Add(dr.GetString(1));//Nome Pizza
                            lv.SubItems.Add(dr.GetDecimal(2).ToString());//Valores pizza+entrega  


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

        

        private void FormPedido_Load(object sender, EventArgs e)
        {
            PreencherListViewCli();
            PreencherListViewPizza();
            PreencherListView();
            PreencherListB();

        }
        public void PreencherListB()
        {
             //listBpedidos.Items.Clear();

             SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
             ControleFazerPedido pb = new ControleFazerPedido();
             // MODIFICAR PARA APARECER NO LISTBOX OS IDS
             dr = pb.RetornarFazerPedidos(txbIdCpedido.Text); //Chama o método responsável pela realização da consulta. 

             if (dr != null) //Verifico 
             {
                 while (dr.Read())
                 {
                     ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());// id 
                     listBpedidos.Items.Add(lv); //Adiciona a linha criada à listview.
                 }
             }
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

        // preencher listview do pedido... la no else nao é para isso.
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
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());// id pedidos
                    lv.SubItems.Add(dr.GetString(1));//Nome Pizza
                    lv.SubItems.Add(dr.GetDecimal(2).ToString());//Valores pizza+entrega 
                    listVpedidos.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }

        private void BtnDeletarPedido_Click_1(object sender, EventArgs e)
        {
            //fazer delete com ID no listbox. nao esta deletando
            if (listBpedidos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um Campo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Deseja Excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // ERRO AO CONVERTER DE VARCHAR, Não está deletendo
                string item = listBpedidos.SelectedItem.ToString();// não usado

                //int it = Convert.ToInt32(listBpedidos.SelectedValue);// erro ao converter
                FazerPedido pedido = new FazerPedido();// it aqui, mas ta com erro
                ControleFazerPedido dp = new ControleFazerPedido();
                string mensagem = dp.RemoverFazerPedido(pedido);

                MessageBox.Show(mensagem);

            }

        }
    }
}
