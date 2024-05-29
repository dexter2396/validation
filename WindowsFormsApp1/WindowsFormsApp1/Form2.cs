using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Person person;
        public Form2(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            username_txt.Text = person.getUsername();
            email_txt.Text = person.getEmail();
            password_txt.Text = person.getPassword();
        }
    }
}
