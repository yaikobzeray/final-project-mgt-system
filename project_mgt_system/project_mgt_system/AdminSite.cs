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
    public partial class AdminSite : Form
    {
        public AdminSite()
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
                    co.deleteEmployee(item.SubItems[0].Text);

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
                    return item.SubItems[0].Text;
                }
            }
            return "";
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void button_logout_click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button_insert_click(object sender, EventArgs e)
        {
            EmployeeDetail ed = new EmployeeDetail("insert");
            ed.Show();
            this.Hide();

            
        }

        private void button_update_click(object sender, EventArgs e)
        {
            if (selectedItem() == "")
            {
                if (MessageBox.Show("Please select item!", "No selected Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    return;
                }

            }
            else
            {
                EmployeeDetail ed = new EmployeeDetail(selectedItem(), "update");
                ed.Show();
                this.Hide();
            }
         
        }

        private void button_delete_click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Delete Employee",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DeleteSelectedItems();
            }
            
        }

        private void button_changePass_click(object sender, EventArgs e)
        {
            PasswordManage pm = new PasswordManage();
            pm.Show();
        }

        private void AdminSite_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("ID", 250);
            listView1.Columns.Add("Full Name", 250);
            listView1.Columns.Add("Department", 250);
            listView1.Columns.Add("Phone", 250);
            CrudOperations co = new CrudOperations();
            var da = co.fetchFromDb("select * from employee");

            while (da.Read())
            {
                var item1 = listView1.Items.Add(da[0].ToString());
             
                item1.SubItems.Add(da[2].ToString());
                item1.SubItems.Add(da[3].ToString());
                item1.SubItems.Add(da[4].ToString());


            }
        }
    }
}
