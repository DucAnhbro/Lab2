using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Bai1.Pages
{
    public class UploadFilesModel : PageModel
    {
        
        private IHostingEnvironment _environment;
        public UploadFilesModel(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        [Required(ErrorMessage ="Please choose at least one file.")]
        [DataType(DataType.Upload)]
        [FileExtensions(Extensions ="png,jpg,jpeg,gif")]
        [Display(Name ="Choose file(s) to upload")]
        [BindProperty]
        public IFormFile[] FileUploads { get; set; }
        public async void OnPostAsync()
        {
            foreach(var FileUpload in FileUploads)
            {
                var file = Path.Combine(_environment.ContentRootPath, "Images", FileUpload.FileName);
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    await FileUpload.CopyToAsync(fileStream);
                }
            }
        }
    }
}
