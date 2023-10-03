using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository.IRepository
{
    public interface IFeatureTestRepositore
    {



        public Task<bool> AddAboutUsAsync(Featuretest AboutUs);
        public Task<bool> DeleteAboutUsAsync(int id);
        public Task<bool> DuplicateAboutUsAsync(int id);
        public Task<Featuretest?> GetAboutUsAsync(int id);
        public Task<IEnumerable<Featuretest>> GetAllAboutUsAsync();
        public Task<IEnumerable<Featuretest>> GetAll(Expression<Func<Featuretest, bool>>? filter = null, string? includeproperties = null);

        public Task<bool> UpdateAboutUsAsync(Featuretest AboutUs);
        public Task<bool> AboutUsAnyAsync(int id);





    }
}
