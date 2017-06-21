using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model
{
    public class DBUtils
    {
        static readonly string localPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        private static readonly string pathToDb = localPath + @"\model\database\forums.accdb";
        OleDbConnection conn;

        public DBUtils()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathToDb + "; Persist Security Info=False";
            conn = new OleDbConnection(connectionString);
            conn.Close();

        }

        public OleDbDataReader select(string query)
        {
            try
            {
                openConnection();
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
                
            }
            
        }

        public bool insert(string query)
        {
            bool ans = false;
            try
            {
                openConnection();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                
            }
            return ans;
        }

        private void openConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
        }
    }
}
