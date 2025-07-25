using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KCTCollege.Views.College
{
    public class IndexModel : PageModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void OnGet()
        {
            // Ideally, this comes from a service
            ID = 1;
            Name = "KCT College";
            Address = "Lokanthali";
        }
    }
}
