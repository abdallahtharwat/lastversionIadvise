using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using project.Models;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;
using Project.Models.ViewModel;
using reCAPTCHA.AspNetCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace project.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
      
        private readonly IFeedbackRepository _feedbackRepository;
        private readonly IRecaptchaService _recaptcha;
        private readonly IUnitofWork _UnitofWork;
        private readonly ILogger<HomeController> _logger;
    

        public HomeController(ILogger<HomeController> logger, IUnitofWork UnitofWork, IFeedbackRepository feedbackRepository, IRecaptchaService recaptcha )
        {
            _logger = logger;
            _UnitofWork = UnitofWork;
            _feedbackRepository = feedbackRepository;
            _recaptcha = recaptcha;
     
        }

        public IActionResult Index()
        {
            var u = _UnitofWork.Header.Get(u => u.Id > 0);

            var header = new Header   // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = u.Title,
                Description = u.Description,
                Id = u.Id,
                ImageUrl = u.ImageUrl,
            };


            var z = _UnitofWork.ContactUs.Get(u => u.Id > 0);

            var contactus = new ContactUs   // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                FormTitle = z.FormTitle,
                FormTitle2 = z.FormTitle2,
                FormDescription = z.FormDescription,
                PhoneNumber = z.PhoneNumber,
                Email = z.Email,
                Address = z.Address,
                Facebook = z.Facebook,
                Instagram = z.Instagram,
                LinkedIn = z.LinkedIn,
                Id = z.Id,

            };

            var e = _UnitofWork.WhyUs.Get(e => e.Id > 0);

            var whyus = new WhyUs   // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title1 = e.Title1,
                Title2 = e.Title2,
                Description1 = e.Description1,
                TextArea = e.TextArea,
                Id = e.Id,
                ImageUrl = e.ImageUrl,
            };

            var feature = _UnitofWork.Feature.GetAll().Select(u => new Feature  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = u.Title,
                Description = u.Description,
                Id = u.Id,

            });

            var icons = _UnitofWork.iconservice.GetAll().Select(u => new IconService  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
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


            });


            var servicefeatures = _UnitofWork.serviceFeature.GetAll().Select(u => new servicefeature  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = u.Title,
                Description = u.Description,
                Icon = u.Icon,
                Id = u.Id,

            });

            var package = _UnitofWork.Package.GetAll().Select(u => new Package  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = u.Title,
                TitleHTML = u.TitleHTML,
                Description = u.Description,
                Content = u.Content,
                Id = u.Id,

            });

            var packagecontent = _UnitofWork.packagecontent.GetAll().Select(u => new PackageContent  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = u.Title,
                Icon = u.Icon,
                Id = u.Id,
                packagetId = u.packagetId
            });

            var faq = _UnitofWork.FAQ.GetAll().Select(u => new FAQ  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Question = u.Question,
                Answer = u.Answer,
                heading = u.heading,
                collapse = u.collapse,
                Id = u.Id,

            });

            var testimonial = _UnitofWork.testimonial.GetAll().Select(u => new testimonial  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Name = u.Name,
                Feedback = u.Feedback,
                img = u.img,

                Id = u.Id,

            });

            headerVM headerVM = new()
            {
                testimonials = testimonial,
                contactus = contactus,
                WhyUs = whyus,
                header = header,
                features = feature.ToList(),
                Icons = icons.ToList(),
                servicefeatureslist = servicefeatures.ToList(),
                package = package.ToList(),
                packageContents = packagecontent.ToList(),
                FAQs = faq.ToList(),

            };

            // TODO: Load state from previously suspended application


            return View(headerVM);
        }




        public IActionResult PackagePage()
        {



            var package = _UnitofWork.Package.GetAll().Select(u => new Package  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = u.Title,
                TitleHTML = u.TitleHTML,
                Description = u.Description,
                Content = u.Content,
                Id = u.Id,

            });

            var packagecontent = _UnitofWork.packagecontent.GetAll().Select(u => new PackageContent  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = u.Title,
                Icon = u.Icon,
                Id = u.Id,
                packagetId = u.packagetId
            });



            headerVM headerVM = new()
            {


                package = package.ToList(),
                packageContents = packagecontent.ToList(),


            };

            // TODO: Load state from previously suspended application


            return View(headerVM);
        }




        public IActionResult AboutUs()
        {
            var u = _UnitofWork.aboutus.Get(u => u.Id > 0);

            var aboutus = new AboutUs   // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title1 = u.Title1,
                Title2 = u.Title2,
                Title3 = u.Title3,
                Description = u.Description,
                Id = u.Id,
                Image1 = u.Image1,
                Image2 = u.Image2,
            };




            headerVM headerVM = new()
            {

                AboutUs = aboutus,


            };
            return View(headerVM);
            // TODO: Load state from previously suspended application


            return View(headerVM);
        }


        public IActionResult FAQ()
        {
            List<FAQ> featurelist = _UnitofWork.FAQ.GetAll().ToList();
            return View(featurelist);
        }

        public IActionResult ContactUs()
        {
            var z = _UnitofWork.ContactUs.Get(u => u.Id > 0);

            var contactus = new ContactUs   // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                FormTitle = z.FormTitle,
                FormTitle2 = z.FormTitle2,
                FormDescription = z.FormDescription,
                PhoneNumber = z.PhoneNumber,
                Email = z.Email,
                Address = z.Address,
                Facebook = z.Facebook,
                Instagram = z.Instagram,
                LinkedIn = z.LinkedIn,
                Id = z.Id,

            };

            headerVM headerVM = new()
            {

                contactus = contactus,

            };




            return View(headerVM);
        }


        public IActionResult Privacy()
        {
            return View();
        }


     

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactForm(string language, Feedback feedback)
        {



            var recaptcha = await _recaptcha.Validate(Request);
            if (!recaptcha.success || recaptcha.score < 0.9)
                //return Json(new { status = "failed", message = language == "ar" ? "هناك خطأ ما!" : "Something went wrong!" });
                return RedirectToAction("Index", new { language });


            if (ModelState.IsValid)
            {
                //var host = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host;
                var result = await _feedbackRepository.SendEmail(feedback, language);

                if (result)
                {
                    //return Json(new { status = "success" });
                    TempData["success"] = "successfully";
                    return RedirectToAction("Index", new { language, Sent = true });

                }
            }

            //return Json(new { status = "failed", message = language == "ar" ? "هناك خطأ ما!" : "Something went wrong!" });
            return RedirectToAction("Index", new { language });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // TODO: Load state from previously suspended application2

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}