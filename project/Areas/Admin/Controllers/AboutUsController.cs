using Microsoft.AspNetCore.Mvc;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;
using Project.Models.ViewModel;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;


namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutUsController : Controller
    {

        private readonly IUnitofWork _UnitofWork;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public AboutUsController(IUnitofWork unitofWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitofWork = unitofWork;
            _WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<AboutUs> featurelist = _UnitofWork.aboutus.GetAll().ToList();
            return View(featurelist);
        }



        // get create
        public IActionResult Create()
        {

            return View();
        }


        // post create
        [HttpPost]
        public IActionResult Create(AboutUs header, IFormFile? file, IFormFile? file2)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
        {


            //Validation for sliver side
            if (ModelState.IsValid)
            {
                //image1
                string wwwRootPath = _WebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product\");



                    // change piets to file and  (( Save the photo))
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))  // where to have save the file
                    {
                        file.CopyTo(fileStream);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    header.Image1 = @"/images/product/" + fileName;

                }



                //image2
                string wwwRootPathh = _WebHostEnvironment.WebRootPath;
                if (file2 != null)
                {
                    string fileNamee = Guid.NewGuid().ToString() + Path.GetExtension(file2.FileName);
                    string productPathh = Path.Combine(wwwRootPathh, @"images\product\");



                    // change piets to file and  (( Save the photo))
                    using (var fileStreamm = new FileStream(Path.Combine(productPathh, fileNamee), FileMode.Create))  // where to have save the file
                    {
                        file2.CopyTo(fileStreamm);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    header.Image2 = @"/images/product/" + fileNamee;

                }

                // that way we will not get an exception if product image is null




                _UnitofWork.aboutus.add(header);
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

            AboutUs? lenstypefromDb = _UnitofWork.aboutus.Get(u => u.Id == id); ;
            if (lenstypefromDb == null)
            {
                return NotFound();
            }
            lenstypefromDb.hiddenImage1 = lenstypefromDb.Image1;
            lenstypefromDb.hiddenImage2 = lenstypefromDb.Image2;

            return View(lenstypefromDb);
        }

        // post Edit
        [HttpPost]
        public IActionResult Edit(AboutUs header, IFormFile? file, IFormFile? file2)
        {

            //Validation for sliver side
            if (ModelState.IsValid)
            {
                //image1
                string wwwRootPath = _WebHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product\");

                    if (!string.IsNullOrEmpty(header.Image1))
                    {
                        var oldimagepath = Path.Combine(wwwRootPath, header.Image1.TrimStart('\\'));
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

                    header.Image1 = @"/images/product/" + fileName;

                }

                if (header.Image1 == null && header.hiddenImage1 == null)
                {
                    TempData["error"] = "You Need choose Image Again";
                    return RedirectToAction("Edit");
                }

                if (header.Image1 == null && header.hiddenImage1 != null)
                {
                    header.Image1 = header.hiddenImage1;
                }

                //image2
                string wwwRootPathh = _WebHostEnvironment.WebRootPath;
                if (file2 != null)
                {
                    string fileNamee = Guid.NewGuid().ToString() + Path.GetExtension(file2.FileName);
                    string productPathh = Path.Combine(wwwRootPathh, @"images\product\");

                    if (!string.IsNullOrEmpty(header.Image2))
                    {
                        var oldimagepathh = Path.Combine(wwwRootPathh, header.Image2.TrimStart('\\'));
                        if (System.IO.File.Exists(oldimagepathh))
                        {
                            System.IO.File.Delete(oldimagepathh);
                        }
                    }

                    // change piets to file and  (( Save the photo))
                    using (var fileStreamm = new FileStream(Path.Combine(productPathh, fileNamee), FileMode.Create))  // where to have save the file
                    {
                        file2.CopyTo(fileStreamm);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    header.Image2 = @"/images/product/" + fileNamee;

                }

                if (header.Image2 == null && header.hiddenImage2 == null)
                {
                    TempData["error"] = "You Need choose Image Again";
                    return RedirectToAction("Edit");
                }

                if (header.Image2 == null && header.hiddenImage2 != null)
                {
                    header.Image2 = header.hiddenImage2;
                }

                _UnitofWork.aboutus.Update(header);
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
            AboutUs LenstypefromDb = _UnitofWork.aboutus.Get(u => u.Id == id);
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
            AboutUs obj = _UnitofWork.aboutus.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }



            _UnitofWork.aboutus.Remove(obj);
            _UnitofWork.Save();
            TempData["success"] = "  Delete successfully";
            return RedirectToAction("Index");


        }






    }
}
