using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    //fields are normally private
    //properties are often public
    class Post
    {
        //[Key ctrl+.] --> this will generate:using System.ComponentModel.DataAnnotations;
        [Key]//Primary Key making also the property an identity (auto increment)
        public int Id { get; set; }
        public string Title{ get; set; }
        public int BlogId{ get; set; }//foreign key

        //ctrl+. OR 'click on the yellow bulb in the gui'
            //this attributes means that this attribute rapresents the property "Blog" for refernece
        [ForeignKey("Blog")]
        public Blog Blog{ get; set; }//serve as a reference to the other table
                                    //holds all the properties containing from Blog
        public DateTime DateCreated{ get; set; }
        public string Author{ get; set; }
    }
}
