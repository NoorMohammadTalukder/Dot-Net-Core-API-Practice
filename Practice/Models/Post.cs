using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Fill the title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Fill the Description")]
        public string Description { get; set; } 

        public DateTime CreatedDate { get; set; }=DateTime.Now;
    }
}
