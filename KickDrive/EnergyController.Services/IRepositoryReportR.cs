using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Services.Controladores;
using EnergyController.Models;
using System.Threading.Tasks;

namespace EnergyController.Services
{
     public interface IRepositoryReportR
    {
        public int InsertRR(ReportRoute reportRoute);
        public Task SendEmailAsync(ReportRoute Reporte);
    }
}
