using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnergyController.Models;
using EnergyController.Services;
using EnergyController.Services.Controladores;


namespace EnergyUI.Pages.Containers
{
    public class Index2Model : PageModel
    {
        [BindProperty]
        public ReportRoute Reporte { get; private set; }
        public IRepositoryReportR repositoryReportR;

        public Index2Model(IRepositoryReportR repositoryReportR)
        {
            this.repositoryReportR = repositoryReportR;
        }
        public IActionResult OnPost(ReportRoute reporte)
        {

            repositoryReportR.SendEmailAsync(reporte);

            return Page();
        }
    }
}