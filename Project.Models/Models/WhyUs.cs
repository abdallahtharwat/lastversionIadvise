using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.Models
{
    public class WhyUs
    {
        [Key]
        public int Id { get; set; }
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Description1 { get; set; }
        public string? TextArea { get; set; }
        public string? ImageUrl { get; set; }

        [NotMapped]
        public string? hiddenImageUrl { get; set; }



    }
}
