using Projeto_Pizzaria_das_Couves.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria_das_Couves.Controle
{
    class ControleAbrirCaixa
    {
        //Método onde podem ser realizadas validações acerca das informações informadas para o Cliente a ser inserido no banco.
        public string AdicionarAbrirCaixa(AbrirCaixa abrir)
        {
            AbrirCaixaDAO aac = new AbrirCaixaDAO();
            string mensagem = aac.Adicionar(abrir); // Adicionar -> está em DAO
            return mensagem;

        }

        //Método intermediário utilizado para retornar informações dos clientes que estão salvos no banco.
        public SqlDataReader RetornarAbrirCaixas(string Nome)
        {
            AbrirCaixaDAO aa = new AbrirCaixaDAO();
            return aa.RetornarAbrirCaixas(Nome);
        }

        public SqlDataReader RetornarAbrirCaixa(int indice)
        {
            AbrirCaixaDAO ab = new AbrirCaixaDAO();
            return ab.RetornarAbrirCaixa(indice);
        }
    }
}
