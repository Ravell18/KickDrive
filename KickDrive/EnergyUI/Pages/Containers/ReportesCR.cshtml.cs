using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnergyController.Models;
using EnergyController.Services;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using System.IO;

namespace EnergyUI.Pages.Containers
{
    public class ReportesCRModel : PageModel
    {

        
        private readonly IRepository<ReportRoute> repository;

        public IEnumerable<ReportRoute> reportRoutes { get; private set; }


        public ReportesCRModel(IRepository<ReportRoute> repository)
        {
            this.repository = repository;

        }
        public IActionResult OnGet()
        {
            try
            {
                reportRoutes = repository.GetAll();
                return Page();
            }
            catch (Exception ex)
            {
                return RedirectToPage($"/NotFount");
            }
        }

    }
}