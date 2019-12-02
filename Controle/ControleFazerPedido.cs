using Projeto_Pizzaria_das_Couves.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria_das_Couves.Controle
{
    class ControleFazerPedido
    {
        //Método onde podem ser realizadas validações acerca das informações informadas para o Cliente a ser inserido no banco.
        public string AdicionarFazerPedido(FazerPedido pedido)
        {
            FazerPedidoDAO pp = new FazerPedidoDAO();
            string mensagem = pp.Adicionar(pedido); // Adicionar -> está em DAO
            return mensagem;
            
        }

        //Método intermediário utilizado para retornar informações dos clientes que estão salvos no banco.
        public SqlDataReader RetornarFazerPedidos(string Nome)
        {
            FazerPedidoDAO pe = new FazerPedidoDAO();
            return pe.RetornarFazerPedidos(Nome);
        }

        public SqlDataReader RetornarFazerPedido(int indice)
        {
            FazerPedidoDAO ped = new FazerPedidoDAO();
            return ped.RetornarFazerPedido(indice);
        }

    }
}
