using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Testapplication.Models;

namespace Testapplication.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GamesController : ControllerBase
    {
        public static List<Games> GetGames()
        {
            List<Games> games = new List<Games>();
            games.Add(new Games(){Id = 1, Name = "Game1", Price = 10});
            games.Add(new Games(){Id = 2, Name = "Game2", Price = 15});
            games.Add(new Games(){Id = 3, Name = "Game3", Price = 20});
            games.Add(new Games(){Id = 4, Name = "Game4", Price = 25});
            games.Add(new Games(){Id = 5, Name = "Game5", Price = 30});
            return games;
        }

        [HttpGet]
        public IEnumerable<Games> GetGames_List()
        {
            return GetGames();
        }

        [HttpGet("{id}")]
        public ActionResult<Games> GetGames_ById(int id)
        {
            var games = GetGames().Find(x => x.Id == id);
            if (games != null)
            {
                return games;
            } 
            else
            {
                return NotFound();
            }
        }
    }
}