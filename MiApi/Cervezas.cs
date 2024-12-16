using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace MiApi
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cervezas
    {
        [Key]
        public int id_cerveza { get; set; }

        public required string nombre { get; set; } 

        [Precision(5, 2)]
        public decimal graduacion { get; set; }

        public required string pais { get; set; } 

        // Constructor con parámetros
        public Cervezas(int id_cerveza, string nombre, decimal graduacion, string pais)
        {
            this.id_cerveza = id_cerveza;
            this.nombre = nombre;
            this.graduacion = graduacion;
            this.pais = pais;
        }

        // Constructor sin parámetros sigue siendo válido
        public Cervezas() { }
    }

}