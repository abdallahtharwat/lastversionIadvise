using Microsoft.AspNetCore.Mvc;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;
using System.Security.Claims;

namespace project.ViewComponents
{
    public class ServiceViewComponent : ViewComponent
    {

        private readonly IUnitofWork _UnitofWork;
        public ServiceViewComponent(IUnitofWork UnitofWork)
        {

            _UnitofWork = UnitofWork;
        }

        public  IViewComponentResult Invoke()
        {

            IEnumerable<IconService> IconServicelist = _UnitofWork.iconservice.GetAll().ToList().OrderBy(u => u.HomePageTitle);
            return View(IconServicelist);

          
        }





    }
}
