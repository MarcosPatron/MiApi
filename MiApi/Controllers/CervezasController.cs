using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace MiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CervezasController : ControllerBase
    {
        private static List<Cervezas> Lista = new List<Cervezas>
        {
            new Cervezas(1, "Corona", 3.0m, "Bélgica"),
            new Cervezas(2, "Heineken", 4.0m, "Estados Unidos"),
            new Cervezas(3, "Guinness", 3.5m, "Irlanda")
        };

        private readonly ILogger<CervezasController> _logger;

        public CervezasController(ILogger<CervezasController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "Cervezas")]
        public IEnumerable<Cervezas> Get()
        {
            return Lista;
        }

        [HttpPost]
        public ActionResult<Cervezas> Post([FromBody] Cervezas nuevaCerveza)
        {
            nuevaCerveza.id = Lista.Count + 1;
            nuevaCerveza.Nombre = "Budweiser";
            nuevaCerveza.Graduacion = 5.0m;
            nuevaCerveza.Pais = "Países Bajos";

            Lista.Add(nuevaCerveza);

            return CreatedAtAction(nameof(Get), new { }, nuevaCerveza);
        }

        [HttpPut("{id}")]
        public ActionResult<Cervezas> Put(int id, [FromBody] Cervezas cervezaActualizada)
        {
            var cerveza = Lista.Find(c => c.id == id);

            cerveza.id = 1;
            cerveza.Nombre = "Nuevo nombre";
            cerveza.Graduacion = 33.3m;
            cerveza.Pais = "Nuevo pais";

            return Ok(Lista[0]);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cerveza = Lista.Find(c => c.id == id);

            Lista.Remove(cerveza);
            return NoContent();
        }
    }
}