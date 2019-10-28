using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
namespace GameRaider.Models
{
    public class Game
    {
        public Game()
        {
            this.Reviews = new HashSet<Review>();
        }
        public int GameId { get; set; }
        public int Raiding { get; set; }

        public string Title { get; set; }

        public string Studio { get; set; }

        public string ReleaseDate { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}