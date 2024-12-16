using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace MiApi
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cervezas
    {
        [Key]
        public int Id { get; set; }

        public required string Nombre { get; set; } 

        [Precision(5, 2)]
        public decimal Graduacion { get; set; }

        public required string Pais { get; set; } 

        // Constructor con parámetros
        public Cervezas(int id_cerveza, string nombre, decimal graduacion, string pais)
        {
            Id = id_cerveza;
            Nombre = nombre;
            Graduacion = graduacion;
            Pais = pais;
        }

        // Constructor sin parámetros sigue siendo válido
        public Cervezas() { }
    }

}