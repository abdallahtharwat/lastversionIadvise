using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository.IRepository
{
    public interface IPackageRepository : IRepository<Package>
    {
        void Update(Package obj);

    }
}
