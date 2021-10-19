using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAcess
{
    //this is the class which is the gateway to our databse
    //this inherits from a built in class called xxxDbContext
    //the dbcontext class contains methods which will allowus to
    //amongst other things to connect with the database; add an item
    //to the database, delete, querying using LINQ...
    public class BloggingContext:DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext>options)://this is a contructor
            base(options)                                //options is passed to the base class
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        //removed the connections string

        
    }
}
