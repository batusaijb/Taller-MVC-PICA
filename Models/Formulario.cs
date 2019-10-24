using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller1.Models
{
    public class Formulario
    {
        public int Id { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public int Celular { get; set; }
    }
}
