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

namespace RM_App
{
    public partial class LoginForm : Form

    {
        private string conn;
        private SqlCommand query;
        private object return_false;

        public LoginForm()
        {
            InitializeComponent();
        }


        private SqlCommand GetQuery()
        {
            return query;
        }

        private void button1_Login(object sender, EventArgs e, SqlCommand query)
        {
            if ((bool)isValid())
            {
                // using (var conn = new SqlConnection(@"Data Source=(localDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")) ;
                // query = "SELECT PASSWORD FROM LOGIN WHERE Username ='" + textUserName.Text. "'"; //query SELECT PASSWORD WHERE USERNAME IS username.txt
                // SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                // DataTable dta = new DataTable();
                //sda.Fill(dta);
                //if (dta.Rows.Count == 1)
                // {
                //     Form1 form1 = new Form1();
                // this.Hide();
                //     form1.Show();
                //  }
                //  }

            }
        }

        private object isValid()
        {
            if (textUserName.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid user name please!", "Error");
                object return_false1 = return_false;
            }
            else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid password please!", "Error");
                return false;
            }
            return true;
        }

        private static void textUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
