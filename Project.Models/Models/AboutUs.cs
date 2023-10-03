using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.Models
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Banner Title")]
        public string? Title1 { get; set; }
        [Display(Name = "Main Title")]
        public string? Title2 { get; set; }
        [Display(Name = "Footer Title")]
        public string? Title3 { get; set; }
        public string? Description { get; set; }
        [Display(Name = "Banner")]
        public string? Image1 { get; set; }
        [Display(Name = "Main Image")]
        public string? Image2 { get; set; }


        [NotMapped]
        public string? hiddenImage1 { get; set; }

        [NotMapped]
        public string? hiddenImage2 { get; set; }

    }
}
