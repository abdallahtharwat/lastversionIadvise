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
    public class FAQRepository : Repository<FAQ>, IFAQRepository
    {
        private ApplicationDbContext _db;
        public FAQRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(FAQ obj)
        {
            _db.FAQ.Update(obj);
        }
    }
}
