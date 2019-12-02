using Projeto_Pizzaria_das_Couves.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria_das_Couves.Controle
{
    class ControleFecharCaixa
    {
        //Método onde podem ser realizadas validações acerca das informações informadas para o Cliente a ser inserido no banco.
        public string AdicionarFecharCaixa(FecharCaixa fechar)
        {
            FecharCaixaDAO pp = new FecharCaixaDAO();
            string mensagem = pp.Adicionar(fechar); // Adicionar -> está em DAO
            return mensagem;

        }

        //Método intermediário utilizado para retornar informações dos clientes que estão salvos no banco.
        public SqlDataReader RetornarFecharCaixas(string Nome)
        {
            FecharCaixaDAO pe = new FecharCaixaDAO();
            return pe.RetornarFecharCaixas(Nome);
        }

        public SqlDataReader RetornarFecharCaixa(int indice)
        {
            FecharCaixaDAO ped = new FecharCaixaDAO();
            return ped.RetornarFecharCaixa(indice);
        }
    }
}
