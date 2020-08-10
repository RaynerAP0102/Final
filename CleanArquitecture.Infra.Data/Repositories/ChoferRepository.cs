using CleanArquitecture.Application.ViewModels;
using CleanArquitecture.Domain.Interfaces;
using CleanArquitecture.Domain.Models;
using CleanArquitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Infra.Data.Repositories
{
    public class ChoferRepository : IChoferRepository
    {
        public TaxeriaDbContext _context;
        public ChoferRepository(TaxeriaDbContext context)
        {
            _context = context;
        }

        public void AddChofer(Chofer chofer)
        {
            _context.Choferes.Add(chofer);
            _context.SaveChanges();
            _context.Dispose();
        }

        public void EditarChofer(int id, Chofer chofer)
        {
            _context.Choferes.Update(chofer);
            _context.SaveChanges();
            _context.Dispose();
        }

        public Chofer FindID(int id)
        {
            return _context.Choferes.Find(id);
        }

        public IEnumerable<Chofer> GetChoferes()
        {
            return _context.Choferes;
        }

        public void RemoveChofer(int id)
        {
            Chofer chofer = this.FindID(id);

            _context.Choferes.Remove(chofer);

            _context.SaveChanges();
            _context.Dispose();
        }
    }
}
