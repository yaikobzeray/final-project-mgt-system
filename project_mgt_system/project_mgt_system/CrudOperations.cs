using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            String query = "DELETE FROM projects WHERE Id = " + id;
            SqlCommand cmd = new SqlCommand(query, conn.createConn());
            return cmd.ExecuteNonQuery();

        }

        public int deleteEmployee(String id)
        {
            MyConnection conn = new MyConnection();
            String query = "DELETE FROM employee  WHERE empId = '" + id + "' ";
            SqlCommand cmd = new SqlCommand(query, conn.createConn());
            return cmd.ExecuteNonQuery();

        }

        public void updateProject(String id, String title, String problem, String objective, String scope, String tools, String developers) {

            MyConnection conn = new MyConnection();
           String query = "UPDATE projects SET project_title = '" + title + "', problem = '" + problem + "', objective = '" + objective + "', scope = '" + scope + "', tools = '" + tools + "', developers = '" + developers + "' WHERE Id = '" + id + "' ";
            //string query = "UPDATE Student SET project_title = @title, problem = @problem, objective = @objective, scope = @scope, tools = @tools, developers = @developers WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn.createConn());
            try
            {
       cmd.ExecuteNonQuery();
                MessageBox.Show("Project Successfully Updated!!!");
                
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }

       
        }
        public void updatePassword(String id,String password)
        {

            MyConnection conn = new MyConnection();
            String query = "UPDATE employee SET password = '" + password + "' WHERE empId = '" + id + "' ";
            //string query = "UPDATE Student SET project_title = @title, problem = @problem, objective = @objective, scope = @scope, tools = @tools, developers = @developers WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn.createConn());
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Successfully Updated!!!");

            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }


        }

        public void insertProject(String title, String problem, String objective, String scope, String tools, String developers)
        {

            MyConnection conn = new MyConnection();
            string query = "insert into projects values('" + title + "', '" + problem + "','" + objective + "', '" + scope + "', '" + tools +"', '" + developers + "')";

            SqlCommand cmd = new SqlCommand(query, conn.createConn());
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project Successfully inserted!!!");

            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
            
           

        }
        public void insertEmployee(String empId, String fullName, String department, String phone)
        {
            MyConnection conn = new MyConnection();
            string query = "insert into employee (empId,password,full_name,faculity,phone) values('" + empId + "', '" + "0000" + "', '" + fullName + "','" + department + "', '" + phone + "')";

            SqlCommand cmd = new SqlCommand(query, conn.createConn());
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("employee Successfully inserted!!!");

            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }


        public void updateEmployee(String id, String fullName, String faculty, String phone)
        {

            MyConnection conn = new MyConnection();
            String query = "UPDATE employee SET full_name = '" + fullName + "', faculity = '" + faculty + "', phone = '" + phone + "' ";
            SqlCommand cmd = new SqlCommand(query, conn.createConn());
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project Successfully Updated!!!");

            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }


        }
    }
}
