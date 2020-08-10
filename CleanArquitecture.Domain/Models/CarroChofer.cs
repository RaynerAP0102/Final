using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanArquitecture.Domain.Models
{
    public class CarroChofer
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateTakeCarro { get; set; }

        [ForeignKey("Carro")]
        public int CarroId_Carro { get; set; }

        [ForeignKey("Chofer")]
        public int ChoferId { get; set; }
    }
}
