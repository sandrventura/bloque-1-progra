using System.ComponentModel.DataAnnotations;
namespace TSNP229123.Models
{
    public class PELICULAS
    {
        [Key]
        public int IdPeliculas{ get; set; }
        public int CodigodePelicula { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Sinopsis { get; set; }
        public int Duracion { get; set; }
        public string Clasificacion { get; set; }

    }
}
