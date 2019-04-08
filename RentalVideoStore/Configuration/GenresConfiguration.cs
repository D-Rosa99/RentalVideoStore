using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideoStore.Configuration
{
    public class GenresConfiguration : EntityTypeConfiguration<Genres>
    {
        public GenresConfiguration()
        {
            Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(255);
        }
       
    }
}
