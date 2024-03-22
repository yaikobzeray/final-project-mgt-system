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
    public partial class EmployeeDetail : Form
    {
        String key;
        String id;
        public EmployeeDetail(String id,String key)
        {
            this.id = id;
            this.key = key;
            InitializeComponent();
        }
        public EmployeeDetail(String key)
        {
            this.key = key;
            InitializeComponent();
        }
       
        private void ProjectDetail_Load(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            if (key == "update")
            {
                textBox1.Enabled = false;
                CrudOperations co = new CrudOperations();
                var da = co.fetchFromDb("select * from employee  WHERE empId = '" + id + "' ");
                while (da.Read())
                {
                    textBox1.Text = da.GetString(0);
                    textBox2.Text = da.GetString(2);
                    textBox3.Text = da.GetString(3);
                    textBox4.Text = da.GetString(4);

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please fill the text box!", "No blank text box", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(key == "insert")
            {
                CrudOperations co = new CrudOperations();
                co.insertEmployee(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }

            if(key == "update")
            {
          
                CrudOperations co = new CrudOperations();
                co.updateEmployee(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                

            }
           
        }

        private void button_back_click(object sender, EventArgs e)
        {
            AdminSite a = new AdminSite();
            a.Show();
            this.Hide();

        }
    }
}
