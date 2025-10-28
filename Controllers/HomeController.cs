using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using CatalogoFilmes.Models;
using System.Diagnostics;

namespace CatalogoFilmes.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDbConnection _dbConnection;

        public HomeController(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IActionResult Index()
        {
            var sql = "SELECT * FROM Filmes";
            var listaDeFilmes = _dbConnection.Query<Filme>(sql);
            return View(listaDeFilmes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}