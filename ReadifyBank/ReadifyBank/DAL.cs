using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace ReadifyBank
{
    public class DAL
    {
        GlobalSettings gs = new GlobalSettings();

        public static String GetConnectionString()
        {
            String l_ConnectionString = "Data Source=JVSBANMELS01;Initial Catalog=Readify;User ID=sa;Password=Multimedia@2015";
            return l_ConnectionString;
        }

        public Boolean GetUser(Int64 CustID, string Password) {

            SqlConnection l_Connection = null;
            SqlCommand l_Command = null;
            String l_ConnectionString = DAL.GetConnectionString();
            String l_Sql = "";
            int result;

            try
            {
                if (String.IsNullOrEmpty(l_ConnectionString))
                    throw new Exception("Could not find the connection string");

                l_Connection = new SqlConnection(l_ConnectionString);
                l_Connection.Open();
                l_Command = l_Connection.CreateCommand();

                l_Sql = "Select count(*) from Users where CustID = " + CustID + " and Password = '" + Password + "'";
                l_Command.CommandText = l_Sql;
                l_Command.CommandType = CommandType.Text;
                l_Command.Connection = l_Connection;

                result = Convert.ToInt32(l_Command.ExecuteScalar());

                if (result == 1)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                if (l_Connection != null)
                {
                    l_Connection.Close();
                    l_Connection = null;
                }
            }
            return false;
        }

        public DataSet GetAccounts(Int64 CustID)
        {
            SqlConnection l_Connection = null;
            String l_ConnectionString = DAL.GetConnectionString();
            String l_Sql = "";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
                         
            try
            {
                if (String.IsNullOrEmpty(l_ConnectionString))
                    throw new Exception("Could not find the connection string");

                l_Connection = new SqlConnection(l_ConnectionString);
                l_Sql = "Select AccNo from Account where CustID = " + CustID;
                SqlCommand l_Command = new SqlCommand(l_Sql, l_Connection);
                l_Command.CommandText = l_Sql;
                l_Connection.Open();

                da.SelectCommand = l_Command;
                da.Fill(ds); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                if (l_Connection != null)
                {
                    l_Connection.Close();
                    l_Connection = null;
                }
            }
            return ds;
        }
    }
}
