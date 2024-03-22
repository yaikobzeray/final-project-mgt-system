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
    public partial class ProjectDetail : Form
    {
        String pId;
        String key;
        String userId;
        public ProjectDetail(String id,String key, String userId)
          
        {
            this.pId = id;
            this.key = key;
            this.userId = userId;
            InitializeComponent();
        }

        public ProjectDetail(String key, String userId)
        {
            this.key = key;
            this.userId = userId;
            InitializeComponent();
        }







        public void update(String id)
        {
          
            CrudOperations co = new CrudOperations();
            co.updateProject(id,textBox1.Text, richTextBox1.Text, richTextBox2.Text, richTextBox3.Text, richTextBox4.Text, richTextBox5.Text);
        }

        public void insert()
        {
            CrudOperations co = new CrudOperations();
            co.insertProject(textBox1.Text, richTextBox1.Text, richTextBox2.Text, richTextBox3.Text, richTextBox4.Text, richTextBox5.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void ProjectDetail_Load(object sender, EventArgs e)
        {
            if(key == "update" || key == "detail")
            {
                CrudOperations co = new CrudOperations();
                var da = co.fetchFromDb("select * from projects where Id =" + pId);
                while (da.Read())
                {
                    textBox1.Text = da.GetString(1);
                    richTextBox1.Text = da.GetString(2);
                    richTextBox2.Text = da.GetString(3);
                    richTextBox3.Text = da.GetString(4);
                    richTextBox4.Text = da.GetString(5);
                    richTextBox5.Text = da.GetString(6);



                }
            }

            if (key == "detail")
            {
                button3.Enabled = false;
                textBox1.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
                richTextBox3.Enabled = false;
                richTextBox4.Enabled = false;
                richTextBox5.Enabled = false;
            }
            if (key == "insert" || key == "update")
            {
                button1.Enabled = false;
            }

        }

        private void button_back_click(object sender, EventArgs e)
        {
            TeacherDashBoard td = new TeacherDashBoard(userId);
            td.Show();
            this.Hide();
        }

        private void button_save_click(object sender, EventArgs e)
        {
            if(key == "update")
            {
                update(pId);
            }

            if(key == "insert")
            {
                insert();
              
                textBox1.Text = "";
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                richTextBox4.Text = "";
                richTextBox5.Text = "";
            }
            
        }

        private void button_edit_click(object sender, EventArgs e)
        {
            
            button3.Enabled = true;
            key = "update";
            button1.Enabled = false;
            textBox1.Enabled = true;
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = true;
            richTextBox3.Enabled = true;
            richTextBox4.Enabled = true;
            richTextBox5.Enabled = true;
        }
    }
}
