using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyController.Models
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreateAT { get; set; } = DateTime.Now;
        public DateTime? UpdateAT { get; set; }
        public bool Status { get; set; }
    }
}
