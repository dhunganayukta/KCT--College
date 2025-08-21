using KCT_College.Models;
using KCT_College.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KCT_College.Data
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions<ApplicationdbContext> options)
            : base(options)
        {
        }

        // Example DbSet
        public DbSet<Registration> Registration { get; set; }
        public DbSet<KCT_College.Models.CollegeViewModel> CollegeViewModel { get; set; } = default!;
    }
}
