using System;
using System.Collections.Generic;

namespace RentalVideoStore
{
    public class Videos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Classification Classification { get; set; }
        public int GenreId { get; set; }
        public Genres Genres { get; set; }
        public List<Tags> Tags { get; set; }
    }
}
