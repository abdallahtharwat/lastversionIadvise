using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository.IRepository
{
    public interface IFeatureRepository : IRepository<Feature>
    {
        void Update(Feature obj);

        public Task<bool> DuplicatefeatureAsync(int id);


        public Task<bool> DeletefeatureAsync(int id);

    }
}
