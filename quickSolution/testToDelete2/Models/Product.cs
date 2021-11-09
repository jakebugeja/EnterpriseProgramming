using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testToDelete2.Models
{
    public class Product
    {
        /*
         * Products table:
            id 
            name
            price
            description
            imageUrl
            categoryId
        */
        [Key]
        public int Id { get; set; }
        public int name { get; set; }
        public int price { get; set; }
        public int description { get; set; }
        public int imageUrl { get; set; }

        [ForeignKey("Category")]
        public int categoryId { get; set; }
        public Category Category { get; set; }//serve as a reference to the other table
                                              //holds all the properties containing from Category
    }
}
