using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using testToDelete2.Models;

namespace testToDelete2.Data
{
    //DbContext instance options stores many functions, such as;
    //connstions tring to use etc...
    //Best way to use the instance options is to create a constructor
    public class ApplicationDbContext : IdentityDbContext
    {
        //constructor and passing instance
        //"DbContextOptions<ApplicatoinDbContext>"-->options are passed to 
        //this class: <ApplicatoinDbContext>
        //"options" : giving the instance a name
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        //declare a property for every model
        //property is used to query and save instances of this class
        public DbSet<Product> Products { get; set; }
    }

    
}
