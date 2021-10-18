using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAcess
{
    
    public class BloggingContext:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        //removed the connections string

        
    }
}
