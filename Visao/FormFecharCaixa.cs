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
    public partial class FormFecharCaixa : Form
    {
        public FormFecharCaixa()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblIdUsuarioFC_Click(object sender, EventArgs e)
        {

        }
    }
}
