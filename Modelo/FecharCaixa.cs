using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria_das_Couves.Modelo
{
    class FecharCaixa
    {
        public int FkIdLogin { get; set; }
        public double ValorFinal { get; set; }


        public FecharCaixa(int fkIdlogin, double valorfinal)
        {
            this.FkIdLogin = fkIdlogin;
            this.ValorFinal = valorfinal;
        }

        public FecharCaixa()
        {
        }
    }
}
