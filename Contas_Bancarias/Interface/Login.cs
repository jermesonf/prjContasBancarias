using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//importar a classe MYSQL
using MySql.Data.MySqlClient;

namespace Interface
{
    public class Login
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Mensagem { get; set; }
        public int Logado { get; set; }

        public DateTime data { get; set; }

    }

    public class AcessoLogin
    {
        public void Acessar(Login dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT userLogin FROM tb_usuario WHERE " +
                "userLogin = @usuario AND userSenha = @senha";
                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem atribuídos na string sql
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.Usuario));
                cmd.Parameters.Add(new MySqlParameter("@senha", dados.Senha));
                //Realiza a leitura dos dados
                //MySqlDataReader dr = cmd.ExecuteReader();
                //Se houver linhas, pode-se recuperar valores individuais
                if (dr.HasRows)
                {
                    //Atribui o valor 1 à variável logado para o usuário
                    dados.Logado = 1;
                    while (dr.Read())
                    {
                        //Armazena o usuário na posição 0 da linha de registro
                        dados.Usuario = dr.GetValue(0).ToString();
                        dados.Mensagem = "Bem vindo " + dados.Usuario;
                    }
                }
                else
                {
                    dados.Mensagem = "Erro - Usuário ou Senha inválido!";
                    dados.Logado = 0;
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "Erro - AcessoLogin - Acessar " +
                erro.Message;
            }
        }



    }

    public class AtualizaLogin
    {
        public void AtualizarLogado(Login dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "UPDATE tb_usuario SET userLogado = @logado, " + 
                "userAcesso = @data WHERE userLogin = @usuario";
                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem atribuído na string sql
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.Usuario));
                cmd.Parameters.Add(new MySqlParameter("@logado", dados.Logado));
                cmd.Parameters.Add(new MySqlParameter("@data", dados.data));

                //Realiza a contagem de registros inseridos.
                int registrosAtualizados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi inserido no Banco de Dados.
                if (registrosAtualizados >= 1)
                {
                    dados.Mensagem = "Registro atualizado com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao atualizar registro!";
                }
                //Fecha a conexão com o Banco de Dados.
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - AtualizaLogon - AtualizarLogado: " +
                erro.Message.ToString();
            }
        }

        public void AtualizarLogadoLogoff(Login dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "UPDATE tb_usuario SET userLogado = 0 " +
                "WHERE userLogin = @usuario";
                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem atribuído na string sql
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.Usuario));

                //Realiza a contagem de registros inseridos.
                int registrosAtualizados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi inserido no Banco de Dados.
                if (registrosAtualizados >= 1)
                {
                    dados.Mensagem = "Registro atualizado com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao atualizar registro!";
                }
                //Fecha a conexão com o Banco de Dados.
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - AtualizaLogon - AtualizarLogado: " +
                erro.Message.ToString();
            }
        }
    }


}
