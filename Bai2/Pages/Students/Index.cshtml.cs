using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bai2.Data;
using Bai2.Models;

namespace Bai2.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Bai2.Data.SchoolContextDB _context;

        public IndexModel(Bai2.Data.SchoolContextDB context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
