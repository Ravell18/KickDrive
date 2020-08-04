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
    public class ContValidar: SQLRepository<User>, IRepositoryValidar
    {
        public  ContValidar(AppDBContext context):base(context) { }
        public IEnumerable<User> GetUser()
        {
            return context.Set<User>().AsEnumerable();
        }

        public int Validar(User users)
        {
         
           var cuentas=  context.Users.ToList();
            int i = 0;
            foreach (var items in cuentas)
            {
                if (users.UserName == items.UserName && users.Password == items.Password)
                {
                    i = items.Id;
                    break;
                }

            }
            return i;
        } 
    }
}
