using KCT_College.Interface;
using KCT_College.Models;

namespace KCT_College.Services
{
    public class CollegeClass : CollegeInterface

    {


        public Class GetInfo()
        {
            Class details = new Class
            {
                Id = 1,
                Name = "KCT College",
                Address = "Lokanthali"
            };

            return details;
        }
    }
}

