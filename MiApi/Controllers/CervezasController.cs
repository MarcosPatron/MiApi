using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace MiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CervezasController : ControllerBase
    {
        private static readonly List<Cervezas> Lista = new List<Cervezas>
        {
            new Cervezas("Corona", 3.0m, "Bélgica"),
            new Cervezas("Heineken", 4.0m, "Estados Unidos"),
            new Cervezas("Guinness", 3.5m, "Irlanda")
        };

        private static readonly String[] Paises = new[]
{
            "Bélgica", "Estados Unidos", "Irlanda", "Países Bajos", "México"
        };

        private static readonly String[] Nombres = new[]
        {
            "Corona", "Heineken", "Guinness", "Budweiser", "Stella Artois"
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

            nuevaCerveza.Nombre = "Budweiser";
            nuevaCerveza.Graduacion = 5.0m;
            nuevaCerveza.Pais = "Países Bajos";

            Lista.Add(nuevaCerveza);

            return CreatedAtAction(nameof(Get), new {}, nuevaCerveza);
        }

        [HttpPut("{Nombre}")]
        public ActionResult<Cervezas> Put(String nombre, [FromBody] Cervezas cervezaActualizada)
        {
            var cerveza = Lista[0];

            cerveza.Nombre = "Nuevo nombre";
            cerveza.Graduacion = 33.3m;
            cerveza.Pais = "Nuevo pais";

            return Ok(Lista[0]);
        }
 
        [HttpDelete("{Nombre}")]
        public ActionResult Delete(string nombre)
        {
            var cerveza = Lista[0];

            Lista.Remove(cerveza);
            return NoContent();
        }
    }
}
