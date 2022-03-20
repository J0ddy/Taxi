using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Logic
{
    class UserManager
    {
        private readonly UserData userData = new UserData();
        public List<User> GetAll()
        {
            return userData.GetAll();
        }

        public User Get(int id)
        {
            return userData.Get(id);
        }

        public void Add(User user)
        {
            userData.Add(user);
        }

        public void Update(User user)
        {
            userData.Update(user);
        }

        public void Delete(int id)
        {
            userData.Delete(id);
        }
    }
}
