using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.ViewModels;
using CleanArquitecture.Domain.Interfaces;
using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Application.Services
{
    public class CarroDelChoferService : ICarroDelChoferService
    {
        public ICarroDelChoferRepository _carroDelChoferRepository;
        public  CarroDelChoferService(ICarroDelChoferRepository carroDelChoferRepository)
        {
            _carroDelChoferRepository = carroDelChoferRepository;
        }

        public void AddCarroDelChofer(CarroChofer carroDelChofer)
        {
            _carroDelChoferRepository.AddCarroDelChofer(carroDelChofer);
        }

        public void EditarCarroDelChofer(int id, CarroChofer carroDelChofer)
        {
            _carroDelChoferRepository.EditarCarroDelChofer(0,carroDelChofer);
        }

        public CarroChofer FindID(int id)
        {
            return _carroDelChoferRepository.FindID(id);
        }

        public CarroChofer FindID(string id)
        {
            return _carroDelChoferRepository.FindID(id);
        }

        public CarroDelChoferViewModel GetCarroDelChofer()
        {
            return new CarroDelChoferViewModel()
            {
                CarrosDeChoferes = _carroDelChoferRepository.GetCarroDelChofer()
            };
        }

        public void RemoveCarroDelChofer(int id)
        {
            _carroDelChoferRepository.RemoveCarroDelChofer(id);
        }

        public void RemoveCarroDelChofer(string id)
        {
            _carroDelChoferRepository.RemoveCarroDelChofer(id);
        }
    }
}
