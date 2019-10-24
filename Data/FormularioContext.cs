using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Taller1.Models
{
    public class FormularioContext : DbContext
    {
        public FormularioContext (DbContextOptions<FormularioContext> options)
            : base(options)
        {
        }

        public DbSet<Taller1.Models.Formulario> Formulario { get; set; }
    }
}
