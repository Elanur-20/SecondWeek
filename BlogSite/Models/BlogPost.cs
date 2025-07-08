using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlogSite.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public DateTime PublishDate { get; set; } = DateTime.Now;
        
        public bool IsPublished { get; set; } = true;
        public string? Summary { get; set; }
        public string? Tags { get; set; }

        [NotMapped]//Eðer viewcount tabloda olmayacaksa notmapped ekleyelim, olacaksa kaldýralým.
        public int? ViewCount { get; set; }
    }
}

