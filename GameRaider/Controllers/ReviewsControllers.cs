using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GameRaider.Models;
using Microsoft.EntityFrameworkCore;

namespace GameRaider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private GameRaiderContext _db;

        public ReviewsController(GameRaiderContext db)
        {
            _db = db;
        }
        
        [HttpPost]
        public void Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            Game foundGame = _db.Games.FirstOrDefault(game => game.GameId == review.GameId);
            foundGame.Reviews.Add(review);
            _db.SaveChanges();
        }
        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get(string reviewAuthor, string publishDate, int raiding, string title )
        {
            var query = _db.Reviews.AsQueryable();

            if (reviewAuthor != null)
            {
                query = query.Where(entry => entry.ReviewAuthor == reviewAuthor);
            }
            if (publishDate != null)
            {
                query = query.Where(entry => entry.PublishDate == publishDate);
            }
            if (title != null) 
            {
                query = query.Where(entry => entry.Game.Title == title);
            }

            if (raiding != 0)
            {
                query = query.Where(entry => entry.Raiding >= raiding);
            }
            return query.ToList();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Review review)
        {
            review.ReviewId = id;
            _db.Entry(review).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
        _db.Reviews.Remove(reviewToDelete);
        _db.SaveChanges();
        }

    }
}
