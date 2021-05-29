using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Analisis.Datos;
using Analisis.Entidades.Almacen;
using Analisis.Entidades.Condicion;

namespace analisis.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondicionController : ControllerBase
    {
        private readonly DbContexSistema _context;

        public CondicionController(DbContexSistema context)
        {
            _context = context;
        }

        // GET: api/Condicion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<condicion>>> GetCondicion()
        {
            return await _context.Condicion.ToListAsync();
        }

        // GET: api/Condicion
        [HttpGet("{id}")]
        public async Task<ActionResult<condicion>> GetCondicion(int id)
        {
            var condicion = await _context.Condicion.FindAsync(id);

            if (condicion == null)
            {
                return NotFound();
            }

            return condicion;
        }

        // PUT: api/Condicion
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCondicion(int id, condicion condicion)
        {
            if (id != condicion.idCondicion)
            {
                return BadRequest();
            }

            _context.Entry(condicion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CondicionExists(id))
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

        // POST: api/Condicion
        [HttpPost]
        public async Task<ActionResult<condicion>> PostCondicion(condicion condicion)
        {
            _context.Condicion.Add(condicion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCondicion", new { id = condicion.idCondicion }, condicion);
        }

        // DELETE: api/Condicion
        [HttpDelete("{id}")]
        public async Task<ActionResult<condicion>> DeleteCondicion(int id)
        {
            var condicion = await _context.Condicion.FindAsync(id);
            if (condicion == null)
            {
                return NotFound();
            }

            _context.Condicion.Remove(condicion);
            await _context.SaveChangesAsync();

            return condicion;
        }

        private bool CondicionExists(int id)
        {
            return _context.Condicion.Any(C => C.idCondicion == id);
        }
    }
}