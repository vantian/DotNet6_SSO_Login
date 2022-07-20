using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSO_Login.Pages
{
    [Authorize]
    public class MyAccountModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
