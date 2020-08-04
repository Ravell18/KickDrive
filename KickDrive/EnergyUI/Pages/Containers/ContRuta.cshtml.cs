using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyController.Models;
using EnergyController.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnergyUI.Pages.Containers
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Routes Routes { get; set; }
        public IRepositoryRoute repositoryRoute;

        public IndexModel(IRepositoryRoute repositoryRoute)
        {
            this.repositoryRoute = repositoryRoute;
        }

        public void OnPost()
        {
            repositoryRoute.InsertR(Routes);
        }
    }
}