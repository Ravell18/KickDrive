using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EnergyController.Models;


namespace EnergyController.Services.Controladores
{
    public class ContLogins: SQLRepository<User>, IRepositoryLogins
    {
        public ContLogins(AppDBContext context) : base(context) { }
        public int InsertL(User user)
        {
            if (user == null) throw new ArgumentNullException("Entity");
            entities.Add(user);
            context.SaveChanges();
            return user.Id;
        }

    }
}
