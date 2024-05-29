using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person
    {
        string username;
        string email;
        string password;
        string confirmpass;
        public Person()
        {
            
        }

        public void setUsername(string username) 
        {
            this.username = username;
        }

        public string getUsername() 
        {
            return username;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail() 
        {
            return email;
        }

        public void setPassword(string password) 
        {
            this.password = password;
        }

        public string getPassword() 
        {
            return password;
        }

        public void setConfirmpass(string confirmpass) 
        {
            this.confirmpass = confirmpass;
        }

        public string getConfirmpass() 
        {
            return confirmpass;
        }
    }
}
