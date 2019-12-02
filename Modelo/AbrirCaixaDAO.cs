using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria_das_Couves.Modelo
{
    class AbrirCaixaDAO
    {
        public string Mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand(); //Cria objeto para definição e execução de comando SQL.
        Conexao con = new Conexao(); //Cria objeto que estabelecerá a conexão com o banco.
        //Armazena o retorno de uma consulta feita no banco.
        SqlDataReader dr;

        public string Adicionar(AbrirCaixa abrirCaixa)
        {
            Mensagem = String.Empty;
            //Comando SQL
            cmd.CommandText = "insert into AbrirCaixa values (@FkIdLoginSenha, @ValorInicial)";
            cmd.Parameters.AddWithValue("FkIdLoginSenha", abrirCaixa.FkIdLogin);
            cmd.Parameters.AddWithValue("ValorInicial", abrirCaixa.ValorInicial);


            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }
            //Seleciona o maior Id de endereço (Endereco?), ou seja, o último adicionado.
            cmd.CommandText = "SELECT MAX(Id) FROM AbrirCaixa";
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }

            if (Mensagem == String.Empty)
            {
                

                dr.Close();
                //conectar com banco
                try
                {
                    //Receber o endereço de onde vou me conectar.
                    cmd.Connection = con.Conectar();
                    //Executar comando.
                    cmd.ExecuteNonQuery();
                    //Exibe mensagem;
                    Mensagem = "Sucesso, Caixa Aberto!!!";
                }
                catch (SqlException ex)
                {
                    //Captura a mensagem de erro gerada.
                    Mensagem = ex.Message;
                }
            }
            return Mensagem;
        }

        public SqlDataReader RetornarAbrirCaixas(string Nome)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from AbrirCaixa";
            //Parametros que serão substituídos no CommandText.

            try
            {
                cmd.Connection = con.Conectar(); //Tenta estabelecer a conexão com o banco de dados. 
                dr = cmd.ExecuteReader(); //Realiza a execução do SQL e obtém o retorno do banco em forma de objeto SQLDataReader.
                //Verifica se existe algum retorno na consulta do banco.
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException ex)
            {
                //Não é a mensagem mais apropriada!
                Console.WriteLine(ex.Message);
            }
            con.Desconectar();
            return null;
        }

        public SqlDataReader RetornarAbrirCaixa(int indice)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from AbrirCaixa where FkIdLoginSenha = @id";
            cmd.Parameters.AddWithValue("id", indice);


            try
            {
                cmd.Connection = con.Conectar(); //Tenta estabelecer a conexão com o banco de dados. 
                dr = cmd.ExecuteReader(); //Realiza a execução do SQL e obtém o retorno do banco em forma de objeto SQLDataReader.
                //Verifica se existe algum retorno na consulta do banco.
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException ex)
            {
                //Não é a mensagem mais apropriada!
                Console.WriteLine(ex.Message);
            }
            con.Desconectar();
            return null;
        }
    }
}
