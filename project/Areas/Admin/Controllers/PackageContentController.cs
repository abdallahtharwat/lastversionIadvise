using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;
using Project.Models.ViewModel;



namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PackageContentController : Controller
    {

        private readonly IUnitofWork _UnitofWork;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public PackageContentController(IUnitofWork unitofWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitofWork = unitofWork;
            _WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {

            List<PackageContent> IconServicelist = _UnitofWork.packagecontent.GetAll(includeproperties: "package").ToList();

            return View(IconServicelist);
        }


        // get create
        public IActionResult Create()
        {


            //var package =new System.Web.Mvc.SelectList(_UnitofWork.Package.GetAll(), "Id", "Title") ;

            //PackageContentVM packageContentVM = new()
            //{
            //    PackageList = package,

            //    packageContent = new PackageContent()

            //};

            PackageContentVM packagecontentVM = new()
            {
                PackageList = _UnitofWork.Package.GetAll().Select(u => new SelectListItem  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
                {
                    Text = u.Title,
                    Value = u.Id.ToString(),


                }),




                packageContent = new PackageContent()
            };



            return View(packagecontentVM);
        }

        // post create
        [HttpPost]
        public IActionResult Create(PackageContentVM packageContentVM)  //  (obj== anta btstlm el value el fe post method input fe el create view )  when we have the obj here that will have the value of category that needs to be add
        {


            //Validation for sliver side
            if (ModelState.IsValid)
            {
                _UnitofWork.packagecontent.add(packageContentVM.packageContent);
                _UnitofWork.Save();
                TempData["success"] = "  Create successfully";
                return RedirectToAction("Index");
            }
            else
            {
                packageContentVM.PackageList = _UnitofWork.Package.GetAll().Select(u => new SelectListItem

                {
                    Text = u.Title,
                    Value = u.Id.ToString(),
                });
                return View(packageContentVM);
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


            var e = _UnitofWork.packagecontent.Get(u => u.Id == id);

            var packagecontent = new PackageContent   // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
            {
                Title = e.Title,
                Icon = e.Icon,
                Id = e.Id,
                packagetId = e.packagetId
            };


            PackageContentVM packagecontentVM = new()
            {
                PackageList = _UnitofWork.Package.GetAll().Select(u => new SelectListItem  // (step 3 for forienkey category)  انت بتحيبها من قاعد البيانات و بتبعتها لل فيو    
                {
                    Text = u.Title,
                    Value = u.Id.ToString(),
                    Selected = u.Id == e.packagetId,

                }),

                packageContent = packagecontent,

            };

            //PackageContent? IconServicefromDb = _UnitofWork.packagecontent.Get(u => u.Id == id); ;


            if (packagecontentVM == null)
            {
                return NotFound();
            }

            return View(packagecontentVM);
        }

        // post Edit
        [HttpPost]
        public IActionResult Edit(PackageContentVM packageContentVM)
        {

            //Validation for sliver side
            if (ModelState.IsValid)
            {

                _UnitofWork.packagecontent.Update(packageContentVM.packageContent);
                _UnitofWork.Save();
                TempData["success"] = "  Update successfully";
                return RedirectToAction("Index");
            }
            //else
            //{
            //    packageContentVM.PackageList = _UnitofWork.Package.GetAll().Select(u => new SelectListItem

            //    {
            //        Text = u.Title,
            //        Value = u.Id.ToString(),
            //    });
            //    return View(packageContentVM);
            //}
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
            PackageContent LenstypefromDb = _UnitofWork.packagecontent.Get(u => u.Id == id);
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
            PackageContent obj = _UnitofWork.packagecontent.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }



            _UnitofWork.packagecontent.Remove(obj);
            _UnitofWork.Save();
            TempData["success"] = "  Delete successfully";
            return RedirectToAction("Index");


        }













    }
}
