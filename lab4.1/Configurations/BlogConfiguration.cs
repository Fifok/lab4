using lab4._1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab4._1.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("Blogs");
            builder.Property(x => x.Name).HasMaxLength(50);

            builder
                .HasMany(x => x.Posts)
                .WithOne(x =>x.Blog);
        }
    }
}