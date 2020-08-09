using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Application.ViewModels
{
    public class CarroViewModel
    {
        public IEnumerable<Carro> Carros { get; set; }
    }
}
