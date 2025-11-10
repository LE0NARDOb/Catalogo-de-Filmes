using Microsoft.AspNetCore.Mvc;
using CatalogoFilmes.Models;
using System.Collections.Generic;

namespace CatalogoFilmes.Controllers
{
    public class HomeController : Controller
    {
        // ---- BANCO DE DADOS FALSO ATUALIZADO PARA BATER COM A FOTO ----
        private static List<Filme> _filmes = new List<Filme>
        {
            new Filme { 
                Id = 1, 
                Titulo = "Vingadores: Ultimato", 
                AnoLancamento = 2019, 
                Diretor = "Anthony Russo, Joe Russo",
                Sinopse = "Após os eventos devastadores de \"Guerra Infinita\", o universo está em ruínas.", // Texto da foto
                Poster = "/images/vingadores.jpg" // Imagem da sua wwwroot
            },
            new Filme { 
                Id = 2, 
                Titulo = "Parasita", 
                AnoLancamento = 2019, 
                Diretor = "Bong Joon Ho",
                Sinopse = "Toda a família de Ki-taek está desempregada, vivendo num porão sujo e apertado.", // Texto da foto
                Poster = "/images/parasita.jpg" // Imagem da sua wwwroot
            },
            new Filme { 
                Id = 3, 
                Titulo = "O Poderoso Chefão", 
                AnoLancamento = 1972, 
                Diretor = "Francis Ford Coppola",
                Sinopse = "Uma família mafiosa luta para estabelecer sua supremacia nos Estados Unidos.", // Texto da foto
                Poster = "/images/poderoso-chefao.jpg" // Imagem da sua wwwroot
            }
        };
        // ---- FIM DO BANCO DE DADOS FALSO ----

        public IActionResult Index()
        {
            return View(_filmes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TermosDeUso()
        {
            return View();
        }

        public IActionResult PoliticaDePrivacidade()
        {
            return View();
        }
    }
}