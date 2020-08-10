using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.ViewModels;
using CleanArquitecture.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanArquitecture.MVC.Controllers
{
    public class CarroController : Controller
    {
        private ICarroService _carroService;
        public CarroController(ICarroService carroService)
        {
            _carroService = carroService;
        }

        public IActionResult Index()
        {
            CarroViewModel model = _carroService.GetCarros();
            return View(model);
        }

        //GET: CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST: CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id_Carro,Marca,Modelo,Ano,Color")] Carro carro)
        {



            if (ModelState.IsValid)
            {
                _carroService.AddCarro(carro);
                return RedirectToAction(nameof(Index));
            }
            return View(carro);
        }




        //Get: Carro/Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = _carroService.FindID((int)id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Carrito/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _carroService.RemoveCarro(id);

            return RedirectToAction(nameof(Index));
        }




    }
}