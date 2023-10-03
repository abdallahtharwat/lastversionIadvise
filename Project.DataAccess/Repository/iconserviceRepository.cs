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
    public class iconserviceRepository : Repository<IconService>, IiconserviceRepository
    {
        private ApplicationDbContext _db;
        public iconserviceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(IconService obj)
        {
            _db.iconServices.Update(obj);
        }
    }
}
