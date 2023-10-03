using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        public string? FormTitle { get; set; }
        public string? FormTitle2 { get; set; }
        public string? FormDescription { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string?  Address { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? LinkedIn { get; set; }


        public string? BannerTile { get; set; }  
        public string? BannerImg { get; set; }


        [NotMapped]
        public string? hiddenBannerImg { get; set; }

    }
}
