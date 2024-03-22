namespace project_mgt_system
{
    partial class TeacherDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.changepassword = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.detail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // changepassword
            // 
            this.changepassword.BackColor = System.Drawing.Color.Purple;
            this.changepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepassword.ForeColor = System.Drawing.Color.White;
            this.changepassword.Location = new System.Drawing.Point(755, 67);
            this.changepassword.Name = "changepassword";
            this.changepassword.Size = new System.Drawing.Size(218, 41);
            this.changepassword.TabIndex = 20;
            this.changepassword.Tag = "2";
            this.changepassword.Text = "change password";
            this.changepassword.UseVisualStyleBackColor = false;
            this.changepassword.Click += new System.EventHandler(this.button_changepass_click);
            // 
            // Update
            // 
            this.Update.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Update.BackColor = System.Drawing.Color.Purple;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(33, 291);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(131, 41);
            this.Update.TabIndex = 20;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.update_click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Purple;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(33, 223);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(131, 41);
            this.insert.TabIndex = 20;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.button_insert_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(33, 354);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 41);
            this.button5.TabIndex = 20;
            this.button5.Tag = "1";
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.delete_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 56);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(825, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher\'s Dashboard";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher\'s Dashboard";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LavenderBlush;
            this.listView1.CheckBoxes = true;
            this.listView1.ForeColor = System.Drawing.Color.Indigo;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(193, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(780, 457);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // detail
            // 
            this.detail.BackColor = System.Drawing.Color.Purple;
            this.detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail.ForeColor = System.Drawing.Color.White;
            this.detail.Location = new System.Drawing.Point(33, 161);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(131, 41);
            this.detail.TabIndex = 20;
            this.detail.Text = "Detail";
            this.detail.UseVisualStyleBackColor = false;
            this.detail.Click += new System.EventHandler(this.button_detail_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(853, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teacher\'s Dashboard";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // TeacherDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(985, 595);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.changepassword);
            this.Controls.Add(this.button1);
            this.Name = "TeacherDashBoard";
            this.Text = "TeacherDashBoard";
            this.Load += new System.EventHandler(this.TeacherDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button changepassword;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}