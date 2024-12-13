using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace MiApi
{
    public class Cervezas
    {
        [Key] // Marca esta propiedad como clave primaria
        public int Id { get; set; }  // Cambié 'id_cerveza' por 'Id'

        public string Nombre { get; set; }

        [Precision(5, 2)] // Ejemplo: hasta 3 dígitos enteros y 2 decimales.
        public decimal Graduacion { get; set; }

        public string pais { get; set; }

        public Cervezas(int id, string nombre, decimal graduacion, string pais)
        {
            Id = id;  // Cambié 'id_cerveza' por 'Id'
            Nombre = nombre;
            Graduacion = graduacion;
            pais = pais;
        }

        // Constructor sin parámetros
        public Cervezas() { }
    }
}
