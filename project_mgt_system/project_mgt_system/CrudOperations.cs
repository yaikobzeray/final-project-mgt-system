using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mgt_system
{
  public  class CrudOperations
    {
        public DataTable ExecuteQuery(string query, SqlConnection scon)
        {
          
            SqlCommand com = new SqlCommand(query, scon);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader fetchFromDb(String query)
        {
            MyConnection conn = new MyConnection();
            //conn.Open();
            CrudOperations co = new CrudOperations();

            SqlCommand cmd = new SqlCommand(query, conn.createConn());
            SqlDataReader da;
            da = cmd.ExecuteReader();
            return da;
        }

        public int deleteProject(String id)
        {
            MyConnection conn = new MyConnection();
            //String query = "delete from employee where empId='" + item.SubItems[0].Text + "'";
            String query = "DELETE FROM projects WHERE Id = " + id;
            SqlCommand cmd = new SqlCommand(query, conn.createConn());
            return cmd.ExecuteNonQuery();

        }



    }
}
