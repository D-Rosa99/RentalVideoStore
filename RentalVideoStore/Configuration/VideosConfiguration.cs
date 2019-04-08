using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideoStore.Configuration
{
    public class VideosConfiguration : EntityTypeConfiguration<Videos>
    {
        public VideosConfiguration()
        {

            Property(n => n.Name)
            .IsRequired()
            .HasMaxLength(255);


            Property(g => g.GenreId)
            .IsRequired();


            HasRequired(v => v.Genres)
            .WithMany(g => g.Videos)
            .HasForeignKey(v => v.GenreId);

            HasMany(v => v.Tags)
                .WithMany(t => t.Videos)
                .Map(m => {
                    m.ToTable("VideoTags");
                    m.MapLeftKey("VideoId");
                    m.MapRightKey("TagId");
                    }
                );


            Property(c => c.Classification)
            .HasColumnType("tinyint");
        }
    }
}
