using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;

namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceFeatureController : Controller
    {

        private readonly IUnitofWork _UnitofWork;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ServiceFeatureController(IUnitofWork unitofWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitofWork = unitofWork;
            _WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<servicefeature> IconServicelist = _UnitofWork.serviceFeature.GetAll().ToList();
            return View(IconServicelist);
        }


        // get create
        public IActionResult Create()
        {

            return View();
        }

        // post create
        [HttpPost]
        public IActionResult Create(servicefeature iconService)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
        {


            //Validation for sliver side
            if (ModelState.IsValid)
            {
                _UnitofWork.serviceFeature.add(iconService);
                _UnitofWork.Save();
                TempData["success"] = "  Create successfully";
                return RedirectToAction("Index");
            }
            return View();
        }



        // get Edit
        public IActionResult Edit(int? id)
        {


            // how to create edit btton
            if (id == null || id == 0)
            {
                return NotFound();
            }

            servicefeature? IconServicefromDb = _UnitofWork.serviceFeature.Get(u => u.Id == id); ;
            if (IconServicefromDb == null)
            {
                return NotFound();
            }

            return View(IconServicefromDb);
        }

        // post Edit
        [HttpPost]
        public IActionResult Edit(servicefeature iconService)
        {

            //Validation for sliver side
            if (ModelState.IsValid)
            {

                _UnitofWork.serviceFeature.Update(iconService);
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
            servicefeature LenstypefromDb = _UnitofWork.serviceFeature.Get(u => u.Id == id);
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
            servicefeature obj = _UnitofWork.serviceFeature.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }



            _UnitofWork.serviceFeature.Remove(obj);
            _UnitofWork.Save();
            TempData["success"] = "  Delete successfully";
            return RedirectToAction("Index");


        }













    }
}
