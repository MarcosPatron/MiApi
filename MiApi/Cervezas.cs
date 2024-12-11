namespace MiApi
{
    public class Cervezas
    {
        public int id {  get; set; }
        public string Nombre { get; set; }

        public decimal Graduacion { get; set; }

        public string Pais { get; set; }

        public Cervezas(int id, string nombre, decimal graduacion, string pais) 
        {
            this.id = id;
            Nombre = nombre;
            Graduacion = graduacion;    
            Pais = pais;
        }
    }
}
