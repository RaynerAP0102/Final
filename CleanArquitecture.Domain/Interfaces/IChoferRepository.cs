using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Domain.Interfaces
{
    public interface IChoferRepository
    {
        IEnumerable<Chofer> GetChoferes();

        void AddChofer(Chofer chofer);

        void RemoveChofer(int id);

        void EditarChofer(int id, Chofer chofer);

        Chofer FindID(int id);
    }
}
