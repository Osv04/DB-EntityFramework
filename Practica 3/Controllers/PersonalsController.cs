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
    public class PersonalsController : ControllerBase
    {
        private readonly PracticaContext _context;

        public PersonalsController(PracticaContext context)
        {
            _context = context;
        }

        // GET: api/Personals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personal>>> GetPersonales()
        {
            return await _context.Personales.ToListAsync();
        }

        // GET: api/Personals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Personal>> GetPersonal(int id)
        {
            var personal = await _context.Personales.FindAsync(id);

            if (personal == null)
            {
                return NotFound();
            }

            return personal;
        }

        // PUT: api/Personals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonal(int id, Personal personal)
        {
            if (id != personal.idPersonal)
            {
                return BadRequest();
            }

            _context.Entry(personal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalExists(id))
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

        // POST: api/Personals
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Personal>> PostPersonal(Personal personal)
        {
            _context.Personales.Add(personal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonal", new { id = personal.idPersonal }, personal);
        }

        // DELETE: api/Personals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Personal>> DeletePersonal(int id)
        {
            var personal = await _context.Personales.FindAsync(id);
            if (personal == null)
            {
                return NotFound();
            }

            _context.Personales.Remove(personal);
            await _context.SaveChangesAsync();

            return personal;
        }

        private bool PersonalExists(int id)
        {
            return _context.Personales.Any(e => e.idPersonal == id);
        }
    }
}
