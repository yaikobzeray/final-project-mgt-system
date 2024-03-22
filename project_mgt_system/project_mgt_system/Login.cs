using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mgt_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        TeacherDashBoard td = new TeacherDashBoard();
        String userId = "";
        String userPass = "";

        void login(String id, String password)
        {
            MyConnection conn = new MyConnection();
            CrudOperations co = new CrudOperations();
            String query = "select * from employee where empId='" + id + "'and password='" + password + "'";



            if (co.ExecuteQuery(query,conn.createConn()).Rows.Count > 0)
            {
                //td.showListOfProjects();

                td.Show();
               
                this.Hide();

            }
            else
            {
                MessageBox.Show("wrong password or user id inserted!","wrong credentials",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
        
        private void textBox_usrname_TextChanged(object sender, EventArgs e)
        {
            TextBox textBopx = (TextBox)sender;
            userId = textBopx.Text;        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

            TextBox textBopx = (TextBox)sender;
            userPass = textBopx.Text;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(userId != "" || userPass != "")
            {
                //try
                //{
                    login(userId, userPass);

                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("unknown error occured please try again!", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                //}
            }
            else
            {
                MessageBox.Show("empty password or user id is invalid please insert!", "wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
    }
}
