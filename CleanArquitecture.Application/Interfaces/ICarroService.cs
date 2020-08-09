using CleanArquitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Application.Interfaces
{
    public interface ICarroService
    {
        CarroViewModel GetCarros();
    }
}
