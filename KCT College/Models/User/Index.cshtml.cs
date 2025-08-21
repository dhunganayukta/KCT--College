using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KCT_College.Data;
using KCT_College.Models;

namespace KCT_College.Models.User
{
    public class IndexModel : PageModel
    {
        private readonly KCT_College.Data.ApplicationdbContext _context;

        public IndexModel(KCT_College.Data.ApplicationdbContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Registration = await _context.Registration.ToListAsync();
        }
    }
}
