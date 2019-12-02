using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria_das_Couves.Modelo
{
    class AbrirCaixa
    {
        public int FkIdLogin { get; set; }
        public double ValorInicial { get; set; }


        public AbrirCaixa(int fkIdlogin, double valorinicial)
        {
            this.FkIdLogin = fkIdlogin;
            this.ValorInicial = valorinicial;
        }

        public AbrirCaixa()
        {
        }
    }
}
