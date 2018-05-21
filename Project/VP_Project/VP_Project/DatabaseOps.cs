using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web;

namespace VP_Project
{
    public class DatabaseOps 
    {
        
        private SqlConnection sqlconnection = null;
        private static DatabaseOps connection;
        public static DatabaseOps ConnObject
        {
            get
            {
                if (connection == null)
                    connection = new DatabaseOps();
                return connection;
            }
        }
        private DatabaseOps()
        {

        }

        public bool IsConnect()
        {
            if (sqlconnection == null)
            {
                String SQLConnectionString = @"Data Source=WINDOWS-AHS95GR;Initial Catalog=resale;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconnection = new SqlConnection(SQLConnectionString);
                sqlconnection.Open();
            }

            return true;
        }

        public bool insertRecord(string values, string tableName)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "insert into " + tableName + " values (" + values + ");";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);

                    string output = cmd.ExecuteNonQuery().ToString();
                    if (output == "1")
                        return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }


        public bool authenticateUser(string tableName, string condition)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "select * from " + tableName + " where " + condition + ";";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);

                    string output = cmd.ExecuteNonQuery().ToString();
                    if (output == "-1")
                        return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;

        }

    }
}
