using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoFilmes.Models
{
    [Table("Generos")]
    public class Genero
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "O nome do Gênero é obrigatório.")]
        [StringLength(30)]
        public string Nome { get; set; }

        public ICollection<FilmeGenero> Filmes { get; set; }
    }
}