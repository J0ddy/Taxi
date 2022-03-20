using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Views
{
    class DisplayUsers
    {
     private   UserData userData;
       private List<User> users;
        public DisplayUsers()
        {
            Output();
        }

        private void Output()
        {
            userData = new UserData();
            users = userData.GetAll();
            ListAll();
        }
        public DisplayUsers(int id)
        {
            OutputById(id);
        }
        
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "Users" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            users = userData.GetAll();
            foreach (var item in users)
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.UserId,item.UserName, item.Email, item.Password, item.DriverId, item.CompanyId);
        }

        private void OutputById(int id)
        {

        }
    }
}
