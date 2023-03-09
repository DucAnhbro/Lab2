using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bai1.Pages
{
    public class CustomerFormModel : PageModel
    {
        public string Mesage { get; set; }
        [BindProperty]
        public CustomerFormModel customerInfo { get; set; }
        public void OnGet()
        {
            if (ModelState.IsValid)
            {
                Mesage = "Information is OK";
                ModelState.Clear();
            }
            else
            {
                Mesage = "Error on input data.";
            }
        }
    }
}
