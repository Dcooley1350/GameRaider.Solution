using System.Collections.Generic;
using System;


namespace GameRaider.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int GameId { get; set; }
        public string ReviewAuthor { get; set; }
        public string ReviewText { get; set; }
        public string PublishDate { get; set; }
        public int Raiding { get; set; }
        public virtual Game Game { get; set; }
    }

}
