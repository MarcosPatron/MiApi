using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace MiApi
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cervezas
    {
        [Key]
        public int Id { get; set; }

        public required string Nombre { get; set; } // Marcada como obligatoria

        [Precision(5, 2)]
        public decimal Graduacion { get; set; }

        public required string Pais { get; set; } // Marcada como obligatoria

        // Constructor con parámetros
        public Cervezas(int id, string nombre, decimal graduacion, string pais)
        {
            Id = id;
            Nombre = nombre;
            Graduacion = graduacion;
            Pais = pais;
        }

        // Constructor sin parámetros sigue siendo válido
        public Cervezas() { }
    }

}