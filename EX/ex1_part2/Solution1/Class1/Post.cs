using System;
using System.Collections.Generic;
using System.Text;

namespace Class1
{
    class Post
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public int BlogId{ get; set; }//foreign key
        public Blog Blog{ get; set; }
        public DateTime DateCreated{ get; set; }
        public string Author{ get; set; }
    }
}
