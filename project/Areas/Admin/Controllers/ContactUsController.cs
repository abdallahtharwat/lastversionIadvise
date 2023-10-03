using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;

namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {

        private readonly IUnitofWork _UnitofWork;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ContactUsController(IUnitofWork unitofWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitofWork = unitofWork;
            _WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<ContactUs> featurelist = _UnitofWork.ContactUs.GetAll().ToList();
            return View(featurelist);
        }


        // get create
        public IActionResult Create()
        {

            return View();
        }

        // post create
        [HttpPost]
        public IActionResult Create(ContactUs header, IFormFile? file)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
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
                    if (!string.IsNullOrEmpty(header.BannerImg))
                    {
                        var oldimagepath = Path.Combine(wwwRootPath, header.BannerImg.TrimStart('\\'));
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

                    header.BannerImg = @"\images\product\" + fileName;
                }


                _UnitofWork.ContactUs.add(header);
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

            ContactUs? lenstypefromDb = _UnitofWork.ContactUs.Get(u => u.Id == id); ;
            if (lenstypefromDb == null)
            {
                return NotFound();
            }

            lenstypefromDb.hiddenBannerImg = lenstypefromDb.BannerImg;


            return View(lenstypefromDb);
        }

        // post Edit
        [HttpPost]
        public IActionResult Edit(ContactUs header, IFormFile? file)
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
                    if (!string.IsNullOrEmpty(header.BannerImg))
                    {
                        var oldimagepath = Path.Combine(wwwRootPath, header.BannerImg.TrimStart('\\'));
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

                    header.BannerImg = @"\images\product\" + fileName;



                }

                if (header.BannerImg == null && header.hiddenBannerImg == null)
                {
                    TempData["error"] = "You Need choose Image Again";
                    return RedirectToAction("Edit");
                }

                if (header.BannerImg == null && header.hiddenBannerImg != null)
                {
                    header.BannerImg = header.hiddenBannerImg;
                }

                _UnitofWork.ContactUs.Update(header);
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
            ContactUs LenstypefromDb = _UnitofWork.ContactUs.Get(u => u.Id == id);
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
            ContactUs obj = _UnitofWork.ContactUs.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }



            _UnitofWork.ContactUs.Remove(obj);
            _UnitofWork.Save();
            TempData["success"] = "  Delete successfully";
            return RedirectToAction("Index");


        }













    }
}
