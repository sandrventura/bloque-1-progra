using System.ComponentModel.DataAnnotations;


namespace TSNP229123.Models
{
    public class PELICULAS
    {
        [Key]
        public int IdPeliculas { get; set; }
        public int CodigodePelicula { get; set; }
        public int Titulo { get; set; }
        public int Autor { get; set; }
        public int Sinopsis { get; set; }
        public int Duracion { get; set; }
        public int Clasificacion { get; set; }

    }
}
