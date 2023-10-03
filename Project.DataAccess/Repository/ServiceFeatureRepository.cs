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
    public class ServiceFeatureRepository : Repository<servicefeature>, IServiceFeatureRepository
    {
        private ApplicationDbContext _db;
        public ServiceFeatureRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(servicefeature obj)
        {
            _db.servicefeatures.Update(obj);
        }
    }
}
