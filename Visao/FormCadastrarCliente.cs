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

            }

        }
    }
}
