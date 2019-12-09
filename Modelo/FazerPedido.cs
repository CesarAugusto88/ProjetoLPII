using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria_das_Couves.Modelo
{
    class FazerPedido
    {
        public int Id { get; set; }
        public int FkIdCliente { get; set; }
        public string NomePizza { get; set; }
        public double ValorPizza { get; set; }
        public double ValorEntrega { get; set; }
        


        public FazerPedido(int fkidCliente, string nomePizza, double valorPizza, double valorEntrega)
        {
            this.FkIdCliente = fkidCliente;
            this.NomePizza = nomePizza;
            this.ValorPizza = valorPizza;
            this.ValorEntrega = valorEntrega;
                       
        }

        public FazerPedido(int idpedido)
        {
            this.Id = idpedido;
        }

        public FazerPedido()
        {

        }
    }
}
