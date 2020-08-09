using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Domain.Interfaces
{
    public interface ICarroRepository
    {
        IEnumerable<Carro> GetCarros();
    }
}
