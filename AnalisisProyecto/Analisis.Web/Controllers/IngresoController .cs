using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Analisis.Datos;
using Analisis.Entidades.Almacen;

namespace analisis.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresoController : ControllerBase
    {
        private readonly DbContexSistema _context;

        public IngresoController(DbContexSistema context)
        {
            _context = context;
        }

        // GET: api/Ingreso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingreso>>> GetIngreso()
        {
            return await _context.Ingreso.ToListAsync();
        }

        // GET: api/Ingreso
        [HttpGet("{id}")]
        public async Task<ActionResult<Ingreso>> GetIngreso(int id)
        {
            var ingreso = await _context.Ingreso.FindAsync(id);

            if (ingreso == null)
            {
                return NotFound();
            }

            return ingreso;
        }

        // PUT: api/Ingreso
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngreso(int id, Ingreso ingreso)
        {
            if (id != ingreso.idIngreso)
            {
                return BadRequest();
            }

            _context.Entry(ingreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngresoExists(id))
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

        // POST: api/Ingreso
        [HttpPost]
        public async Task<ActionResult<Ingreso>> PostIngreso(Ingreso ingreso)
        {
            _context.Ingreso.Add(ingreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIngreso", new { id = ingreso.idIngreso }, ingreso);
        }

        // DELETE: api/Ingreso
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ingreso>> DeleteIngreso(int id)
        {
            var ingreso = await _context.Ingreso.FindAsync(id);
            if (ingreso == null)
            {
                return NotFound();
            }

            _context.Ingreso.Remove(ingreso);
            await _context.SaveChangesAsync();

            return ingreso;
        }

        private bool IngresoExists(int id)
        {
            return _context.Ingreso.Any(In => In.idIngreso == id);
        }
    }
}