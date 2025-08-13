
using KCT_College.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KCT_College.Data
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext( DbContextOptions<ApplicationdbContext> options ) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
