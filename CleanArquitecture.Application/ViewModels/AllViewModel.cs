using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Application.ViewModels
{
    public class AllViewModel
    {
        public IEnumerable<Carro> Carros { get; set; }
        public IEnumerable<Chofer> Choferes { get; set; }
        public IEnumerable<CarroChofer> CarroChoferes { get; set; }
    }
}
