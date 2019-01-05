using System.Data.Entity.ModelConfiguration;
using TestApi.Models;

namespace TestApi.EntityConfigurations
{
    public class GigConfiguration : EntityTypeConfiguration<Gig>
    {
        public GigConfiguration()
        {
            Property(gg => gg.Venue)
                .IsRequired()
                .HasMaxLength(200);

            Property(gg => gg.DateTime)
                .IsRequired();

            //// relation ////
            // Many-To-One with Genre
            HasRequired(gg => gg.Genre)
                .WithMany(gn => gn.Gigs)
                .HasForeignKey(gg => gg.GenreId);
        }
    }
}