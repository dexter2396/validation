using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void username_validation_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            username_validation.Text = "";
            email_validation.Text = "";
            password_validation.Text = "";
            confirmpass_validation.Text = "";

            string username = username_txtbox.Text;
            string email = email_txtbox.Text;
            string password = password_txtbox.Text;
            string confirmpass = confirmpass_txtbox.Text;

            bool IsValid = true;

            if (string.IsNullOrEmpty(username)) 
            {
                username_validation.Text = "Username is required";
                username_validation.Visible = true;
                IsValid = false;
            }

            if (string.IsNullOrEmpty(email)) 
            {
                email_validation.Text = "Email is required";
                email_validation.Visible = true;
                IsValid = false;
            }

            if (string.IsNullOrEmpty(password)) 
            {
                password_validation.Text = "Password is required";
                password_validation.Visible = true;
                IsValid = false;
            }

            if (string.IsNullOrEmpty(confirmpass))
            {
                confirmpass_validation.Text = "Password is required";
                confirmpass_validation.Visible = true;
                IsValid = false;
            }
            else if (password != confirmpass) 
            {
                confirmpass_validation.Text = "Password doesn't match";
                confirmpass_validation.Visible = true;
                IsValid = false;
            }

            if (IsValid) 
            {
                MessageBox.Show("Successfully Registered");
                Person person = new Person();
                person.setUsername(username_txtbox.Text);
                person.setEmail(email_txtbox.Text);
                person.setPassword(password_txtbox.Text);
                person.setConfirmpass(confirmpass_txtbox.Text);

                Form2 form2 = new Form2(person);
                form2.Show();
                this.Hide();

            }



        }

        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {
            username_validation.Text = "";
        }

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {
            email_validation.Text = "";
        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {
            password_validation.Text = "";
        }

        private void confirmpass_txtbox_TextChanged(object sender, EventArgs e)
        {
            confirmpass_validation.Text = "";
        }
    }
}
