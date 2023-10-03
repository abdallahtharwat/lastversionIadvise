using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.DataAccess.Repository.IRepository;
using Project.DataAccesss.Data;
using Project.Models.Models;
using System.Data;

namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureController : Controller
    {


        private readonly IUnitofWork _UnitofWork;
        public FeatureController(IUnitofWork unitofWork)
        {
            _UnitofWork = unitofWork;
        }

        public IActionResult Index()
        {
            List<Feature> featurelist = _UnitofWork.Feature.GetAll().ToList();
            return View(featurelist);
        }




        // get create
        public IActionResult Create()
        {

            return View();
        }

        // post create
        [HttpPost]
        public IActionResult Create(Feature obj)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
        {


            //Validation for sliver side
            if (ModelState.IsValid)
            {
                _UnitofWork.Feature.add(obj);
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

            Feature? lenstypefromDb = _UnitofWork.Feature.Get(u => u.Id == id); ;
            if (lenstypefromDb == null)
            {
                return NotFound();
            }

            return View(lenstypefromDb);
        }

        // post Edit
        [HttpPost]
        public IActionResult Edit(Feature obj)
        {

            //Validation for sliver side
            if (ModelState.IsValid)
            {
                _UnitofWork.Feature.Update(obj);
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
            Feature LenstypefromDb = _UnitofWork.Feature.Get(u => u.Id == id);
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
            Feature obj = _UnitofWork.Feature.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _UnitofWork.Feature.Remove(obj);
            _UnitofWork.Save();
            TempData["success"] = "  Delete successfully";
            return RedirectToAction("Index");


        }


        public async Task<JsonResult> JsonDuplicate(int? id)
        {
            if (id == null)
            {
                return Json("not Failed Id");

            }
            var result = await _UnitofWork.Feature.DuplicatefeatureAsync((int)id);
            if (result)
            {

                _UnitofWork.Save();
                TempData["success"] = "  duplicate successfully";
                return Json("Duplicated");
            }
            return Json("there is no data");



        }


        public async Task<JsonResult> JsonDelete(int? id)
        {
            if (id == null)
            {
                return Json("Failed");

            }
            var result = await _UnitofWork.Feature.DeletefeatureAsync((int)id);
            if (result)
            {
                return Json("Removed");
            }
            return Json("Failed");
        }





        public IActionResult Admin()
        {
            return View();
        }






    }
}
