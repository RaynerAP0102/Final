using CleanArquitecture.Domain.Interfaces;
using CleanArquitecture.Domain.Models;
using CleanArquitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Infra.Data.Repositories
{
    public class CarroDelChoferRepository : ICarroDelChoferRepository
    {

        public TaxeriaDbContext _context;
        public CarroDelChoferRepository(TaxeriaDbContext context)
        {
            _context = context;
        }

        public void AddCarroDelChofer(CarroChofer carroDelChofer)
        {
            _context.Taxistas.Add(carroDelChofer);
            _context.SaveChanges();
            _context.Dispose();

        }

        public void EditarCarroDelChofer(int id, CarroChofer carroDelChofer)
        {
            _context.Taxistas.Update(carroDelChofer);
        }

        public CarroChofer FindID(int id)
        {
            return _context.Taxistas.Find(id);
        }

        public CarroChofer FindID(string id)
        {
            return _context.Taxistas.Find(id);
        }

        public IEnumerable<CarroChofer> GetCarroDelChofer()
        {
            return _context.Taxistas;
        }

        public void RemoveCarroDelChofer(int id)
        {
            CarroChofer carroChofer = this.FindID(id);

            _context.Taxistas.Remove(carroChofer);

            _context.SaveChanges();

            _context.Dispose();
        }

        public void RemoveCarroDelChofer(string id)
        {
            CarroChofer carroChofer = this.FindID(id);

            _context.Taxistas.Remove(carroChofer);

            _context.SaveChanges();

            _context.Dispose();
        }
    }
}
