using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Domain.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
