using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    //fields are normally private
    //properties are often public
    public class Category
    {
        //[Key ctrl+.] --> this will generate:using System.ComponentModel.DataAnnotations;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
