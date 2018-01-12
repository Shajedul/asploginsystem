using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
     class DatabaseConnection
    {
        internal readonly SqlConnection _con;
        internal SqlCommand Cmd= new SqlCommand();

        public DatabaseConnection()
        {
            _con = new SqlConnection(@"Data Source=SHUVO\SQLEXPRESS;Initial Catalog=IslahGroupDB;Integrated Security=True");
            Cmd.Connection = _con;
            
           
        }


        public SqlConnection openConnection()
        {
            if (_con.State == ConnectionState.Closed || _con.State == ConnectionState.Broken)
            {
               _con.Open();
            }
            return _con;
        }



    }
}
