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
    public class FacturaHsController : ControllerBase
    {
        private readonly PracticaContext _context;

        public FacturaHsController(PracticaContext context)
        {
            _context = context;
        }

        // GET: api/FacturaHs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacturaH>>> GetFacturaH()
        {
            return await _context.FacturaH.ToListAsync();
        }

        // GET: api/FacturaHs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FacturaH>> GetFacturaH(int id)
        {
            var facturaH = await _context.FacturaH.FindAsync(id);

            if (facturaH == null)
            {
                return NotFound();
            }

            return facturaH;
        }

        // PUT: api/FacturaHs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacturaH(int id, FacturaH facturaH)
        {
            if (id != facturaH.IdFacturaH)
            {
                return BadRequest();
            }

            _context.Entry(facturaH).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturaHExists(id))
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

        // POST: api/FacturaHs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FacturaH>> PostFacturaH(FacturaH facturaH)
        {
            _context.FacturaH.Add(facturaH);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacturaH", new { id = facturaH.IdFacturaH }, facturaH);
        }

        // DELETE: api/FacturaHs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FacturaH>> DeleteFacturaH(int id)
        {
            var facturaH = await _context.FacturaH.FindAsync(id);
            if (facturaH == null)
            {
                return NotFound();
            }

            _context.FacturaH.Remove(facturaH);
            await _context.SaveChangesAsync();

            return facturaH;
        }

        private bool FacturaHExists(int id)
        {
            return _context.FacturaH.Any(e => e.IdFacturaH == id);
        }
    }
}
