using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository.IRepository
{
    public interface IServiceFeatureRepository : IRepository<servicefeature>
    {
        void Update(servicefeature obj);

    }

}
