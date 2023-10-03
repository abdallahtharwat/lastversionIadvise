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
    public class WhyUsRepository : Repository<WhyUs>, IWhyUsRepository
    {
        private ApplicationDbContext _db;
        public WhyUsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(WhyUs obj)
        {
            _db.whyus.Update(obj);
        }
    }
}
