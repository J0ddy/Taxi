using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Model
{
    interface IUser
    {
        int Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string FistName { get; set; }
        string LastName { get; set; }
    }
}