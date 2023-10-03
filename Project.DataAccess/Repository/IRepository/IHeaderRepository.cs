using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository.IRepository
{
    public interface IHeaderRepository : IRepository<Header>
    {
        void Update(Header obj);

    }
}
