using System.ComponentModel.DataAnnotations;

namespace proyectofinal.Models
{
    public class Peliculas
    {
        [Key]
        public int IdPelicula { get; set; }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Sinopsis { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }
    }
}
