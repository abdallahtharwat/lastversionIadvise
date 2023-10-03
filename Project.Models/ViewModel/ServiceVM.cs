using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.ViewModel
{
    public class ServiceVM
    {
        //public ServiceVM()
        //{
        //    iconService = new IconService();
        //}
        public ServicePointFeatures servicepointfeature  { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> iconserviceList { get; set; }
    }
   
}
