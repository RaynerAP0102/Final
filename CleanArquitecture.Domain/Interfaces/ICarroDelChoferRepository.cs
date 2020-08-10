using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Domain.Interfaces
{
    public interface ICarroDelChoferRepository
    {

        IEnumerable<CarroChofer> GetCarroDelChofer();

        void AddCarroDelChofer(CarroChofer carroDelChofer);

        void RemoveCarroDelChofer(int id);

        void RemoveCarroDelChofer(string id);

        void EditarCarroDelChofer(int id, CarroChofer carroDelChofer);

        CarroChofer FindID(int id);

        CarroChofer FindID(string id);
    }
}
