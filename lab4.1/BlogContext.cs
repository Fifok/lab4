using lab4._1.Configurations;
using lab4._1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace lab4._1
{
    public class BlogContext : DbContext
    {
        public ILoggerFactory LoggerConsole { get; set; } = LoggerFactory.Create(x=> x.AddConsole()); 
        
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        // public DbSet<VideoPost> VideoPosts { get; set; }
        // public DbSet<PodcastPost> PodcastPosts { get; set; }
        // public DbSet<TextPost> TextPosts { get; set; }
        
       
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=Blog;User Id=sa;Password=Password4$;");
            optionsBuilder.UseLoggerFactory(LoggerConsole);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            // modelBuilder.Entity<VideoPost>();
            // modelBuilder.Entity<PodcastPost>();
            // modelBuilder.Entity<TextPost>();
        }
    }
}