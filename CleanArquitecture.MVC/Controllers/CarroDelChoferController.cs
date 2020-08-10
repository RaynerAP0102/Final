using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.ViewModels;
using CleanArquitecture.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArquitecture.MVC.Controllers
{
    public class CarroDelChoferController : Controller
    {
        private ICarroDelChoferService _carroDelChoferService;
        private ICarroService _carroService;
        private IChoferService _choferService;
        public CarroDelChoferController(ICarroDelChoferService carroDelChoferService, ICarroService carroService,IChoferService choferService)
        {
            _carroDelChoferService = carroDelChoferService;
            _choferService = choferService;
            _carroService = carroService;
        }
        public IActionResult Index()
        {

            CarroDelChoferViewModel model = _carroDelChoferService.GetCarroDelChofer();

            return View(model);
            
        }

        public IActionResult Create()
        {

            AllViewModel model = new AllViewModel();

            model.CarroChoferes = _carroDelChoferService.GetCarroDelChofer().CarrosDeChoferes;
            model.Carros = _carroService.GetCarros().Carros;
            model.Choferes = _choferService.GetChoferes().Choferes;

            return View(model);
        }

        //POST: CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int created = 0)
        {
            CarroChofer carroChofer = new CarroChofer();

            carroChofer.CarroId_Carro = Convert.ToInt32(Request.Form["Id_Carro"]);
            carroChofer.ChoferId = Convert.ToInt32(Request.Form["Id_Chofer"]);
            carroChofer.DateTakeCarro = DateTime.Now;

            Console.WriteLine(carroChofer);

            if (ModelState.IsValid)
            {
                _carroDelChoferService.AddCarroDelChofer(carroChofer);
                return RedirectToAction(nameof(Index));
            }

            return View(carroChofer);
        }

        //Get: Carro/Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carroChofer = _carroDelChoferService.FindID((int)id);
            if (carroChofer == null)
            {
                return NotFound();
            }

            return View(carroChofer);
        }

        // POST: Carrito/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _carroDelChoferService.RemoveCarroDelChofer(id);

            return RedirectToAction(nameof(Index));
        }



    }
}