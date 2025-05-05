using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSimulation
{
    public class User
    {
        public string Username {  get; set; }
        public string Password { get; set; }

        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }
    }
}
