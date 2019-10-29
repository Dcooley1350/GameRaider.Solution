using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GameRaider.Models;
using Microsoft.EntityFrameworkCore;

namespace GameRaider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private GameRaiderContext _db;

        public GamesController(GameRaiderContext db)
        {
            _db = db;
        }
        
        [HttpPost]
        public void Post([FromBody] Game game)
        {
            _db.Games.Add(game);
            _db.SaveChanges();
        }
        [HttpGet("{id}")]
        public ActionResult<Game> Get(int id)
        {
            return _db.Games.FirstOrDefault(entry => entry.GameId == id);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Game>> Get(string studio, string title, int raiding )
        {
        var query = _db.Games.AsQueryable();

        if (studio != null)
        {
            query = query.Where(entry => entry.Studio == studio);
        }
        if (title != null)
        {
            query = query.Where(entry => entry.Title == title);
        }
        if (raiding != 0)
            query = query.Where(entry => entry.Raiding >= raiding);


        return query.ToList();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Game game)
        {
            game.GameId = id;
            _db.Entry(game).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        var gameToDelete = _db.Games.FirstOrDefault(entry => entry.GameId == id);
        _db.Games.Remove(gameToDelete);
        _db.SaveChanges();
        }

    }
}

