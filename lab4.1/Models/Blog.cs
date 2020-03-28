using System;
using System.Collections.Generic;

namespace lab4._1.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}