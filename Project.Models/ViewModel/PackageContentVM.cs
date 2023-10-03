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
    public class PackageContentVM
    {

        public PackageContent packageContent { get; set; }




        //public SelectList PackageList { get; set; }


        [ValidateNever]
        public IEnumerable<SelectListItem> PackageList { get; set; }


    }
}
