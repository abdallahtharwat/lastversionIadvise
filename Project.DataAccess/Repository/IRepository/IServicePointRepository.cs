using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository.IRepository
{
    public interface IServicePointRepository : IRepository<ServicePointFeatures>
    {
        void Update(ServicePointFeatures obj);

    }
}
