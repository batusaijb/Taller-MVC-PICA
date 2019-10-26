using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Taller1.Models;

namespace Taller1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormulariosController : ControllerBase
    {
        private readonly FormularioContext _context;

        public FormulariosController(FormularioContext context)
        {
            _context = context;
        }

        // GET: api/Formularios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Formulario>>> GetFormulario()
        {
            return await _context.Formulario.ToListAsync();
        }

        // POST: api/Formularios
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
       
            [HttpPost]
            public async Task<ActionResult<Formulario>> PostFormulario(Formulario formulario)
            {
                _context.Formulario.Add(formulario);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetFormulario", new { id = formulario.Id }, formulario);
            }

        



        private bool FormularioExists(int id)
        {
            return _context.Formulario.Any(e => e.Id == id);
        }
    }
}
