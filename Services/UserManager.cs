using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//handels user storage and chacking login/register
namespace BankingSimulation
{
    public static class UserManager
    {
        public static List<User> Users=new List<User>();
        public static bool Register(string username, string password)
        {
            if(Users.Any(u => u.Username == username)) 
                return false;
            Users.Add(new User(username, password));
                return true;
        }
        public static User Authenticate(string username, string password)
        {
            return Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
