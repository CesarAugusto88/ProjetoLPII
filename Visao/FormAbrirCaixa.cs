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
            
            this.Close();
            btnAbrir.Visible = false;
            

        }

        private void FormAbrirCaixa_Load(object sender, EventArgs e)
        {
            //btnFecharCaixa.Visible = true;
            //btnCadastrarCliente.Visible = true;
            //btnCadastrarFuncionario.Visible = true;

            

        }
    }
}
