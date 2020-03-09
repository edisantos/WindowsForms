using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace samsung.refacco.Data.Data
{
    public class DataFactory
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataAdapter Adp;
        protected SqlDataReader Dr;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConnection()
        {
            try
            {
                string StrCon = ConfigurationManager.ConnectionStrings["StrConnection"].ConnectionString;
                con = new SqlConnection(StrCon);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SqlConnection CloseConnection()
        {
            try
            {
               
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                }
                return con;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
