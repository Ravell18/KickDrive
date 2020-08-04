using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace EnergyController.Services.Controladores
{
    public class ContReportR: SQLRepository<ReportRoute>, IRepositoryReportR
    {
        public ContReportR(AppDBContext context) : base(context) { }
        public int InsertRR(ReportRoute reportRoute)
        {
            if (reportRoute == null) throw new ArgumentNullException("Entity");
            entities.Add(reportRoute);
            context.SaveChanges();
            return reportRoute.Id;
        }
        public Task SendEmailAsync(ReportRoute reporte)
        {
            try
            {
                var credentials = new NetworkCredential("KickDrive69@gmail.com", "cuenta12");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("kickdrive69@gmail.com", reporte.DriverName),
                    Subject = reporte.Ruta,
                    Body = reporte.Message,
                    IsBodyHtml = true
                };

                mail.To.Add(new MailAddress(reporte.Email));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };

                // Send it...         
                client.Send(mail);
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }

            return Task.CompletedTask;
        }
        public IEnumerable<ReportRoute> GetReportRoutes()
        {
            return context.Set<ReportRoute>().AsEnumerable();
        }
    }
}
