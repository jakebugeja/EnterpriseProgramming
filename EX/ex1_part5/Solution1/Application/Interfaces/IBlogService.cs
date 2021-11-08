using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Interfaces
{
    public interface IBlogService
    {
        public IQueryable<BlogViewModel> GetBlogs();//IQueryable<>: is a list
        public BlogViewModel GetBlog(int id);
    }
}
