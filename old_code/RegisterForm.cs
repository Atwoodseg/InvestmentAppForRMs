using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_APP
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstname_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if(fname.ToLower().Trim().Equals("First Name"))
            {
                textBoxFirstname.Text = "";
                textBoxFirstname.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if(fname.ToLower().Trim().Equals("First Name") || fname.Trim().Equals(""))
            {
                textBoxFirstname.Text = "First Name";
                textBoxFirstname.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastname_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("Last Name"))
            {
                textBoxLastname.Text = "First Name";
                textBoxLastname.ForeColor = Color.Black;
            }
        }

        private void textBoxLastname_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("Last Name") || lname.Trim().Equals(""))
            {
                textBoxLastname.Text = "Last Name";
                textBoxLastname.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("Email Address"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("Email Address") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "Email Address";
                textBoxEmail.ForeColor = Color.Black;
            }
        }
    }
}
