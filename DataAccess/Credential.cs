using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    class Credential
    {

        public bool isgranted(string uname, string pass)
        {
            bool permission=false;
            DatabaseConnection databaseConnection = new DatabaseConnection();
            try
            {
                
                databaseConnection.Cmd.CommandText = "SELECT *FROM adminpanel WHERE admin_loginid = @UName and apassword = @UPass";
                databaseConnection.Cmd.Parameters.Add("@UName", SqlDbType.VarChar, 16).Value = uname;
                databaseConnection.Cmd.Parameters.Add("@UPass", SqlDbType.VarChar, 20).Value = pass;

               
                SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.Cmd);

                DataTable datatable = new DataTable();
                //dataAdapter.Fill(dataSet, "SSUser");
                //DataTable userTable = dataSet.Tables["SSUser"];
                
                dataAdapter.Fill(datatable);
                if (datatable.Rows.Count == 1)
                {
                    permission = true;
                }
                else
                {
                    permission = false;
                }

            }
            catch (Exception exception)
            {
                
            }
            finally
            {
                
            }
            return permission;
        }
    }

}

