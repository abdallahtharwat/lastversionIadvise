using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Project.Models.Models
{
    public class IconService
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Home Page Title")]
        public string HomePageTitle { get; set; }
        [Required]
        [Display(Name = "Home Page Description")]
        public string HomePageDescription { get; set; }
        [Required]
        [Display(Name = "Home Page Icon")]
        public string HomePageIcon { get; set; }

        [Required]
        [Display(Name = "Banner Title")]
        public string BannerTitle { get; set; }
        [ValidateNever]

        [Display(Name = "Banner Img")]
        public string Bannerimg { get; set; }


        [Required]
        [Display(Name = "Main Title")]
        public string  MainTitle { get; set; }
        [Required]
        [Display(Name = "Main Description")]
        public string MainDescription { get; set; }


        [Required]
        [Display(Name = "Content Title")]
        public string ContentTitle { get; set; }
        [Required]
        [Display(Name = "Content Description")]
        public string ContentDescription { get; set; }
        [Required]
        [Display(Name = "Content Question")]
        public string ContentQuestion { get; set; }
        [ValidateNever]
        [Display(Name = "Content Img")]
        public string Contentimg { get; set; }

        [Required]
        [Display(Name = "Content Description footer")]
        public string ContentDescriptionfooter { get; set; }


        [Required]
        [Display(Name = "section Title")]
        public string sectionTitle { get; set; }
        [Required]
        [Display(Name = "section Description")]
        public string sectionDescription { get; set; }


        [Required]
        [Display(Name = "section Title1")]
        public string sectionTitle1 { get; set; }
        [Required]
        [Display(Name = "section Description 1")]
        public string sectionDescription1 { get; set; }

        [ValidateNever]
        [Display(Name = "section Img1")]
        public string sectionimg1 { get; set; }



        [Required]
        [Display(Name = "section Title2")]
        public string sectionTitle2 { get; set; }
        [Required]
        [Display(Name = "section Description2")]
        public string sectionDescription2 { get; set; }

        [ValidateNever]
        [Display(Name = "section Img2")]
        public string sectionimg2 { get; set; }



        [Required]
        [Display(Name = "section Title3")]
        public string sectionTitle3 { get; set; }
        [Required]
        [Display(Name = "section Description3")]
        public string sectionDescription3 { get; set; }

        [ValidateNever]
        [Display(Name = "section Img3")]
        public string sectionimg3 { get; set; }

        public ICollection<ServicePointFeatures>?  ServicePointFeatures { get; set; }

    }
}
