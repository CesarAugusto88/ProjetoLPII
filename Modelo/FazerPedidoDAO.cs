using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria_das_Couves.Modelo
{
    class FazerPedidoDAO
    {
        public string Mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand(); //Cria objeto para definição e execução de comando SQL.
        Conexao con = new Conexao(); //Cria objeto que estabelecerá a conexão com o banco.
        //Armazena o retorno de uma consulta feita no banco.
        SqlDataReader dr;

        public string Adicionar(FazerPedido pedido)
        {
            Mensagem = String.Empty;
            //Comando SQL. TERMINAR O INSET INTO APOS FAZER TAB NO BANCO...
            cmd.CommandText = "insert into FazerPedido values (@idcli, @nomep, @valorp, @valoren)";
            cmd.Parameters.AddWithValue("idcli", pedido.FkIdCliente);
            cmd.Parameters.AddWithValue("nomep", pedido.NomePizza);
            cmd.Parameters.AddWithValue("valorp", pedido.ValorPizza);
            cmd.Parameters.AddWithValue("valoren", pedido.ValorEntrega);



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
            cmd.CommandText = "SELECT MAX(Id) FROM FazerPedido";
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
                // Colocado junto sem endereço no começo
                //dr.Read(); 
                /*
                cmd.CommandText = "insert into Cliente values (@nome, @cpf, @rg, @celular, @genero, @email, @endereco)";
                
                
                while (dr.Read()) // tira essa função???
                {
                    // endereco
                    cmd.Parameters.AddWithValue("valor", dr.GetInt32(0));
                } */

                dr.Close();
                //conectar com banco
                try
                {
                    //Receber o endereço de onde vou me conectar.
                    cmd.Connection = con.Conectar();
                    //Executar comando.
                    cmd.ExecuteNonQuery();
                    //Exibe mensagem;
                    Mensagem = "Pedido cadastrado com sucesso!!!";
                }
                catch (SqlException ex)
                {
                    //Captura a mensagem de erro gerada.
                    Mensagem = ex.Message;
                }
            }
            return Mensagem;
        }


        // verificar COMANDO delete. No listBox deverá ter como selecionar o Id, que esta no form.cs
        // de toString para toInt32 e vem para deletar
        public string Remover(FazerPedido pedido)
        {
            Mensagem = String.Empty;
            //Comando SQL. Como deletar com o que vem no parâmetro pedido???
            // Usar uma procedure "EXEC deletarPedido id" ?? ou "delete from FazerPedido where Id = @id"
            // TENHO QUE SELECIONAR O CORRETO NO LISTBOX QUE ESTA APARECENDO
            cmd.CommandText = "delete from FazerPedido where Id = @id";//ERRO
            cmd.Parameters.AddWithValue("id", pedido.Id);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();// executa o comando
                con.Desconectar();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }
            //Seleciona o maior Id 
            cmd.CommandText = "SELECT MAX(Id) FROM FazerPedido";
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
                    //Receber de onde vou me conectar.
                    cmd.Connection = con.Conectar();
                    //Executar comando.
                    cmd.ExecuteNonQuery();
                    //Exibe mensagem;
                    Mensagem = "Pedido removido com sucesso!!!";
                }
                catch (SqlException ex)
                {
                    //Captura a mensagem de erro gerada.
                    Mensagem = ex.Message;
                }
            }
            return Mensagem;
        }

        public SqlDataReader RetornarFazerPedidos(string Nome)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select Id, NomePizza, (ValorPizza + ValorEntrega) from FazerPedido";
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


        public SqlDataReader RetornarFazerPedido(int indice)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from FazerPedido where Id = @id";
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
