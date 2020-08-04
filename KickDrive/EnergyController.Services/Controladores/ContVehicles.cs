using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using EnergyController.Services;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EnergyController.Services.Controladores
{
    public class ContVehicles : SQLRepository<Vehicles>, IRepositoryVehicles
    {
        public ContVehicles(AppDBContext context) : base(context) { }
        public int InsertS(Vehicles vehicles)
        {
            if (vehicles == null) throw new ArgumentNullException("Entity");
            entities.Add(vehicles);
            context.SaveChanges();
            return vehicles.Id;
        }
        public IEnumerable<Vehicles> GetVehicles()
        {
            return context.Set<Vehicles>().AsEnumerable();
        }
        public Vehicles Updates(Vehicles Vehicle)
        {
            var temp = context.Vehicle.FirstOrDefault(x => x.Id == Vehicle.Id)?? new Vehicles();
            if (temp.Id == 0)
                return temp;
            temp.Id = Vehicle.Id;
            temp.NProp = Vehicle.NProp;
            temp.Brand = Vehicle.Brand;
            temp.NSerie = Vehicle.NSerie;
            temp.Model = Vehicle.Model;
            temp.TipServ = Vehicle.TipServ;
            temp.NMotor = Vehicle.NMotor;
            temp.TComb = Vehicle.TComb;
            temp.DocLeg = Vehicle.DocLeg;
            temp.TipLlantas = Vehicle.TipLlantas;
            temp.CapPerson = Vehicle.CapPerson;
            temp.CapTon = Vehicle.CapTon;
            temp.Placas = Vehicle.Placas;
            temp.OfExp = Vehicle.OfExp;
            temp.NRegist = Vehicle.NSerie;
            temp.Status = Vehicle.Status;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public Vehicles Deletes(Vehicles Vehicle)
        {
            var temp = context.Vehicle.FirstOrDefault(x => x.Id == Vehicle.Id) ?? new Vehicles();
            if (temp.Id == 0)
                return temp;
            temp.Id = Vehicle.Id;
            temp.NProp = Vehicle.NProp;
            temp.Brand = Vehicle.Brand;
            temp.NSerie = Vehicle.NSerie;
            temp.Model = Vehicle.Model;
            temp.TipServ = Vehicle.TipServ;
            temp.NMotor = Vehicle.NMotor;
            temp.TComb = Vehicle.TComb;
            temp.DocLeg = Vehicle.DocLeg;
            temp.TipLlantas = Vehicle.TipLlantas;
            temp.CapPerson = Vehicle.CapPerson;
            temp.CapTon = Vehicle.CapTon;
            temp.Placas = Vehicle.Placas;
            temp.OfExp = Vehicle.OfExp;
            temp.NRegist = Vehicle.NRegist;
            temp.Status = Vehicle.Status;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public Vehicles GetVehicles(int Id)
        {
            return context.Vehicle.FirstOrDefault(x => x.Id == Id);
        }
        public IEnumerable<Vehicles> GetV()
        {
            return context.Vehicle.ToList() ?? new List<Vehicles>();
        }
    }
}
