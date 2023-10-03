using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.DataAccess.Repository.IRepository;
using Project.DataAccesss.Data;
using Project.Models.Models;
using Project.Models.ViewModel;
using System.Data;


namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicePointController : Controller
    {

        private readonly IUnitofWork _UnitofWork;
        public ServicePointController(IUnitofWork unitofWork)
        {
            _UnitofWork = unitofWork;
        }

        public IActionResult Index()
        {

            List<ServicePointFeatures> featurelist = _UnitofWork.servicepoint.GetAll(includeproperties: "IconService").ToList();
            return View(featurelist);

        }

        // get create
        public IActionResult Create()
        {


            ServiceVM serviceVM = new()
            {
                iconserviceList = _UnitofWork.iconservice.GetAll().Select(u => new SelectListItem  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
                {
                    Text = u.HomePageTitle,
                    Value = u.Id.ToString(),


                }),



                servicepointfeature = new ServicePointFeatures()


            };

            return View(serviceVM);
        }

        // post create
        [HttpPost]
        public IActionResult Create(ServiceVM obj)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
        {


            //Validation for sliver side
            if (ModelState.IsValid)
            {
                _UnitofWork.servicepoint.add(obj.servicepointfeature);
                _UnitofWork.Save();
                TempData["success"] = "  Create successfully";
                return RedirectToAction("Index");
            }
            else
            {

                obj.iconserviceList = _UnitofWork.iconservice.GetAll().Select(u => new SelectListItem  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
                {
                    Text = u.HomePageTitle,
                    Value = u.Id.ToString(),


                });
                return View(obj);
            }

        }



        // get Edit
        public IActionResult Edit(int? id)
        {

            // how to create edit btton
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var e = _UnitofWork.servicepoint.Get(u => u.Id == id);

            var ServicePointFeature = new ServicePointFeatures   // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = e.Title,
                Icon = e.Icon,
                Description = e.Description,
                Id = e.Id,
                iconserviceId = e.iconserviceId
            };


            ServiceVM serviceVM = new()
            {
                iconserviceList = _UnitofWork.iconservice.GetAll().Select(u => new SelectListItem  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
                {
                    Text = u.HomePageTitle,
                    Value = u.Id.ToString(),
                    Selected = u.Id == e.iconserviceId,

                }),

                servicepointfeature = ServicePointFeature,

            };

            //PackageContent? IconServicefromDb = _UnitofWork.packagecontent.Get(u => u.Id == id); ;


            if (serviceVM == null)
            {
                return NotFound();
            }


            return View(serviceVM);
        }

        // post Edit
        [HttpPost]
        public IActionResult Edit(ServiceVM obj)
        {

            //Validation for sliver side
            if (ModelState.IsValid)
            {
                _UnitofWork.servicepoint.Update(obj.servicepointfeature);
                _UnitofWork.Save();
                TempData["success"] = "  Update successfully";
                return RedirectToAction("Index");
            }
            return View();
        }




        // get Delete
        public IActionResult Delete(int? id)
        {

            // how to create edit btton
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //  Category? categoryfromDb = _UnitofWork.Category.Get(u => u.Id == id);
            ServicePointFeatures? LenstypefromDb = _UnitofWork.servicepoint.Get(u => u.Id == id);
            if (LenstypefromDb == null)
            {
                return NotFound();
            }

            return View(LenstypefromDb);
        }

        // post Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult Deletepost(int? id)
        {
            // Category? obj = _db.Category.Get(u => u.Id == id);
            ServicePointFeatures? obj = _UnitofWork.servicepoint.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _UnitofWork.servicepoint.Remove(obj);
            _UnitofWork.Save();
            TempData["success"] = "  Delete successfully";
            return RedirectToAction("Index");


        }



    }
}
