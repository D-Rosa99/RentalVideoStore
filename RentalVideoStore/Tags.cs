using System.Collections.Generic;

namespace RentalVideoStore
{
    public class Tags
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Videos> Videos { get; set; }
    }
}
