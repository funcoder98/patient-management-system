using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace contactus.Pages
{
    public class contactModel : PageModel
    {

        public bool hasData = false;
        public string Fullname = "";
        public string Email = "";
        public string message = "";

        public void OnGet()
        {
        }
        public void OnPost()
        {
            hasData = true;
            Fullname = Request.Form["Fullname"];
            Email = Request.Form["Email"];
            message = Request.Form["message"];
        }

    }
}
