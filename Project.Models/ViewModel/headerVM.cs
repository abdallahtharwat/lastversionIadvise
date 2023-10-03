using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;

namespace Project.Models.ViewModel
{
    public class headerVM
    {
        public Header header { get; set; }
        public WhyUs WhyUs { get; set; }
        public AboutUs  AboutUs { get; set; }
        public ContactUs  contactus { get; set; }

        public List<Feature> features { get; set; }

        public List<IconService> Icons { get; set; }
        public List<servicefeature> servicefeatureslist { get; set; }
        public IEnumerable<testimonial>  testimonials { get; set; }
      
        public List<Package> package { get; set; }
        public List<PackageContent>  packageContents { get; set; }
        public List<FAQ>  FAQs { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> PackageList { get; set; }

    }
}
