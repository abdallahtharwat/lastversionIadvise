using Microsoft.EntityFrameworkCore;
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
    public class FeatureRepository : Repository<Feature>, IFeatureRepository
    {
        private ApplicationDbContext _db;
        public FeatureRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Feature obj)
        {
            _db.features.Update(obj);
        }


        public async Task<bool> DuplicatefeatureAsync(int id)
        {
            try
            {

                var feature = await _db.features.FirstOrDefaultAsync(m => m.Id == id);
                if (feature != null)
                {
                    var item = new Feature
                    {
                        Title = feature.Title,
                        Description = feature.Description,
                    };

                    await _db.AddAsync(item);
                    await _db.SaveChangesAsync();

                    return true;
                }


            }
            catch (Exception ex)
            {
            }
            return false;

        }



        public async Task<bool> DeletefeatureAsync(int id)
        {
            try
            {
                var feature = await _db.features.FirstOrDefaultAsync(m => m.Id == id);
                if (feature != null)
                {
                    _db.features.Remove(feature);
                    await _db.SaveChangesAsync();
                    return true;
                }

            }
            catch (Exception ex)
            {
            }
            return false;

        }





    }
}
