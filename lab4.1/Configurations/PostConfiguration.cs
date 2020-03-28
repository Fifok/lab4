using lab4._1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab4._1.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.HasDiscriminator<PostType>(x => x.PostType)
                .HasValue<VideoPost>(PostType.Video)
                .HasValue<PodcastPost>(PostType.Podcast)
                .HasValue<TextPost>(PostType.Text);
        }
    }
}