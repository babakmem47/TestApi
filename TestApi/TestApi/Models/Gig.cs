using System;

namespace TestApi.Models
{
    public class Gig
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public string Venue { get; set; }

        public Genre Genre { get; set; }

        public int GenreId { get; set; }

    }
}