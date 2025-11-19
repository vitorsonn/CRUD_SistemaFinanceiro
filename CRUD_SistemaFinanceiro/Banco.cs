using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_SistemaFinanceiro
{
    public class Banco
    {
        private string StringConexao = "Data Source=localhost; Initial Catalog=lancamentosBD;" +
     "User ID=usuario; password=senha;";

        private SqlConnection cn;


        private void conexao()
        {
            cn = new SqlConnection(StringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao abrir conexão com o banco de dados. Verifique a string de conexão e o servidor. Detalhes: " + ex.Message,
                        "Erro Crítico de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {

            }


        }

        public DataTable executarConsulta(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand cmd = new SqlCommand(sql, cn); 
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); 

                DataTable dt = new DataTable(); 
                adapter.Fill(dt); 
                return dt;

            }
            catch (Exception ex)
            {

                return null;
            }

            finally
            {
                fecharConexao();
            }
        }

    }

}

    
