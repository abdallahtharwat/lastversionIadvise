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
    public class ContactUsRepository : Repository<ContactUs>, IContactUsRepository
    {
        private ApplicationDbContext _db;
        public ContactUsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ContactUs obj)
        {
            _db.contactus.Update(obj);
        }
    }
}
