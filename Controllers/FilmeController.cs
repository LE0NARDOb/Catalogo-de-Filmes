using Microsoft.AspNetCore.Mvc;
using CatalogoFilmes.Models;
using System.Collections.Generic;
using System.Linq; 

namespace CatalogoFilmes.Controllers
{
    public class FilmeController : Controller
    {
        // ---- BANCO DE DADOS FALSO (TEM QUE SER O MESMO DO HOME) ----
        private static List<Filme> _filmes = new List<Filme>
        {
            new Filme { 
                Id = 1, 
                Titulo = "O Poderoso Chefão", 
                AnoLancamento = 1972, 
                Diretor = "Francis Ford Coppola",
                Sinopse = "O patriarca de uma dinastia do crime organizado transfere o controle de seu império clandestino para seu filho relutante.",
                Poster = "/images/poderoso-chefao.jpg"
            },
            new Filme { 
                Id = 2, 
                Titulo = "Vingadores: Ultimato", 
                AnoLancamento = 2019, 
                Diretor = "Irmãos Russo",
                Sinopse = "Após os eventos devastadores de 'Guerra Infinita', os Vingadores restantes devem encontrar uma maneira de trazer de volta seus aliados para uma batalha épica.",
                Poster = "/images/vingadores.jpg"
            },
            new Filme { 
                Id = 3, 
                Titulo = "Parasita", 
                AnoLancamento = 2019, 
                Diretor = "Bong Joon-ho",
                Sinopse = "Uma família pobre se infiltra na casa de uma família rica, um a um, mas segredos e mentiras levam a consequências inesperadas.",
                Poster = "/images/parasita.jpg"
            }
        };
        // ---- FIM DO BANCO DE DADOS FALSO ----

        // GET: /Filme/Details/1 (ou 2, ou 3...)
        public IActionResult Details(int id)
        {
            var filme = _filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
            {
                return NotFound();
            }
            return View(filme);
        }
    }
}