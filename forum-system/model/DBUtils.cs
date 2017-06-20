using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model
{
    public class DBUtils
    {
        static readonly string localPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        private static readonly string pathToDb = localPath + @"\Data\forums.accdb";
        OleDbConnection conn;

        public DBUtils()
        {
            string connectionString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source="+pathToDb+"; " +
            @"User Id=;Password=;";

            conn = new OleDbConnection(connectionString);

        }

        public OleDbDataReader select(string query)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, this.conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }
            
           
        }

        public bool insert(string query)
        {
            bool ans = false;
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return ans;
        }
    }
}
