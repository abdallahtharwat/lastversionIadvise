using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.ViewModel
{
    public class NewServiceVM
    {
        public List<ServicePointFeatures> servicepointfeature { get; set; }
        public IconService iconService { get; set; }

        //[ValidateNever]
        //public IEnumerable<SelectListItem> iconserviceList { get; set; }
    }
}
