using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.Models
{
    public class ServicePointFeatures
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set;}



        public int iconserviceId { get; set; }  //( step 1 for forienKEY) -- STEP 2 in dbcontext class   -- step 3 in product controller -- step 4 in upsert view -- create viewmodel
        [ForeignKey("iconserviceId")]
        [ValidateNever]
        public IconService?  IconService { get; set; }


    }
}
