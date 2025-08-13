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
    }
}

