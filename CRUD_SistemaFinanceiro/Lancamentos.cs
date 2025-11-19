using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRUD_SistemaFinanceiro
{
    public class Lancamentos
    {
        public int id;
        public string descricao;
        public string tipo;
        public DateTime dataLancamento;
        public float valor;

        public bool gravarLancamento()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction transaction = cn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();


            cmd.Connection = cn;
            cmd.Transaction = transaction;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into lancamentos values (@descricao, @valor, @dataLancamento, @tipo);";

            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@dataLancamento", dataLancamento);
            cmd.Parameters.AddWithValue("@tipo", tipo);

            try
            {
                cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }

            finally
            {
                bd.fecharConexao();
            }
        }

        public bool excluirRegistro()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction transaction = cn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = transaction;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from lancamentos where id = @id";

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters[0].Value = id;


            try
            {
                cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }

            finally
            {
                bd.fecharConexao();
            }

        }

        public bool atualizarLancamento()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction transaction = cn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = transaction;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update lancamentos set descricao = @descricao," +
                "valor = @valor where id = @id";

            cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
            cmd.Parameters.Add("@valor", SqlDbType.Real);
            cmd.Parameters.Add("@id", SqlDbType.Int);

            cmd.Parameters[0].Value = descricao;
            cmd.Parameters[1].Value = valor;
            cmd.Parameters[2].Value = id;



            try
            {
                cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }

            finally
            {
                bd.fecharConexao();
            }
        }

        public Lancamentos consultaLancamento(int id)
        {

            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select * from lancamentos";

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.id = reader.GetInt32(0);
                        this.descricao = reader.GetString(1);
                        this.valor = reader.GetFloat(2);
                        this.dataLancamento = DateTime.Parse(reader.GetString(3));
                        this.tipo = reader.GetString(4);


                        return this;
                    }

                }

                return null;

            }
            catch (Exception ex)
            {

                return null;
            }

            finally
            {
                bd.fecharConexao();
            }
        }


        public DataTable consultarPorTipo(string tipo)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select * from lancamentos where tipo = @tipo";
                cmd.Parameters.AddWithValue("@tipo", tipo);

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
                bd.fecharConexao();
            }
        }

    }






}


