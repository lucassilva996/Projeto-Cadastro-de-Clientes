using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADO.NET -> SQL Server

namespace DAL.Persistence
{
    public class Conexao
    {
        //atributos
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;
        
        //Método - Abrir conexao
        protected void AbrirConexao()
        {
            try
            {
                //Connection String
                Con = new SqlConnection("Data Source=DESKTOP-4MN6G5L;Initial Catalog=BdSistema;Persist Security Info=True;User ID=sa;Password=***********;Integrated Security=True");
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //Método - Fechar conexao
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
