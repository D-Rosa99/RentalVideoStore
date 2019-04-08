using System.Collections.Generic;

namespace RentalVideoStore
{
    public class Genres
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Videos> Videos { get; set; }
    }
}
