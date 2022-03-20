

namespace Taxi.Data.Models
{
    public  class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int DriverId { get; set; }
        public int CompanyId { get; set; }
        public string Password { get; set; }

        public  Company Company { get; set; }
        public  Driver Driver { get; set; }

        public User(int userId, string username, string email, string password, int driverId, int companyId)
        {
            this.UserId = userId;
            this.UserName = username;
            this.Email = email; 
            this.Password = password;
            this.DriverId = driverId;
            this.CompanyId = companyId;
           
        }
    }
}
