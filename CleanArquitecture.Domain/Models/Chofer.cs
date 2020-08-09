using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Domain.Models
{
    public class Chofer
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Licencia { get; set; }
    }
}
