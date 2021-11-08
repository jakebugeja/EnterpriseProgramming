using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class BlogsService : IBlogService
    {

        private IBlogsRepository blogsRepo;
        //constructor injection
        public BlogsService(IBlogsRepository _blogsRepo)
        {
            blogsRepo = _blogsRepo;
        }

        public BlogViewModel GetBlog(int id)
        //all this code will be merged into 1 line
        //when we introduce AutoMapper
        {
            var b = blogsRepo.GetBlog(id);
            BlogViewModel result = new BlogViewModel()
            {
                Category = b.Category,
                DateUpdated = b.DateUpdated,
                Id = b.Id,
                LogoImagePath = b.LogoImagePath,
                Name = b.Name;
        };
        return public IQueryable<BlogViewModel> GetBlogs()
        {
            throw new NotImplementedException();
        }

        result;
    }

        public IQueryable<BlogViewModel> GetBlogs()
        {
            var list = from b in blogsRepo.GetBlogs()
                       select new BlogViewModel()
                       {
                           Category = b.Category,
                           DateUpdated = b.DateUpdated,
                           Id = b.Id,
                           LogoImagePath = b.LogoImagePath,
                           Name = b.Name;
                        };
            return list;
        }
    }
}
