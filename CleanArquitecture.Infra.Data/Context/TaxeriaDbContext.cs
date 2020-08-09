
using CleanArquitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace CleanArquitecture.Infra.Data.Context
{
    public class TaxeriaDbContext: DbContext
    {
        
        public TaxeriaDbContext(DbContextOptions options) : base(options) { 
        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Chofer> Choferes { get; set; }

        public DbSet<CarroChofer> Taxistas { get; set; }

    }
}
