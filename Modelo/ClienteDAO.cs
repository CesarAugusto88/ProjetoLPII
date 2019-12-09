using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projeto_Pizzaria_das_Couves.Modelo
{
    class ClienteDAO
    {
        public string Mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand(); //Cria objeto para definição e execução de comando SQL.
        Conexao con = new Conexao(); //Cria objeto que estabelecerá a conexão com o banco.
        //Armazena o retorno de uma consulta feita no banco.
        SqlDataReader dr;

        public string Adicionar(Cliente cliente)
        {
            Mensagem = String.Empty;
            //Comando SQL
            cmd.CommandText = "insert into Cliente values (@nome, @cpf, @rg, @celular, @genero, @email, @logradouro, @numero, @complemento, @bairro)";
            cmd.Parameters.AddWithValue("nome", cliente.Nome);
            cmd.Parameters.AddWithValue("cpf", cliente.CPF);
            cmd.Parameters.AddWithValue("rg", cliente.RG);
            cmd.Parameters.AddWithValue("celular", cliente.Celular);
            cmd.Parameters.AddWithValue("genero", cliente.Genero);
            cmd.Parameters.AddWithValue("email", cliente.Email);
            cmd.Parameters.AddWithValue("logradouro", cliente.Logradouro);
            cmd.Parameters.AddWithValue("numero", cliente.Numero);
            cmd.Parameters.AddWithValue("complemento", cliente.Complemento);
            cmd.Parameters.AddWithValue("bairro", cliente.Bairro);
            
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
            //Seleciona o maior Id de endereço, ou seja, o último adicionado.
            cmd.CommandText = "SELECT MAX(Id) FROM Cliente";
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
                //dr.Read();
                
                dr.Close();
                //conectar com banco
                try
                {
                    //Receber o endereço de onde vou me conectar.
                    cmd.Connection = con.Conectar();
                    //Executar comando.
                    cmd.ExecuteNonQuery();
                    //Exibe mensagem;
                    Mensagem = "Cliente cadastrado com sucesso!!!";
                }
                catch (SqlException ex)
                {
                    //Captura a mensagem de erro gerada.
                    Mensagem = ex.Message;
                }
            }
            return Mensagem;
        }

        // REMOVER CLIENTE ???
        public string Remover(Cliente cliente)
        {
            Mensagem = String.Empty;
            //Comando SQL
            cmd.CommandText = "delete from Cliente where |Id = @id";
            cmd.Parameters.AddWithValue("id", cliente.Id);
            

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
            //Seleciona o maior Id, ou seja, o último adicionado.
            cmd.CommandText = "SELECT MAX(Id) FROM Cliente";
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
                //dr.Read();

                dr.Close();
                //conectar com banco
                try
                {
                    //Receber o endereço de onde vou me conectar.
                    cmd.Connection = con.Conectar();
                    //Executar comando.
                    cmd.ExecuteNonQuery();
                    //Exibe mensagem;
                    Mensagem = "Cliente removido com sucesso!!!";
                }
                catch (SqlException ex)
                {
                    //Captura a mensagem de erro gerada.
                    Mensagem = ex.Message;
                }
            }
            return Mensagem;
        }

        // ESSA FUNÇÃO É CARREGADA NO LOAD DO FORM E VAI PARA A LISTVIEM... 
        public SqlDataReader RetornarClientes()
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select Id, Nome, Celular, Logradouro, Numero, Bairro from Cliente";
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

        public SqlDataReader RetornarCliente(int indice)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Cliente where Id = @id";
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
