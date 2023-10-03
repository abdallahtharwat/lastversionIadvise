using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }
       

        [Required]
        public string Answer { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string heading { get; set; }
        [Required]
        public string collapse { get; set; }
    }
}
