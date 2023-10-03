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
    public class PackageRepository : Repository<Package>, IPackageRepository
    {
        private ApplicationDbContext _db;
        public PackageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Package obj)
        {
            _db.packages.Update(obj);
        }
    }
}
