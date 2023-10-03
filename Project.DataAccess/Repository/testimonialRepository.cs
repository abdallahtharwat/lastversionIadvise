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
    public class testimonialRepository : Repository<testimonial>, ItestimonialRepository
    {
        private ApplicationDbContext _db;
        public testimonialRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(testimonial obj)
        {
            _db.testimonials.Update(obj);
        }
    }
}
