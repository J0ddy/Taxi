using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Model
{
    internal class Driver : IUser
    {
        private string _password;
        public int Id { get; set; }
        public string UserName { get; set; }

        //TODO: Handle Hashed Password Securely
        string IUser.Password
        {
            get => _password;
            set => _password = value;
        }

        public string Email { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
    }
}
