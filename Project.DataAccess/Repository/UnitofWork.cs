using Project.DataAccess.Repository.IRepository;
using Project.DataAccesss.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private ApplicationDbContext _db;

        public UnitofWork(ApplicationDbContext db)
        {
            _db = db;
            Feature = new FeatureRepository(_db);
            Header = new HeaderRepository(_db);
            iconservice = new iconserviceRepository(_db);
             WhyUs  = new WhyUsRepository(_db);
            Package = new PackageRepository(_db);
            serviceFeature = new ServiceFeatureRepository(_db);
            packagecontent = new PackageContentRepository(_db);
            aboutus = new AboutUsRepository(_db);
            FAQ = new FAQRepository(_db);
            servicepoint = new ServicePointRepository(_db);
            ContactUs = new ContactUsRepository(_db);
            testimonial = new testimonialRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            featureTest = new FeatureTestRepositore(db);
        }



        public IFeatureRepository Feature { get; private set; }
        public IHeaderRepository Header { get; private set; }
        public IiconserviceRepository iconservice { get; private set; }
        public IWhyUsRepository  WhyUs { get; private set; }
        public IPackageRepository   Package { get; private set; }
        public IServiceFeatureRepository   serviceFeature { get; private set; }
        public IPackageContentRepository    packagecontent { get; private set; }
        public IAboutUsRepository aboutus { get; private set; }
        public IFAQRepository FAQ { get; private set; }
        public IServicePointRepository  servicepoint { get; private set; }
        public IContactUsRepository ContactUs { get; private set; }
        public ItestimonialRepository testimonial { get; private set; }
        public IApplicationUserRepository  ApplicationUser { get; private set; }
        public IFeatureTestRepositore  featureTest { get; private set; }



        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
