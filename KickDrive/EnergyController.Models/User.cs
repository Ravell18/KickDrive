using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EnergyController.Models
{
    [Table("Users")]
    public class User :BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
