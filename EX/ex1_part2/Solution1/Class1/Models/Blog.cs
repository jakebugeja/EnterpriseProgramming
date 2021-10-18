using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    //fields are normally private
    //properties are often public
    class Blog
    {
        //[Key ctrl+.] --> this will generate:using System.ComponentModel.DataAnnotations;
        [Key]//Primary Key making also the property an identity (auto increment)
        public int Id { get; set; }
        //name is required
        [Required]
        public int Name { get; set; }
        public int LogoImagePath { get; set; }
        public DateTime DateCreated{ get; set; }
        public DateTime DateUpdated{ get; set; }

        //ctrl+. OR 'click on the yellow bulb in the gui'
        //this attributes means that this attribute rapresents the property "Category" for refernece
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }//serve as a reference to the other table
                                              //holds all the properties containing from Category
    }
}
