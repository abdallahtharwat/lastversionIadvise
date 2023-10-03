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
    public class ServicePointRepository : Repository<ServicePointFeatures>, IServicePointRepository
    {
        private ApplicationDbContext _db;
        public ServicePointRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ServicePointFeatures obj)
        {
            _db.servicePoints.Update(obj);
        }
    }
}
