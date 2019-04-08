using RentalVideoStore.Configuration;
using System.Data.Entity;

namespace RentalVideoStore
{
    public class VIDZYcontext : DbContext
    {
        public VIDZYcontext()
            : base("name=DefaultString")
        {

        }
        public DbSet<Videos> Videos { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Tags> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GenresConfiguration());
            modelBuilder.Configurations.Add(new VideosConfiguration());
        }
    }
}
