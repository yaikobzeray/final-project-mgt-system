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
        public ProjectDetail(String id)
          
        {
            this.pId = id;
            InitializeComponent();
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
            CrudOperations co = new CrudOperations();
            var da = co.fetchFromDb("select * from projects where Id =" + pId);
            while (da.Read())
            {
                textBox1.Text = da.GetString(1);
            }
        }
    }
}
