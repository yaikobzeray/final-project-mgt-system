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
    public partial class PasswordReset : Form
    {
        String id;
        public PasswordReset(String id)
        {
            this.id = id;
            InitializeComponent();
        }

        String oldPass;
        String newPass;
        String confPass;

        String getUserPass()
        {
            String userName;
            CrudOperations co = new CrudOperations();
            var da = co.fetchFromDb("select * from employee where empId='" + id + "'");
            while (da.Read())
            {
                userName = da.GetString(1);
                return userName;
            }
            return "";
        }

        private void button1_reset_click(object sender, EventArgs e)
        {
           if(getUserPass() == oldPass)
            {
                if(newPass == confPass)
                {
                    CrudOperations co = new CrudOperations();
                    co.updatePassword(id,newPass);
                    MessageBox.Show("Password reseted succesfully!", "Password reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TeacherDashBoard td = new TeacherDashBoard(id);
                    td.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check the password you've entered!", "Password mis-match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Wrong password entered!", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            oldPass = tx.Text;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            newPass = tx.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            confPass = tx.Text;
        }

        private void button_back_click(object sender, EventArgs e)
        {
            TeacherDashBoard td = new TeacherDashBoard(id);
            td.Show();
            this.Hide();
        }

        private void PasswordReset_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
