using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login_and_Registration_System
{
    public partial class LoginForm1 : Form
    {
        /*
         we need to download the mysql connector
        * add the connector to our project
        * create a connectionnow with mysql
        * open xampp and start mysql & apache
        * go to php
        */
        public LoginForm1()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Width, 50);
        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.database1DataSet.Login);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           // DBConnectionClass db = new DBConnectionClass();

            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            DataTable table = new DataTable();


           
         //check if the user exists or not

           if (table.Rows.Count > 0)
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("NO");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
