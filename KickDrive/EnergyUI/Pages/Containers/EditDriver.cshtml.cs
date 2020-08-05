using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnergyController.Models;
using EnergyController.Services;
using EnergyController.Services.Controladores;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EnergyUI.Pages.Containers
{
    public class EditDriverModel : PageModel
    {
        [BindProperty]
        public Driver Driver { get;  set; }
        public SelectList Conductores { get; private set; }
        public IWebHostEnvironment HostEnvironment { get; }
        public IFormFile ProfilePhoto { get; set; }
        public  readonly IRepository<Driver> DRepository;
        public EditDriverModel(IRepository<Driver> DRepository, IWebHostEnvironment hostEnvironment)
        {
            this.DRepository = DRepository;
            HostEnvironment = hostEnvironment;
        }
        public void OnGet(int Id)
        {
            Driver = DRepository.Get(Id);
        }
        public IActionResult OnPost(Driver Driver,string button)
        {
            if (!ModelState.IsValid)
                return Page();

            if(button == "Editar")
            {
                if (ProfilePhoto != null)
                {
                    if (!string.IsNullOrEmpty(Driver.ProfilePhoto))
                    {
                        var filePath = Path.Combine(HostEnvironment.WebRootPath, "Images", Driver.ProfilePhoto);
                        System.IO.File.Delete(filePath);
                    }
                    Driver.ProfilePhoto = ProcessUploadFile();
                }
                DRepository.Update(Driver);
            }
            if (button == "Eliminar")
            {
                DRepository.Delete(Driver);
            }

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
