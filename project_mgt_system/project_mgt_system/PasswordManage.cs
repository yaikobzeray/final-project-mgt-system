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
    public partial class PasswordManage : Form
    {
        public PasswordManage()
        {
            InitializeComponent();
        }

        String empId;
        String password;

        private void PasswordManage_Load(object sender, EventArgs e)
        {

        }

        private void button_change_click(object sender, EventArgs e)
        {
            CrudOperations co = new CrudOperations();
            co.updatePassword(empId, password);
            MessageBox.Show("Password reseted succesfully!", "Password reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void button_back_click(object sender, EventArgs e)
        {
      
            this.Hide();
        }

        private void employee_id(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            empId = tb.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            password = tb.Text;
        }
    }
}
