using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideoStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VIDZYcontext();
            List<Genres> genres = new List<Genres>();
            genres.Add(new Genres { Name = "Comedy" });
            genres.Add(new Genres { Name = "Family" });
            genres.Add(new Genres { Name = "Horror" });
            genres.Add(new Genres { Name = "Action" });
            genres.Add(new Genres { Name = "18+" });

            foreach(var genre in genres)
            {
                context.Genres.Add(genre);
            }

            context.SaveChanges();

        }
    }
}
