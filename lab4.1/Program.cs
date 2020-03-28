using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab4._1.Models;
using Microsoft.EntityFrameworkCore;

namespace lab4._1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await using var context = new BlogContext();

            var videoPost = new VideoPost
            {
                Blog = new Blog()
                {
                    CreatedOn = DateTime.Now,
                    Name = "Test"
                },
                CreatedOn = DateTime.Now,
                VideoURL = "testsetstet"
            };
            

            await context.Posts.AddAsync(videoPost);
            await context.SaveChangesAsync();
        }
    }
}