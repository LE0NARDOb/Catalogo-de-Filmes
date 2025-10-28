using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoFilmes.Models
{
    [Table("FilmesGeneros")]
    public class FilmeGenero
    {
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}