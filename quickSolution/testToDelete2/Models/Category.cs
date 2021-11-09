using System.ComponentModel.DataAnnotations;

namespace testToDelete2.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string category { get; set; }
    }
}