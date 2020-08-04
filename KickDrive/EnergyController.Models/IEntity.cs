using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyController.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAT { get; set; }
        public DateTime? UpdateAT { get; set; }
    }
}
