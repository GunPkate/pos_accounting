using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace POSAccount.Database
{
    class Databaselayer
    {
        public static SqlConnection conn;

        public static SqlConnection ConOpen() {
            if (conn == null) {
                conn = new SqlConnection(@"Data Source=.\SqlExpress;Initial Catalog=POS_ACCOUNT;Integrated Security=True");
            }

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public static bool Insert(string query) {
            try
            {
                SqlCommand cmd = new SqlCommand(query,ConOpen());
                int recordcount = cmd.ExecuteNonQuery();
                if (recordcount > 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool Update(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConOpen());
                int recordcount = cmd.ExecuteNonQuery();
                if (recordcount > 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool Delete(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConOpen());
                int recordcount = cmd.ExecuteNonQuery();
                if (recordcount > 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static DataTable Select(string query)
        {
            DataTable dt;
            try
            {
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, ConOpen());
                da.Fill(dt);
                return dt;

                if (dt == null)
                {
                    return null;
                }
                else if (dt.Rows.Count > 0) {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
