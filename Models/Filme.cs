using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoFilmes.Models 
{
    [Table("Filmes")]
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O Título é obrigatório.")]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Display(Name = "Sinopse")]
        [Required(ErrorMessage = "A Sinopse é obrigatória.")]
        public string Sinopse { get; set; }

        [Display(Name = "Ano de Lançamento")]
        [Required(ErrorMessage = "O Ano de Lançamento é obrigatório.")]
        public int AnoLancamento { get; set; }

        [Display(Name = "Diretor")]
        [StringLength(100)]
        public string Diretor { get; set; }

        [StringLength(200)]
        public string? Poster { get; set; } 

        public ICollection<FilmeGenero> Generos { get; set; } = new List<FilmeGenero>(); 
    }
}