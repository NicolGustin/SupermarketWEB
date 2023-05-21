using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Autenticacion.Models;
using Microsoft.Identity.Client.
    Platforms.Features.DesktopOs.Kerberos;
using SupermarketWEB.Data;

namespace Autenticacion.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnpostAsync() {
            if (!ModelState.IsValid) return Page();
            
            if(User.Email == "correo@gmail.com" && User.Password = "12345")
            {
                return RedirectToPage("/index");
            }
            return Page();
        }
    }
}
