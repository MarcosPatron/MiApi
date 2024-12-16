using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace MiApi
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cervezas
    {
        [Key]
        public int ID_CERVEZA { get; set; }

        public required string NOMBRE { get; set; } 

        [Precision(5, 2)]
        public decimal GRADUACION { get; set; }

        public required string PAIS { get; set; } 

        // Constructor con parámetros
        public Cervezas(int id_cerveza, string nombre, decimal graduacion, string pais)
        {
            this.ID_CERVEZA = id_cerveza;
            this.NOMBRE = nombre;
            this.GRADUACION = graduacion;
            this.PAIS = pais;
        }

        // Constructor sin parámetros sigue siendo válido
        public Cervezas() { }
    }

}