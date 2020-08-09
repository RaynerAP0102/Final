using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArquitecture.MVC.Controllers
{
    public class CarroController : Controller
    {
        private ICarroService _carroService;
        public CarroController(ICarroService bookService)
        {
            _carroService = bookService;
        }
        public IActionResult Index()
        {
            CarroViewModel model = _carroService.GetCarros();
            return View(model);
        }
    }
}