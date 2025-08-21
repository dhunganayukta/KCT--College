using KCT_College.Interface;
using KCT_College.Models;

namespace KCT_College.Services
{
    public class CollegeService : ICollegeService
    {
        public CollegeViewModel GetInfo()
        {
            CollegeViewModel details = new CollegeViewModel();

            details.Id = 1;
            details.Name = "KCT College";
            details.Address = "Lokanthali";
        

            return details;
        }


        public List<Registration> GetRegistrations()
        {
            List<Registration> registration = new List<Registration>
            {
                new Registration { ID = 1, Name = "Yukta", Description = "Student", Address = "Gwarko", city = "Kathmandu", Phone = "1234567890" },
                new Registration { ID = 2, Name = "Nitu", Description = "Student", Address = "Balkot", city = "Bhaktapur", Phone = "0987654321" }
            };
            return registration;
        }
    }
}

