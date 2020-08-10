using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArquitecture.Domain.Models
{
    public class Carro
    {
        [Key]
        public int Id_Carro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Color { get; set; }
    }
}
