using Bai1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bai1.Pages
{
    public class CustomerFormModel : PageModel
    {
        public string Mesage { get; set; }
        [BindProperty]
        public Models.Customer customerInfo { get; set; }
        public void OnPost()
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
