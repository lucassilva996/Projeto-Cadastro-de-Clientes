using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient; //Biblioteca de Acesso ao SQL SERVER
using DAL.Model;

namespace DAL.Persistence 
{
    
    public class PessoaDAL : Conexao
    {
        //regras de negócio da nossa aplicação - Consultas| SELECT,
        //UPDATE, INSERT, DELETE, OBTERPORID

        //Metodo para gravar dados: INSERT: 
        public void Gravar(Pessoa p)
        {
            try
            {
                //Abrir a conexão:
                AbrirConexao();
                Cmd = new SqlCommand("insert into Pessoa(Nome, Endereco, Email) values(@v1, @v2, @v3)", Con);
                
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);

                Cmd.ExecuteNonQuery(); //executada esse nosso método!!
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar o cliente..." + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        //Metodo para atualizar dados: UPDATE:
        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Pessoa set Nome=@v1, Endereco=@v2, Email=@v3 where Codigo=@v4", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o cliente: "+ ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        //Metodo para excluir dados: DELETe:
        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete Pessoa where Codigo=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir o cliente" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        //Metodo para obter 1 Pessoa pelo Código (Chave Primária):
        public Pessoa PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa where Codigo=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Dr = Cmd.ExecuteReader(); //Execução da leitura das informações do BD
               
                Pessoa p = null; //criando um espaço de memória no ponteiro
                
                if(Dr.Read())
                {
                    p = new Pessoa();
                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o Cliente:" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Metodo para obter 1 Pessoa pelo Código (Chave Primária):
        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("Select * from Pessoa", Con);
                Dr = Cmd.ExecuteReader();
                List<Pessoa> lista = new List<Pessoa>(); //Lista Vazia

                while(Dr.Read())
                {
                    Pessoa p = new Pessoa();
                    p = new Pessoa();
                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível listar os clientes: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
   
}






