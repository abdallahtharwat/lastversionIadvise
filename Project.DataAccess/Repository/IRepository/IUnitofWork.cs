using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository.IRepository
{
    public interface IUnitofWork
    {
        IFeatureRepository Feature { get; }
        IHeaderRepository Header { get; }
        IiconserviceRepository  iconservice { get; }

        IWhyUsRepository WhyUs { get; }
        IPackageRepository  Package { get; }
        IServiceFeatureRepository   serviceFeature { get; }
        IPackageContentRepository    packagecontent { get; }
        IAboutUsRepository    aboutus { get; }
        IFAQRepository    FAQ { get; }
        IServicePointRepository  servicepoint { get; }
        IContactUsRepository  ContactUs { get; }
        ItestimonialRepository  testimonial { get; }
        IApplicationUserRepository  ApplicationUser { get; }
        IFeatureTestRepositore   featureTest { get; }

        void Save();
    }
}
