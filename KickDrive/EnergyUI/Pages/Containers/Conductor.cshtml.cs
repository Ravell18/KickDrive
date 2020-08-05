using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using EnergyController.Services;
using EnergyController.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EnergyUI.Pages.Containers
{
    public class Index5Model : PageModel
    {
        [BindProperty]
        public Driver Driver { get; set; }
        
        public IFormFile ProfilePhoto { get; set; } 
        public IRepository<Driver> repository;
        public IWebHostEnvironment HostEnvironment { get; }

        public Index5Model(IRepository<Driver> repository,IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
        }

        public IActionResult OnPost(Driver Driver)
        {
            if (!ModelState.IsValid)
                return Page();

            if (ProfilePhoto != null)
            {
                if (!string.IsNullOrEmpty(Driver.ProfilePhoto))
                {
                    var filePath = Path.Combine(HostEnvironment.WebRootPath, "Images", Driver.ProfilePhoto);
                    System.IO.File.Delete(filePath);
                }
                Driver.ProfilePhoto = ProcessUploadFile();
            }
            var Id = repository.Insert(Driver);

            return RedirectToPage($"/Containers/CDriver");
        }

        private string ProcessUploadFile()
        {
            if (ProfilePhoto == null)
                return string.Empty;

            var uploadFolder = Path.Combine(HostEnvironment.WebRootPath, "Images");
            var fileName = $"{Guid.NewGuid()}_{ProfilePhoto.FileName}";
            var filePath = Path.Combine(uploadFolder, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                ProfilePhoto.CopyTo(stream);
            }
            return fileName;
        }
       

    }
}