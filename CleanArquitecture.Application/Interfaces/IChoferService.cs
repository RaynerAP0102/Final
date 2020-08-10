using CleanArquitecture.Application.ViewModels;
using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Application.Interfaces
{
    public interface IChoferService
    {
        ChoferViewModel GetChoferes();

        void AddChofer(Chofer chofer);

        void RemoveChofer(int id);

        void EditarChofer(int id, Chofer chofer);

        Chofer FindID(int id);
    }
}
