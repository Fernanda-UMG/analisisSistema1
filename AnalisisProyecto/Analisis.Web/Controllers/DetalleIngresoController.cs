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
    public class DetalleIngresoController : ControllerBase
    {
        private readonly DbContexSistema _context;

        public DetalleIngresoController(DbContexSistema context)
        {
            _context = context;
        }

        // GET: api/DetalleIngreso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleIngreso>>> GetDetalleIngreso()
        {
            return await _context.DetalleIngreso.ToListAsync();
        }

        // GET: api/DetalleIngreso
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleIngreso>> GetDetalleIngreso(int id)
        {
            var detalleingreso = await _context.DetalleIngreso.FindAsync(id);

            if (detalleingreso == null)
            {
                return NotFound();
            }

            return detalleingreso;
        }

        // PUT: api/DetalleIngreso
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleIngreso(int id, DetalleIngreso detalleingreso)
        {
            if (id != detalleingreso.idDetalleIngreso)
            {
                return BadRequest();
            }

            _context.Entry(detalleingreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleIngresoExists(id))
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

        // POST: api/DetalleIngreso
        [HttpPost]
        public async Task<ActionResult<Ingreso>> PostDetalleIngreso(DetalleIngreso detalleingreso)
        {
            _context.DetalleIngreso.Add(detalleingreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleIngreso", new { id = detalleingreso.idDetalleIngreso }, detalleingreso);
        }

        // DELETE: api/DetalleIngreso
        [HttpDelete("{id}")]
        public async Task<ActionResult<DetalleIngreso>> DeleteDetalleIngreso(int id)
        {
            var detalleingreso = await _context.DetalleIngreso.FindAsync(id);
            if (detalleingreso == null)
            {
                return NotFound();
            }

            _context.DetalleIngreso.Remove(detalleingreso);
            await _context.SaveChangesAsync();

            return detalleingreso;
        }

        private bool DetalleIngresoExists(int id)
        {
            return _context.DetalleIngreso.Any(DI => DI.idDetalleIngreso == id);
        }
    }
}