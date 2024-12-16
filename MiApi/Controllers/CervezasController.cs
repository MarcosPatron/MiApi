using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiApi.Data;

namespace MiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CervezasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CervezasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Cervezas
        [HttpGet(Name = "GetCervezas")]
        public async Task<IEnumerable<Cervezas>> Get()
        {
            return await _context.Cervezas.ToListAsync();
        }

        // POST: /Cervezas
        [HttpPost]
        public async Task<ActionResult<Cervezas>> Post([FromBody] Cervezas nuevaCerveza)
        {
            _context.Cervezas.Add(nuevaCerveza);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id_cerveza = nuevaCerveza.ID_CERVEZA }, nuevaCerveza); 
        }

        // PUT: /Cervezas/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<Cervezas>> Put(int id_cerveza, [FromBody] Cervezas cervezaActualizada)
        {
            if (id_cerveza != cervezaActualizada.ID_CERVEZA)  
            {
                return BadRequest();
            }

            _context.Entry(cervezaActualizada).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: /Cervezas/{id}
        [HttpDelete("{id_cerveza}")]
        public async Task<ActionResult> Delete(int id_cerveza)
        {
            var cerveza = await _context.Cervezas.FindAsync(id_cerveza);
            if (cerveza == null)
            {
                return NotFound();
            }

            _context.Cervezas.Remove(cerveza);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
