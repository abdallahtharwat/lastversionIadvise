using Project.DataAccess.Repository.IRepository;
using Project.DataAccesss.Data;
using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository
{
    public class AboutUsRepository : Repository<AboutUs>, IAboutUsRepository
    {
        private ApplicationDbContext _db;
        public AboutUsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(AboutUs obj)
        {
            _db.aboutus.Update(obj);
        }
    }
}
