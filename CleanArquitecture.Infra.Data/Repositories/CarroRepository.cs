using CleanArquitecture.Domain.Interfaces;
using CleanArquitecture.Domain.Models;
using CleanArquitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Infra.Data.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        public TaxeriaDbContext _context;
        public CarroRepository(TaxeriaDbContext context)
        {
            _context = context;
        }

        public void AddCarro(Carro carro)
        {
            _context.Carros.Add(carro);
            _context.SaveChanges();
            _context.Dispose();
        }

        public void EditarCarro(int id, Carro carro)
        {
            _context.Carros.Update(carro);
            _context.SaveChanges();
            _context.Dispose();
        }

        public Carro FindID(int id)
        {
            return _context.Carros.Find(id);
        }

        public IEnumerable<Carro> GetCarros()
        {
            return _context.Carros;
        }

        public void RemoveCarro(int id)
        {
            Carro carro = this.FindID(id);

            _context.Carros.Remove(carro);

            _context.SaveChanges();

            _context.Dispose();
        }

    }
}
