using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.ViewModels;
using CleanArquitecture.Domain.Interfaces;
using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Application.Services
{
    public class ChoferService : IChoferService
    {
        public IChoferRepository _choferRepository;
        public ChoferService(IChoferRepository choferRepository)
        {
            _choferRepository = choferRepository;
        }

        public void AddChofer(Chofer chofer)
        {
            _choferRepository.AddChofer(chofer);
        }

        public void RemoveChofer(int id)
        {
            _choferRepository.RemoveChofer(id);
        }

        public void EditarChofer(int id, Chofer chofer)
        {
            _choferRepository.EditarChofer(0, chofer);
        }

        public Chofer FindID(int id)
        {
           return  _choferRepository.FindID(id);
        }

        public ChoferViewModel GetChoferes()
        {
            return new ChoferViewModel
            {
                Choferes = _choferRepository.GetChoferes()
            };
        }
    }
}
