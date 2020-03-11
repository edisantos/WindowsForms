using samsung.refacco.Data.Data;
using samsung.refacco.Repository.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace samsung.refacco.Repository.Repositories
{
    public class RepositoriesPanel:DataFactory
    {
        public DataTable Listar()
        {
            try
            {
                OpenConnection();
                string StrSelect = string.Format(@"SELECT * FROM Produtos");
                using(cmd = new SqlCommand(StrSelect, con))
                {
                    using(Adp = new SqlDataAdapter(cmd))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            Adp.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public Produtos GetProdutos(string id)
        {
            try
            {
                OpenConnection();
                string strSelect = string.Format(@"SELECT Id,Data,Produto,Valor,Estoque FROM Produtos WHERE Id = @id");
                using(cmd =new SqlCommand(strSelect,con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using(Dr = cmd.ExecuteReader())
                    {
                        Produtos mod = null;
                        while (Dr.Read())
                        {
                            mod = new Produtos();
                            mod.Estoque = Convert.ToInt32(Dr["Estoque"]);
                            mod.Data = Convert.ToDateTime(Dr["Data"]);
                            mod.Produto = Convert.ToString(Dr["Produto"]);
                            mod.Valor = Convert.ToDecimal(Dr["Valor"]);
                        }
                        return mod;
                    }
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
