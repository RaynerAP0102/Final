using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.ViewModels;
using CleanArquitecture.Domain.Interfaces;
using CleanArquitecture.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace CleanArquitecture.Application.Services
{

    public class CarroService : ICarroService
    {

        public ICarroRepository _carroRepository;
        public CarroService(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public void AddCarro(Carro carro)
        {
            _carroRepository.AddCarro(carro);
        }

        public void EditarCarro(int id, Carro carro)
        {
            _carroRepository.EditarCarro(0, carro);
        }

        public Carro FindID(int id)
        {
            return _carroRepository.FindID(id);
        }

        public CarroViewModel GetCarros()
        {
            return new CarroViewModel()
            {
                Carros = _carroRepository.GetCarros()
            };
        }

        public void RemoveCarro(int id)
        {
            _carroRepository.RemoveCarro(id);
        }
    }

    
}
