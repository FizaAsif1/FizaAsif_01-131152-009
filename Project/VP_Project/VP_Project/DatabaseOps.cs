using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web;
using System.Data;

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
                String SQLConnectionString = @"Data Source=.;Initial Catalog=resale;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconnection = new SqlConnection(SQLConnectionString);
                sqlconnection.Open();
            }

            return true;
        }

        public bool addUser(string values)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "insert into RegisteredUsers values (@values);";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);
                    cmd.Parameters.AddWithValue("@values", values);
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
        }


        public bool authenticateUser( string email, string password)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "select * from RegisteredUsers where email= @email and password= @password;";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    string output = cmd.ExecuteScalar().ToString();
                    if (output != null)
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string getUsername(string email)
        {
            string name = null;
            try
            {
                if (IsConnect())
                {
                    string query = "select name from RegisteredUsers where email= @email";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);
                    cmd.Parameters.AddWithValue("@email", email);
                    name = cmd.ExecuteScalar().ToString();
                    return name;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return name;
        }

        public DataTable getAllAds()
        {
            DataTable mobileDataTable = new DataTable();
            try
            {
                if (IsConnect())
                {
                    string query = "select * from mobile_ads;";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlconnection);
                    sda.Fill(mobileDataTable);
                    return mobileDataTable;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return mobileDataTable;
        }

        public bool postAd(string values)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "insert into mobile_ads values (@values);";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);
                    cmd.Parameters.AddWithValue("@alues", values);
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
        }

        public string getAdminEmail()
        {
            string email= null;
            try
            {
                if (IsConnect())
                {
                    string query = "select email from admin;";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);
                    email = cmd.ExecuteScalar().ToString();
                    
                    return email;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return email;
        }

        public string getAdminEmailPassword()
        {
            string emailPassword = null;
            try
            {
                if (IsConnect())
                {
                    string query = "select password from admin;";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);
                    emailPassword = cmd.ExecuteScalar().ToString();
                    return emailPassword;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return emailPassword;
        }


        public bool searchByBrand(string brandName)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "select * from mobile_ads where brand= @condition ;";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);
                    cmd.Parameters.AddWithValue("@condition", brandName);

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

        }


        public bool searchByLocation(string condition)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "select * from mobile_ads where location is like ?condition ;";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);
                    cmd.Parameters.AddWithValue("?condition", condition);

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

        }


        public bool searchByTitle(string condition)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "select * from mobile_ads where title like @condition ;";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection);
                    cmd.Parameters.AddWithValue("@condition", condition);

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

        }
    }
}
