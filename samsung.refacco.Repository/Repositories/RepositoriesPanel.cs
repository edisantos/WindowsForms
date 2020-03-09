using samsung.refacco.Data.Data;
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
    }
}
