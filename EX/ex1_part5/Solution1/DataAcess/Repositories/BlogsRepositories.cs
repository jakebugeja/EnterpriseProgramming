using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcess.Repositories
{
    public class BlogsRepositories : IBlogsRepository
    {
        private BloggingContext context;
        public BlogsRepositories(BloggingContext _context)
        {
            context = _context;
        }
        public void AddBlog(Blog b)
        {
            context.Blogs.Add(b);
            context.SaveChanges();
        }

        public void DeleteBlog(Blog b)
        {
            context.Blogs.Remove(b);
            context.SaveChanges();
        }

        public Blog GetBlog(int id)
        {
            return context.Blogs.SingleOrDefault(x => x.Id == id);
        }

        public IQueryable<Blog> GetBlogs()
        {
            return context.Blogs; 
        }

        public void UpdateBlog(Blog b)
        {
            Blog originalBlog = GetBlog(b.Id);
            originalBlog.DateUpdated = DateTime.Now;
            originalBlog.CategoryId = b.CategoryId;
            originalBlog.LogoImagePath = b.LogoImagePath;
            originalBlog.Name = b.Name;

            context.SaveChanges();
        }
    }
}
