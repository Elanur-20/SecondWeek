using System.ComponentModel.DataAnnotations;

namespace BlogSite.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public bool IsPublished { get; set; } = true;

        public string? Summary { get; set; }

        public string? Tags { get; set; }
    }
}