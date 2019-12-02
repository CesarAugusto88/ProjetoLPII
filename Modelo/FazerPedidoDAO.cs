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
            cmd.CommandText = "insert into FazerPedido values (@idCliente)";
            cmd.Parameters.AddWithValue("idCliente", pedido.FkIdCliente);
            


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
                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("rg", cliente.RG);
                cmd.Parameters.AddWithValue("celular", cliente.Celular);
                cmd.Parameters.AddWithValue("genero", cliente.Genero);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                
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
                    Mensagem = "Pedido cadastrada com sucesso!!!";
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
            cmd.CommandText = "select * from FazerPedido";
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
        /* exemplo carrega dados
        public SqlDataReader CarregaCliLis(string texto = " ")
        {

            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            if (texto == " ")
                comando.CommandText = " select ID_CLI,NOME_CLI,ENDERECO_CLI,ESTADO_CLI,TEL_CLI from CLIENTES";
            else
            {
                comando.CommandText = "select ID_CLI,NOME_CLI,ENDERECO_CLI,ESTADO_CLI,TEL_CLI from CLIENTES " +
                                      "WHERE NOME_CLI LIKE  '%" + texto + "%'";
            }


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            return LINHA;

        } */
    }
}
