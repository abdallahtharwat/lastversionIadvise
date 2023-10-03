using Microsoft.AspNetCore.Mvc;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;
using Project.Models.ViewModel;

namespace project.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ServicePageController : Controller
    {
        private readonly IUnitofWork _UnitofWork;
        public ServicePageController(IUnitofWork unitofWork)
        {
            _UnitofWork = unitofWork;
        }

        public IActionResult Details(int? id)
        {

            var u = _UnitofWork.iconservice.Get(u => u.Id == id);

            var iconservice = new IconService   // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Id = u.Id,
                HomePageTitle = u.HomePageTitle,
                HomePageDescription = u.HomePageDescription,
                HomePageIcon = u.HomePageIcon,

                BannerTitle = u.BannerTitle,
                Bannerimg = u.Bannerimg,


                MainTitle = u.MainTitle,
                MainDescription = u.MainDescription,


                ContentTitle = u.ContentTitle,
                ContentDescription = u.ContentDescription,
                ContentQuestion = u.ContentQuestion,
                Contentimg = u.Contentimg,
                ContentDescriptionfooter = u.ContentDescriptionfooter,


                sectionTitle = u.sectionTitle,
                sectionDescription = u.sectionDescription,


                sectionTitle1 = u.sectionTitle1,
                sectionDescription1 = u.sectionDescription1,
                sectionimg1 = u.sectionimg1,

                sectionTitle2 = u.sectionTitle2,
                sectionDescription2 = u.sectionDescription2,
                sectionimg2 = u.sectionimg2,

                sectionTitle3 = u.sectionTitle3,
                sectionDescription3 = u.sectionDescription3,
                sectionimg3 = u.sectionimg3,
            };



            var servicepoint = _UnitofWork.servicepoint.GetAll().Select(u => new ServicePointFeatures  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = u.Title,
                Description = u.Description,
                Icon = u.Icon,
                iconserviceId = u.iconserviceId,
                Id = u.Id,

            });



            NewServiceVM servicevm = new()
            {

                servicepointfeature = servicepoint.ToList(),
                iconService = iconservice,

            };


            return View(servicevm);
        }





    }
}
