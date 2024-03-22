using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mgt_system
{
    public partial class TeacherDashBoard : Form
    {
        DataGridView dataGV;

        public TeacherDashBoard()
        {
            
            InitializeComponent();
        }


       
        
        private void DeleteSelectedItems()
        {
            // Iterate through all items in the ListView
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.Items[i];

                // Check if the item's checkbox is checked
                if (item.Checked)
                {
                    CrudOperations co = new CrudOperations();
                    co.deleteProject(item.SubItems[0].Text);

                    //Remove the item from the ListView
                    listView1.Items.Remove(item);
                    
                    

                  
                }
            }
        }

        String selectedItem()
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.Items[i];
                // Check if the item's checkbox is checked
                if (item.Checked)
                {
                    return  item.SubItems[0].Text;
                }
            }
            return "";
        }


       

        private void button_login_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TeacherDashBoard_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Name", 120);
            listView1.Columns.Add("Statement Problem", 150);
            listView1.Columns.Add("Objective", 150);
            listView1.Columns.Add("Tools", 150);
            listView1.Columns.Add("Scope", 150);
            CrudOperations co = new CrudOperations();
            var da = co.fetchFromDb("select * from projects");

            while (da.Read())
            {
                var item1 = listView1.Items.Add(da[0].ToString());
                item1.SubItems.Add(da[1].ToString());
                item1.SubItems.Add(da[2].ToString());
                item1.SubItems.Add(da[3].ToString());
                item1.SubItems.Add(da[4].ToString());
                item1.SubItems.Add(da[5].ToString());
            }
        }

        private void detail_click(object sender, EventArgs e)
        {

        }


        private void insert_click(object sender, EventArgs e)
        {
            
        }

        private void delete_click(object sender, EventArgs e)
        {
            DeleteSelectedItems();
        }

        private void update_click(object sender, EventArgs e)
        {

            ProjectDetail pd = new ProjectDetail(selectedItem());
            pd.Show();
            this.Hide();
        }
    }
}
