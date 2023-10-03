using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.Models
{
    public class Header
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public string? hiddenImageUrl { get; set; }



    }
}
