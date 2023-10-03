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
    public class PackageContentRepository : Repository<PackageContent>, IPackageContentRepository
    {
        private ApplicationDbContext _db;
        public PackageContentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PackageContent obj)
        {
            _db.packageContents.Update(obj);
        }
    }
}
