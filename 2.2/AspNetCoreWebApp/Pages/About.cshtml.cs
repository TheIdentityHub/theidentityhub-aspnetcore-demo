using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreWebApp.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        [Authorize]
        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}
