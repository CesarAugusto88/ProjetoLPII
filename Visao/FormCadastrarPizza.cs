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
    public partial class FormCadastrarPizza : Form
    {
        public FormCadastrarPizza()
        {
            InitializeComponent();
        }

        private void LblIng4_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadPizza_Click(object sender, EventArgs e)
        {
            // aparece na lista mas nao está no banco de dados
            //listVpizzas.Items.Add(txbNomePizza.Text, txbValorP.Text);

            // fazer uma condição para verificar campos preenchidos
            
            if (txbNomePizza.Text == "" || txbIng1.Text == "" || txbIng2.Text == "" || txbIng3.Text == "" || txbIng4.Text == "" || txbValorP.Text == "")
            {

                MessageBox.Show("Os campos são Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show("O Campo de Nome é Obrigatorio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Txt_Nome.Focus();
            }
            else
            {

                Pizza pizza = new Pizza(txbNomePizza.Text, txbIng1.Text, txbIng2.Text, txbIng3.Text, txbIng4.Text, double.Parse(txbValorP.Text));
                ControlePizza piz = new ControlePizza();
                string mensagem = piz.AdicionarPizza(pizza);

                MessageBox.Show(mensagem);

                void PreencherListView()
                {
                    listVpizzas.Items.Clear();

                    SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
                    ControlePizza pi = new ControlePizza();
                    dr = pi.RetornarPizzas(txbNomePizza.Text); //Chama o método responsável pela realização da consulta. 
                                                               
                    if (dr != null) //Verifico 
                    {
                        while (dr.Read())
                        {
                            ListViewItem lv = new ListViewItem(dr.GetString(0).ToString());// Nome
                            lv.SubItems.Add(dr.GetDecimal(1).ToString());//Valor 

                            listVpizzas.Items.Add(lv); //Adiciona a linha criada à listview.
                        }
                    }
                }

                PreencherListView();
                LimparCamposPizza();
            }

            
            //FormBemVindo BvC = new FormBemVindo();
            //BvC.ShowDialog();
            

        }
        

        

        public void LimparCamposPizza()
        {
            txbNomePizza.Text = String.Empty;
            txbIng1.Text = String.Empty;
            txbIng2.Text = String.Empty;
            txbIng3.Text = String.Empty;
            txbIng4.Text = String.Empty;
            txbValorP.Text = String.Empty;            
        }

        public void PreencherListView()
        {
            listVpizzas.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControlePizza pi = new ControlePizza();
            dr = pi.RetornarPizzas(txbNomePizza.Text); //Chama o método responsável pela realização da consulta. 
                                                       // tres lugares para alterar RetornarPizzas


            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr.GetString(0).ToString());// Nome
                    lv.SubItems.Add(dr.GetDecimal(1).ToString());//Valor ERRO

                    listVpizzas.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }
        private void FormCadastrarPizza_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }

        private void ListVpizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
