using System;
using System.Collections.Generic;
using System.Text;

namespace Class1
{
    class Blog
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int LogoImagePath { get; set; }
        public DateTime DateCreated{ get; set; }
        public DateTime DateUpdated{ get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
