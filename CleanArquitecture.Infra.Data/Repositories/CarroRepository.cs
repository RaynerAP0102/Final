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

        public IEnumerable<Carro> GetCarros()
        {
            return _context.Carros;
        }
    }
}
