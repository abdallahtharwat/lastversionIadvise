using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto;
using Project.DataAccess.Repository.IRepository;
using Project.DataAccesss.Data;
using Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Project.DataAccess.Repository
{
    public class FeatureTestRepositore : IFeatureTestRepositore
    {

        private readonly ApplicationDbContext _context;
   

        public FeatureTestRepositore(ApplicationDbContext context)
        {
            _context = context;
            
        }


        public async Task<bool> AddAboutUsAsync(Featuretest AboutUs)
        {

            try
            {
                 _context.featuretests.Add(AboutUs);
                 await _context.SaveChangesAsync();
                 return true;
            }
            catch (Exception)
            {
                return false;

            }

        }

        public async Task<bool> UpdateAboutUsAsync(Featuretest AboutUs)
        {

            try
            {
                 _context.featuretests.Update(AboutUs);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                
            }

            return false;
        }

        public async Task<bool> DeleteAboutUsAsync(int id)
        {
            try
            {
                var featuretest = await _context.featuretests.Where(e => e.Id == id).FirstOrDefaultAsync();
                if (featuretest != null)
                {
                    _context.featuretests.Remove(featuretest);
                    await _context.SaveChangesAsync();
                    return true;

                }

            }
            catch (Exception)
            {

                
            }
            return false;
        }

        public async Task<bool> DuplicateAboutUsAsync(int id)
        {
            try
            {
                var featuretest = await _context.featuretests.FirstOrDefaultAsync(e => e.Id == id);
                if(featuretest != null)
                {
                    var item2 = new Featuretest
                    {
                      
                        Title = featuretest.Title,
                        Description = featuretest.Description
                    };

                    await _context.AddAsync(item2);
                    await _context.SaveChangesAsync();
                    return true;

                }



            }
            catch (Exception)
            {

               
            }

            return false;
        }






        public async Task<Featuretest?> GetAboutUsAsync(int id)
        {
            return await _context.featuretests.Where(e => e.Id == id ).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Featuretest>> GetAllAboutUsAsync()
        {
            return await _context.featuretests.ToListAsync();
        }



        public async Task<bool> AboutUsAnyAsync(int id)
        {
            return await _context.featuretests.Where(e => e.Id ==id).AnyAsync();
        }

        public async Task<IEnumerable<Featuretest>> GetAll(Expression<Func<Featuretest, bool>>? filter = null, string? includeproperties = null)
        {
            IQueryable<Featuretest> query = _context.featuretests;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(includeproperties))
            {
                foreach (var includeprop in includeproperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeprop);
                }
            }

            return await query.ToListAsync();
        }
    }
}
