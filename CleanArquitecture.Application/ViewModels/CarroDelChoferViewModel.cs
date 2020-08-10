using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Application.ViewModels
{
    public class CarroDelChoferViewModel
    {
        public IEnumerable<CarroChofer> CarrosDeChoferes { get; set; }
        public IEnumerable<CarroChofer> Carros { get; set; }
        public IEnumerable<CarroChofer> Chofer { get; set; }

    }
}
