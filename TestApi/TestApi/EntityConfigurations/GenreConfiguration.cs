using System.Data.Entity.ModelConfiguration;
using TestApi.Models;

namespace TestApi.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            HasKey(gn => gn.Id);

            Property(gn => gn.Name)
                .IsRequired()
                .HasMaxLength(50);

            //// relation ////
            // One-To-Many with Gig
            HasMany(gn => gn.Gigs)
                .WithRequired(gg => gg.Genre)
                .WillCascadeOnDelete(false);

        }
    }
}