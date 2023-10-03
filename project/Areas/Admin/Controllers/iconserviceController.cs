using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MimeKit;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;
using Project.Models.ViewModel;

namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class iconserviceController : Controller
    {

        private readonly IUnitofWork _UnitofWork;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public iconserviceController(IUnitofWork unitofWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitofWork = unitofWork;
            _WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<IconService> IconServicelist = _UnitofWork.iconservice.GetAll().ToList();
            return View(IconServicelist);
        }




        // get create
        public IActionResult Create()
        {

            return View();
        }

        // post create
        [HttpPost]
        public IActionResult Create(IconService iconService, IFormFile? file, IFormFile? file2, IFormFile? file3, IFormFile? file4, IFormFile? file5)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
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

                    if (!string.IsNullOrEmpty(iconService.Bannerimg))
                    {
                        var oldimagepath = Path.Combine(wwwRootPath, iconService.Bannerimg.TrimStart('\\'));
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

                    iconService.Bannerimg = @"/images/product/" + fileName;

                }

                //image2
                string wwwRootPathh = _WebHostEnvironment.WebRootPath;
                if (file2 != null)
                {
                    string fileNamee = Guid.NewGuid().ToString() + Path.GetExtension(file2.FileName);
                    string productPathh = Path.Combine(wwwRootPathh, @"images\product\");

                    if (!string.IsNullOrEmpty(iconService.Contentimg))
                    {
                        var oldimagepathh = Path.Combine(wwwRootPathh, iconService.Contentimg.TrimStart('\\'));
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

                    iconService.Contentimg = @"/images/product/" + fileNamee;

                }

                //image3
                string wwwRootPathhh = _WebHostEnvironment.WebRootPath;
                if (file3 != null)
                {
                    string fileNameee = Guid.NewGuid().ToString() + Path.GetExtension(file3.FileName);
                    string productPathhh = Path.Combine(wwwRootPathhh, @"images\product\");

                    if (!string.IsNullOrEmpty(iconService.sectionimg1))
                    {
                        var oldimagepathhh = Path.Combine(wwwRootPathhh, iconService.sectionimg1.TrimStart('\\'));
                        if (System.IO.File.Exists(oldimagepathhh))
                        {
                            System.IO.File.Delete(oldimagepathhh);
                        }
                    }

                    // change piets to file and  (( Save the photo))
                    using (var fileStreammm = new FileStream(Path.Combine(productPathhh, fileNameee), FileMode.Create))  // where to have save the file
                    {
                        file3.CopyTo(fileStreammm);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    iconService.sectionimg1 = @"/images/product/" + fileNameee;

                }

                //image4
                string wwwRootPathhhh = _WebHostEnvironment.WebRootPath;
                if (file4 != null)
                {
                    string fileNameeee = Guid.NewGuid().ToString() + Path.GetExtension(file4.FileName);
                    string productPathhhh = Path.Combine(wwwRootPathhhh, @"images\product\");

                    if (!string.IsNullOrEmpty(iconService.sectionimg2))
                    {
                        var oldimagepathhhh = Path.Combine(wwwRootPathhhh, iconService.sectionimg2.TrimStart('\\'));
                        if (System.IO.File.Exists(oldimagepathhhh))
                        {
                            System.IO.File.Delete(oldimagepathhhh);
                        }
                    }

                    // change piets to file and  (( Save the photo))
                    using (var fileStreammmm = new FileStream(Path.Combine(productPathhhh, fileNameeee), FileMode.Create))  // where to have save the file
                    {
                        file4.CopyTo(fileStreammmm);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    iconService.sectionimg2 = @"/images/product/" + fileNameeee;

                }

                //image5
                string wwwRootPathhhhh = _WebHostEnvironment.WebRootPath;
                if (file5 != null)
                {
                    string fileNameeeee = Guid.NewGuid().ToString() + Path.GetExtension(file5.FileName);
                    string productPathhhhh = Path.Combine(wwwRootPathhhhh, @"images\product\");

                    if (!string.IsNullOrEmpty(iconService.sectionimg3))
                    {
                        var oldimagepathhhhh = Path.Combine(wwwRootPathhhhh, iconService.sectionimg3.TrimStart('\\'));
                        if (System.IO.File.Exists(oldimagepathhhhh))
                        {
                            System.IO.File.Delete(oldimagepathhhhh);
                        }
                    }

                    // change piets to file and  (( Save the photo))
                    using (var fileStreammmmm = new FileStream(Path.Combine(productPathhhhh, fileNameeeee), FileMode.Create))  // where to have save the file
                    {
                        file5.CopyTo(fileStreammmmm);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    iconService.sectionimg3 = @"/images/product/" + fileNameeeee;

                }








                _UnitofWork.iconservice.add(iconService);
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

            IconService? IconServicefromDb = _UnitofWork.iconservice.Get(u => u.Id == id); ;
            if (IconServicefromDb == null)
            {
                return NotFound();
            }

            return View(IconServicefromDb);
        }

        // post Edit
        [HttpPost]
        public IActionResult Edit(IconService iconService, IFormFile? file, IFormFile? file2, IFormFile? file3, IFormFile? file4, IFormFile? file5)
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

                    if (!string.IsNullOrEmpty(iconService.Bannerimg))
                    {
                        var oldimagepath = Path.Combine(wwwRootPath, iconService.Bannerimg.TrimStart('\\'));
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

                    iconService.Bannerimg = @"/images/product/" + fileName;

                }


                //image2
                string wwwRootPathh = _WebHostEnvironment.WebRootPath;
                if (file2 != null)
                {
                    string fileNamee = Guid.NewGuid().ToString() + Path.GetExtension(file2.FileName);
                    string productPathh = Path.Combine(wwwRootPathh, @"images\product\");

                    if (!string.IsNullOrEmpty(iconService.Contentimg))
                    {
                        var oldimagepathh = Path.Combine(wwwRootPathh, iconService.Contentimg.TrimStart('\\'));
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

                    iconService.Contentimg = @"/images/product/" + fileNamee;

                }


                //image3
                string wwwRootPathhh = _WebHostEnvironment.WebRootPath;
                if (file3 != null)
                {
                    string fileNameee = Guid.NewGuid().ToString() + Path.GetExtension(file3.FileName);
                    string productPathhh = Path.Combine(wwwRootPathhh, @"images\product\");

                    if (!string.IsNullOrEmpty(iconService.sectionimg1))
                    {
                        var oldimagepathhh = Path.Combine(wwwRootPathhh, iconService.sectionimg1.TrimStart('\\'));
                        if (System.IO.File.Exists(oldimagepathhh))
                        {
                            System.IO.File.Delete(oldimagepathhh);
                        }
                    }

                    // change piets to file and  (( Save the photo))
                    using (var fileStreammm = new FileStream(Path.Combine(productPathhh, fileNameee), FileMode.Create))  // where to have save the file
                    {
                        file3.CopyTo(fileStreammm);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    iconService.sectionimg1 = @"/images/product/" + fileNameee;

                }



                //image4
                string wwwRootPathhhh = _WebHostEnvironment.WebRootPath;
                if (file4 != null)
                {
                    string fileNameeee = Guid.NewGuid().ToString() + Path.GetExtension(file4.FileName);
                    string productPathhhh = Path.Combine(wwwRootPathhhh, @"images\product\");

                    if (!string.IsNullOrEmpty(iconService.sectionimg2))
                    {
                        var oldimagepathhhh = Path.Combine(wwwRootPathhhh, iconService.sectionimg2.TrimStart('\\'));
                        if (System.IO.File.Exists(oldimagepathhhh))
                        {
                            System.IO.File.Delete(oldimagepathhhh);
                        }
                    }

                    // change piets to file and  (( Save the photo))
                    using (var fileStreammmm = new FileStream(Path.Combine(productPathhhh, fileNameeee), FileMode.Create))  // where to have save the file
                    {
                        file4.CopyTo(fileStreammmm);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    iconService.sectionimg2 = @"/images/product/" + fileNameeee;

                }



                //image5
                string wwwRootPathhhhh = _WebHostEnvironment.WebRootPath;
                if (file5 != null)
                {
                    string fileNameeeee = Guid.NewGuid().ToString() + Path.GetExtension(file5.FileName);
                    string productPathhhhh = Path.Combine(wwwRootPathhhhh, @"images\product\");

                    if (!string.IsNullOrEmpty(iconService.sectionimg3))
                    {
                        var oldimagepathhhhh = Path.Combine(wwwRootPathhhhh, iconService.sectionimg3.TrimStart('\\'));
                        if (System.IO.File.Exists(oldimagepathhhhh))
                        {
                            System.IO.File.Delete(oldimagepathhhhh);
                        }
                    }

                    // change piets to file and  (( Save the photo))
                    using (var fileStreammmmm = new FileStream(Path.Combine(productPathhhhh, fileNameeeee), FileMode.Create))  // where to have save the file
                    {
                        file5.CopyTo(fileStreammmmm);      // that will copy the file in the new location|| that we added  in line 76
                    }

                    iconService.sectionimg3 = @"/images/product/" + fileNameeeee;

                }


                if (iconService.sectionimg3 == null)
                {
                    TempData["error"] = "You Need choose Images Again";
                    return RedirectToAction("Edit");
                }


                _UnitofWork.iconservice.Update(iconService);
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
            IconService LenstypefromDb = _UnitofWork.iconservice.Get(u => u.Id == id);
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
            IconService obj = _UnitofWork.iconservice.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }



            _UnitofWork.iconservice.Remove(obj);
            _UnitofWork.Save();
            TempData["success"] = "  Delete successfully";
            return RedirectToAction("Index");


        }













    }
}
