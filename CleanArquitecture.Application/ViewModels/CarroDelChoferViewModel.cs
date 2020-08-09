using CleanArquitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Application.ViewModels
{
    class CarroDelChoferViewModel
    {
        public IEnumerable<CarroChofer> CarrosDeChoferes { get; set; }
    }
}
