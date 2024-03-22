using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mgt_system
{
    public partial class MyConnection
    { 
 
        public SqlConnection createConn()
        {
     string connection_String = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\final-project-mgt-system\project_mgt_system\project_mgt_system\project_mgt.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection msc = new SqlConnection(connection_String);
            msc.Open();
            return msc;
        }

    }
}
