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
    public class EstadosController : ControllerBase
    {
        private readonly DbContexSistema _context;

        public EstadosController(DbContexSistema context)
        {
            _context = context;
        }

        // GET: api/Estados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<estados>>> GetEstados()
        {
            return await _context.estados.ToListAsync();
        }

        // GET: api/Estados
        [HttpGet("{id}")]
        public async Task<ActionResult<estados>> GetEstados(int id)
        {
            var estados = await _context.estados.FindAsync(id);

            if (estados == null)
            {
                return NotFound();
            }

            return estados;
        }

        // PUT: api/Estados
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstados(int id, estados estados)
        {
            if (id != estados.idEstado)
            {
                return BadRequest();
            }

            _context.Entry(estados).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadosExists(id))
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

        // POST: api/Estados
        [HttpPost]
        public async Task<ActionResult<estados>> PostEstados(estados estados)
        {
            _context.estados.Add(estados);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstados", new { id = estados.idEstado }, estados);
        }

        // DELETE: api/Estados
        [HttpDelete("{id}")]
        public async Task<ActionResult<estados>> DeleteEstados(int id)
        {
            var estados = await _context.estados.FindAsync(id);
            if (estados == null)
            {
                return NotFound();
            }

            _context.estados.Remove(estados);
            await _context.SaveChangesAsync();

            return estados;
        }

        private bool EstadosExists(int id)
        {
            return _context.estados.Any(E => E.idEstado == id);
        }
    }
}