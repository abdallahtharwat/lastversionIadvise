using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.Models
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        //[ScaffoldColumn(false)]
        //[Required(ErrorMessage = "*")]
        //[DefaultValue(false)]
        //public bool Deleted { get; set; }


    }
}
