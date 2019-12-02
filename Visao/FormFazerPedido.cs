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
            PreencherListView();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbPedidoParcial_Click(object sender, EventArgs e)
        {
            
        }

        private void listVpedidos_Click(object sender, EventArgs e)
        {
            int indicePedido = int.Parse(listVpedidos.SelectedItems[0].SubItems[0].Text);
            int indiceId = -1;// para que serve?
            ControleFazerPedido ped = new ControleFazerPedido();
            SqlDataReader dr = ped.RetornarFazerPedido(indicePedido);

            if (dr != null)
            {
                while (dr.Read())
                {
                    txbIdCpedido.Text = dr.GetString(1);
                    txbNomepizzaPedido.Text = dr.GetString(2);
                    txbValorpizzaPedido.Text = dr.GetString(3);
                    txbValorentregaPedido.Text = dr.GetString(4);
                    
                    indiceId = dr.GetInt32(8);// nao sei usar
                }
            }


            ControleFazerPedido pedd = new ControleFazerPedido();
            dr = pedd.RetornarFazerPedido(indicePedido);
            if (dr != null)
            {
                while (dr.Read())
                {
                    txbIdCpedido.Text = dr.GetString(1);
                    txbNomepizzaPedido.Text = dr.GetInt32(2).ToString();
                    txbValorpizzaPedido.Text = dr.GetString(3);
                    txbValorentregaPedido.Text = dr.GetString(4);                  

                }
            }
        }

        public void PreencherListView()
        {
            listVpedidos.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleFazerPedido ped = new ControleFazerPedido();
            dr = ped.RetornarFazerPedidos(txbIdCpedido.Text); //Chama o método responsável pela realização da consulta. 
                                                       // tres lugares para alterar RetornarPizzas
                                                       // ->parâmetros nos métodos

            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());
                    lv.SubItems.Add(dr.GetString(1));//Id Cliente - FkId no banco
                    lv.SubItems.Add(dr.GetString(2));//Nome Pizza
                    lv.SubItems.Add(dr.GetString(3));//Valor Pizza
                    lv.SubItems.Add(dr.GetString(4));//Valor Entrega
                    
                    listVpedidos.Items.Add(lv); //Adiciona a linha criada à listview.
                    //listVpizzasPedido.Items.Add(lp); //mostrar pizzas cadastradas?
                    //listVclientesPedido.Items.Add(lc); //mostra clientes cadastrados?
                }
            }
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
                LimparCamposFazerPedido();
            }

            //FormBemVindo BvC = new FormBemVindo();
            //BvC.ShowDialog();
            PreencherListView();
        }        
        
    }
}
