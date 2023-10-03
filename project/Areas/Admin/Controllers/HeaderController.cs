﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;

namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HeaderController : Controller
    {

        private readonly IUnitofWork _UnitofWork;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public HeaderController(IUnitofWork unitofWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitofWork = unitofWork;
            _WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Header> featurelist = _UnitofWork.Header.GetAll().ToList();
            return View(featurelist);
        }


        // get create
        public IActionResult Create()
        {

            return View();
        }

        // post create
        [HttpPost]
        public IActionResult Create(Header header, IFormFile? file)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
        {


            //Validation for sliver side
            if (ModelState.IsValid)
            {
                string wwwRootPath = _WebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product\");


                    // change photos and delete old photo if Exists
                    if (!string.IsNullOrEmpty(header.ImageUrl))
                    {
                        var oldimagepath = Path.Combine(wwwRootPath, header.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldimagepath))
                        {
                            System.IO.File.Delete(oldimagepath);
                        }
                    }
                    // change piets to file and  (( Save the photo))
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))  // where to have save the file
                    {
                        file.CopyTo(fileStream);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    header.ImageUrl = @"\images\product\" + fileName;
                }


                _UnitofWork.Header.add(header);
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

            Header? lenstypefromDb = _UnitofWork.Header.Get(u => u.Id == id); ;
            if (lenstypefromDb == null)
            {
                return NotFound();
            }

            lenstypefromDb.hiddenImageUrl = lenstypefromDb.ImageUrl;
            return View(lenstypefromDb);
        }

        // post Edit
        [HttpPost]
        public IActionResult Edit(Header header, IFormFile? file)
        {

            //Validation for sliver side
            if (ModelState.IsValid)
            {
                string wwwRootPath = _WebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product\");


                    // change photos and delete old photo if Exists
                    if (!string.IsNullOrEmpty(header.ImageUrl))
                    {
                        var oldimagepath = Path.Combine(wwwRootPath, header.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldimagepath))
                        {
                            System.IO.File.Delete(oldimagepath);
                        }   
                    }

                    // change piets to file and  (( Save the photo))
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))  // where to have save the file
                    {
                        file.CopyTo(fileStream);      // that will copy the file in the new location|| that we added  in line 76
                    }
                    header.ImageUrl = @"\images\product\" + fileName;


                }


                if (header.ImageUrl ==null && header.hiddenImageUrl == null)
                {
                    TempData["error"] = "You Need choose Image Again";
                    return RedirectToAction("Edit");
                }

                if (header.ImageUrl == null && header.hiddenImageUrl != null)
                {
                    header.ImageUrl = header.hiddenImageUrl;
                }

                    _UnitofWork.Header.Update(header);
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
            Header LenstypefromDb = _UnitofWork.Header.Get(u => u.Id == id);
            if (LenstypefromDb == null)
            {
                return NotFound();
            }

            return View(LenstypefromDb);
        }

        // post Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult Deletepost(int? id, IFormFile? file)
        {
            // Category? obj = _db.Category.Get(u => u.Id == id);
            Header obj = _UnitofWork.Header.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }



            _UnitofWork.Header.Remove(obj);
            _UnitofWork.Save();
            TempData["success"] = "  Delete successfully";
            return RedirectToAction("Index");


        }













    }
}
