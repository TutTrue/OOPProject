using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class User
    {
        public string Username { get; }
        public string Password { get; }

        int NumOfUsers = 0;
        public int numOfUsers { get { return NumOfUsers; } }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            NumOfUsers++;
        }
    }
}
