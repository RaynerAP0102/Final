using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.ViewModels;
using CleanArquitecture.Domain.Interfaces;
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
        public CarroViewModel GetCarros()
        {
            return new CarroViewModel()
            {
                Carros = _carroRepository.GetCarros()
            };
        }
    }

    
}
