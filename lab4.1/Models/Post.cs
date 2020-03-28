using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace lab4._1.Models
{
    public enum PostType
    {
        Video,
        Podcast,
        Text
    }
    public abstract class Post
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        public string Title { get; set; }
        public PostType PostType { get; set; }
    }
    
    public class VideoPost : Post
    {
        public string VideoURL { get; set; }
    }
    public class PodcastPost : Post
    {
        public string PodcastURL { get; set; }
    }
    public class TextPost : Post
    {
        public string TextContent { get; set; }
    }
    
    
}