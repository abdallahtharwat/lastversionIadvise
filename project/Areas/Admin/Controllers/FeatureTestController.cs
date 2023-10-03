using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.DataAccess.Repository;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;
using Project.Models.ViewModel;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;


namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureTestController : Controller
    {


        private readonly IUnitofWork _UnitofWork;
   
        public FeatureTestController(IUnitofWork unitofWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitofWork = unitofWork;

        }

        public async Task< IActionResult> Index()
        {
           
            return View(await _UnitofWork.featureTest.GetAllAboutUsAsync());
        }



        // get create
        public IActionResult Create()
        {

            return View();
        }


        // post create
        [HttpPost]
        public async Task<IActionResult> Create(Featuretest header)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
        {


            //Validation for sliver side
            if (ModelState.IsValid)
            {

                try
                {
                    var featuretest = await _UnitofWork.featureTest.AddAboutUsAsync(header);
                    if (featuretest)
                    {
                        TempData["success"] = "  Create successfully";
                        return RedirectToAction("Index");
                    }

                }
                catch (Exception)
                {

                    
                }
                
              
            }
            return View();
        }



        // get Edit
        public async Task<IActionResult> Edit(int id)
        {

            // how to create edit btton
            if ( id == 0)
            {
                return NotFound();
            }

            var featuretest = await _UnitofWork.featureTest.GetAboutUsAsync(id);
            if (featuretest == null)
            {
                return NotFound();
            }

            return View(featuretest);
        }

        // post Edit
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Featuretest header)
        {

            if (id != header.Id)
            {
                return NotFound();
            }

            //Validation for sliver side
            if (ModelState.IsValid)
            {

                try
                {
                    var featuretest = await _UnitofWork.featureTest.UpdateAboutUsAsync(header);
                    if (featuretest)
                    {
                        TempData["success"] = "  Update successfully";
                        return RedirectToAction("Index");
                    }


                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!(await IsAboutUsExist(header.Id)))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }

                }

            }
            return View(header);
        }

        public async Task<bool> IsAboutUsExist(int id)
        {
            return await _UnitofWork.featureTest.AboutUsAnyAsync(id);
        }



        public async Task<JsonResult> JsonDelete(int? id)
        {
            if (id == null)
            {
                return Json("Failed");

            }
            var result = await _UnitofWork.featureTest.DeleteAboutUsAsync(id.Value);
            if (result)
            {

                return Json("Removed");
            }
            return Json("Failed");
        }

        public async Task<JsonResult> JsonDuplicate(int? id)
        {
            if (id == null)
            {
                return Json("Failed");

            }
            var result = await _UnitofWork.featureTest.DuplicateAboutUsAsync(id.Value);
            if (result)
            {

                _UnitofWork.Save();
                TempData["success"] = "  duplicate successfully";
                return Json("Duplicated");
            }
            return Json("Failed");

        }







    }
}
