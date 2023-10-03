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
    public class HeaderRepository : Repository<Header>, IHeaderRepository
    {
        private ApplicationDbContext _db;
        public HeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Header obj)
        {
            _db.headers.Update(obj);
        }
    }
}
