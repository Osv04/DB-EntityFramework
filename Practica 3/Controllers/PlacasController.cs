using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practica_3.Models;

namespace Practica_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacasController : ControllerBase
    {
        private readonly PracticaContext _context;

        public PlacasController(PracticaContext context)
        {
            _context = context;
        }

        // GET: api/Placas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Placa>>> GetPlacas()
        {
            return await _context.Placas.ToListAsync();
        }

        // GET: api/Placas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Placa>> GetPlaca(string id)
        {
            var placa = await _context.Placas.FindAsync(id);

            if (placa == null)
            {
                return NotFound();
            }

            return placa;
        }

        // PUT: api/Placas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlaca(string id, Placa placa)
        {
            if (id != placa.idPlaca)
            {
                return BadRequest();
            }

            _context.Entry(placa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlacaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Placas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Placa>> PostPlaca(Placa placa)
        {
            _context.Placas.Add(placa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlaca", new { id = placa.idPlaca }, placa);
        }

        // DELETE: api/Placas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Placa>> DeletePlaca(string id)
        {
            var placa = await _context.Placas.FindAsync(id);
            if (placa == null)
            {
                return NotFound();
            }

            _context.Placas.Remove(placa);
            await _context.SaveChangesAsync();

            return placa;
        }

        private bool PlacaExists(string id)
        {
            return _context.Placas.Any(e => e.idPlaca == id);
        }
    }
}
