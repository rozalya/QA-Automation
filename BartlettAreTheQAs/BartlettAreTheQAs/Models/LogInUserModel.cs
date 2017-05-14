using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Models
{
    public class LogInUserModel
    {
        private string key;
        private string email;
        private string password;
        private string rememberme;
        public LogInUserModel() { }

        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string RememberMe
        {
            get { return this.rememberme; }
            set { this.rememberme = value; }
        }
    }
}
