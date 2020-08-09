using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArquitecture.Domain.Models
{
    public class CarroChofer
    {
        [Key]
        public DateTime DateTakeCarro { get; set; }
        public Carro Carro { get; set; }
        public Chofer Chofer { get; set; }
    }
}
