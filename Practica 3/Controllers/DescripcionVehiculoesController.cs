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
    public class DescripcionVehiculoesController : ControllerBase
    {
        private readonly PracticaContext _context;

        public DescripcionVehiculoesController(PracticaContext context)
        {
            _context = context;
        }

        // GET: api/DescripcionVehiculoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DescripcionVehiculo>>> GetDescripcionesVehiculos()
        {
            return await _context.DescripcionesVehiculos.ToListAsync();
        }

        // GET: api/DescripcionVehiculoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DescripcionVehiculo>> GetDescripcionVehiculo(int id)
        {
            var descripcionVehiculo = await _context.DescripcionesVehiculos.FindAsync(id);

            if (descripcionVehiculo == null)
            {
                return NotFound();
            }

            return descripcionVehiculo;
        }

        // PUT: api/DescripcionVehiculoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDescripcionVehiculo(int id, DescripcionVehiculo descripcionVehiculo)
        {
            if (id != descripcionVehiculo.IdVehiculo)
            {
                return BadRequest();
            }

            _context.Entry(descripcionVehiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DescripcionVehiculoExists(id))
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

        // POST: api/DescripcionVehiculoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DescripcionVehiculo>> PostDescripcionVehiculo(DescripcionVehiculo descripcionVehiculo)
        {
            _context.DescripcionesVehiculos.Add(descripcionVehiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDescripcionVehiculo", new { id = descripcionVehiculo.IdVehiculo }, descripcionVehiculo);
        }

        // DELETE: api/DescripcionVehiculoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DescripcionVehiculo>> DeleteDescripcionVehiculo(int id)
        {
            var descripcionVehiculo = await _context.DescripcionesVehiculos.FindAsync(id);
            if (descripcionVehiculo == null)
            {
                return NotFound();
            }

            _context.DescripcionesVehiculos.Remove(descripcionVehiculo);
            await _context.SaveChangesAsync();

            return descripcionVehiculo;
        }

        private bool DescripcionVehiculoExists(int id)
        {
            return _context.DescripcionesVehiculos.Any(e => e.IdVehiculo == id);
        }
    }
}
