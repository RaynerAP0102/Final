using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.ViewModels;
using CleanArquitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanArquitecture.MVC.Controllers
{
    public class ChoferController : Controller
    {

        private IChoferService _choferService;
        public ChoferController(IChoferService choferService)
        {
            _choferService = choferService;
        }

        //List
        public IActionResult Index()
        {
            ChoferViewModel model = _choferService.GetChoferes();
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
        public IActionResult Create([Bind("Id,Nombre,Apellido,Edad,Licencia")] Chofer chofer)
        {

            if (ModelState.IsValid)
            {
                _choferService.AddChofer(chofer);
                return RedirectToAction(nameof(Index));
            }
            return View(chofer);
        }

        //GET : Carro
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chofer = _choferService.FindID((int)id);
            if (chofer == null)
            {
                return NotFound();
            }
            return View(chofer);
        }


        //POST: Carro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Nombre,Apellido,Edad,Licencia")] Chofer chofer)
        {
            if (id != chofer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _choferService.EditarChofer(id, chofer);
                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(chofer);
        }

        //Get: Carro/Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chofer = _choferService.FindID((int)id);
            if (chofer == null)
            {
                return NotFound();
            }

            return View(chofer);
        }

        // POST: Carrito/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _choferService.RemoveChofer(id);

            return RedirectToAction(nameof(Index));
        }
    }
}