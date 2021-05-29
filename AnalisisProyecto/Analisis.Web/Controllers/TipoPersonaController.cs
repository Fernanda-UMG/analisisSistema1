using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Analisis.Datos;
using Analisis.Entidades.Almacen;
using Analisis.Entidades.Usuarios;

namespace analisis.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPersonaController : ControllerBase
    {
        private readonly DbContexSistema _context;

        public TipoPersonaController(DbContexSistema context)
        {
            _context = context;
        }

        // GET: api/TipoPersona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoPersona>>> GetTipoPersona()
        {
            return await _context.TipoPersona.ToListAsync();
        }

        // GET: api/TipoPersona
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoPersona>> GetTipoPersona(int id)
        {
            var tipoPersona = await _context.TipoPersona.FindAsync(id);

            if (tipoPersona == null)
            {
                return NotFound();
            }

            return tipoPersona;
        }

        // PUT: api/TipoPersona
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoPersona(int id, TipoPersona tipoPersona)
        {
            if (id != tipoPersona.idTipoPersona)
            {
                return BadRequest();
            }

            _context.Entry(tipoPersona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoPersonaExists(id))
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

        // POST: api/TipoPersona
        [HttpPost]
        public async Task<ActionResult<TipoPersona>> PostTipoPersona(TipoPersona tipoPersona)
        {
            _context.TipoPersona.Add(tipoPersona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoPersona", new { id = tipoPersona.idTipoPersona }, tipoPersona);
        }

        // DELETE: api/TipoPersona
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoPersona>> DeleteTipoPersona(int id)
        {
            var tipoPersona = await _context.TipoPersona.FindAsync(id);
            if (tipoPersona == null)
            {
                return NotFound();
            }

            _context.TipoPersona.Remove(tipoPersona);
            await _context.SaveChangesAsync();

            return tipoPersona;
        }

        private bool TipoPersonaExists(int id)
        {
            return _context.TipoPersona.Any(TP => TP.idTipoPersona == id);
        }
    }
}