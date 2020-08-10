using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Domain.Interfaces
{
    public interface ICarroRepository
    {
        IEnumerable<Carro> GetCarros();

        void AddCarro(Carro carro);

        void RemoveCarro(int id);

        void EditarCarro(int id, Carro carro);

        Carro FindID(int id);

    }
}
