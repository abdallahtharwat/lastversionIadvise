using Microsoft.AspNetCore.Mvc;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;

namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class packageController : Controller
    {
        private readonly IUnitofWork _UnitofWork;
        public packageController(IUnitofWork unitofWork)
        {
            _UnitofWork = unitofWork;
        }

        public IActionResult Index()
        {
            List<Package> featurelist = _UnitofWork.Package.GetAll().ToList();
            return View(featurelist);
        }




        // get create
        public IActionResult Create()
        {

            return View();
        }

        // post create
        [HttpPost]
        public IActionResult Create(Package obj)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
        {


            //Validation for sliver side
            if (ModelState.IsValid)
            {
                _UnitofWork.Package.add(obj);
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

            Package? lenstypefromDb = _UnitofWork.Package.Get(u => u.Id == id); ;
            if (lenstypefromDb == null)
            {
                return NotFound();
            }

            return View(lenstypefromDb);
        }

        // post Edit
        [HttpPost]
        public IActionResult Edit(Package obj)
        {

            //Validation for sliver side
            if (ModelState.IsValid)
            {
                _UnitofWork.Package.Update(obj);
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
            Package LenstypefromDb = _UnitofWork.Package.Get(u => u.Id == id);
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
            Package obj = _UnitofWork.Package.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _UnitofWork.Package.Remove(obj);
            _UnitofWork.Save();
            TempData["success"] = "  Delete successfully";
            return RedirectToAction("Index");


        }



    }
}
