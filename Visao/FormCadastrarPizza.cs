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
                LimparCamposPizza();
            }

            //FormBemVindo BvC = new FormBemVindo();
            //BvC.ShowDialog();
            PreencherListView();

        }
        private void listVpizzas_Click(object sender, EventArgs e)
        {
            int indicePizza = int.Parse(listVpizzas.SelectedItems[0].SubItems[0].Text);
            int indiceId = -1;// para que serve?
            ControlePizza pp = new ControlePizza();
            SqlDataReader dr = pp.RetornarPizza(indicePizza);

            if (dr != null)
            {
                while (dr.Read())
                {
                    txbNomePizza.Text = dr.GetString(1);
                    txbIng1.Text = dr.GetString(2);
                    txbIng2.Text = dr.GetString(3);
                    txbIng3.Text = dr.GetString(4);
                    txbIng4.Text = dr.GetString(5);
                    txbValorP.Text = dr.GetString(6);

                    
                    indiceId = dr.GetInt32(8);// nao sei usar
                }
            }


            ControlePizza p = new ControlePizza();
            dr = p.RetornarPizza(indiceId);
            if (dr != null)
            {
                while (dr.Read())
                {
                    txbNomePizza.Text = dr.GetString(1);
                    txbIng1.Text = dr.GetInt32(2).ToString();
                    txbIng2.Text = dr.GetString(3);
                    txbIng3.Text = dr.GetString(4);
                    txbIng4.Text = dr.GetString(5);
                    txbValorP.Text = dr.GetString(6);
                    
                }
            }
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
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());
                    lv.SubItems.Add(dr.GetString(1));//Nome pizza
                    lv.SubItems.Add(dr.GetString(2));//Ingrediente 1
                    lv.SubItems.Add(dr.GetString(3));//ingrediente 2
                    lv.SubItems.Add(dr.GetString(4));//ingrediente 3
                    lv.SubItems.Add(dr.GetString(5));//ingrediente 4
                    //lv.SubItems.Add(dr.GetString(6));//Valor da pizza. Com Erro
                    listVpizzas.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
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


        private void FormCadastrarPizza_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }

        private void ListVpizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
