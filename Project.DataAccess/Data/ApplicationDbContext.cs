using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Models.Models;

namespace Project.DataAccesss.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

        public DbSet<Feature> features { get; set; }
        public DbSet<Header>  headers { get; set; }
        public DbSet<IconService>   iconServices { get; set; }
        public DbSet<WhyUs>    whyus { get; set; }
        public DbSet<Package>    packages { get; set; }
        public DbSet<servicefeature>  servicefeatures { get; set; }
        public DbSet<PackageContent>  packageContents { get; set; }
        public DbSet<AboutUs>   aboutus { get; set; }
        public DbSet<FAQ>   FAQ { get; set; }
        public DbSet<ServicePointFeatures>   servicePoints { get; set; }
        public DbSet<ContactUs>   contactus { get; set; }
        public DbSet<testimonial>   testimonials { get; set; }
        public DbSet<ApplicationUser>    applicationUsers { get; set; }
        public DbSet<Featuretest>     featuretests { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

              base.OnModelCreating(modelBuilder);

                    modelBuilder.Entity<Feature>().HasData(
                new Feature { Id = 1, Title = " Responsive", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s." },
                new Feature { Id = 2, Title = "Retina Ready", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s." },
                new Feature { Id = 3, Title = "Awesome Display", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s." }
                );

            
                    modelBuilder.Entity<Featuretest>().HasData(
                new Featuretest { Id = 1, Title = " Awesome Display", Description = "we use after-sales support as a business strategy as it typically leads to higher customer satisfaction and even word-of-mouth-marketing After-sales service is any support provided to a customer after the service has already been purchased.." }
                );

                       modelBuilder.Entity<Header>().HasData(
                new Header { Id = 1, Title = " Launch  your business", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eaque quia sequi eius. Quas, totam aliquid. Repudiandae reiciendis vel excepturi ipsa voluptate dicta!" , ImageUrl = " "}
 
                );
                                   modelBuilder.Entity<testimonial>().HasData(
                new testimonial { Id = 1, Name = " Olivia Benjamin", Feedback = "It has been a pleasure working with I Advise I appreciate your dedication to the projects that you and your team are on It's nice to be able to contact you at any time", img = " "}
 
                );

                                   modelBuilder.Entity<WhyUs>().HasData(
                new WhyUs { Id = 1, Title1 = " Why To Choose Us? ", Title2 = " Best solution for your business ", Description1 = "Your Trusted Partner for Setting Up Your Company in the United Arab Emirates! Choosing the right partner for company setup is crucial, and we offer compelling reasons why you should go for iAdvise", TextArea = " Launch ", ImageUrl = " ", }
 
                );
                                               modelBuilder.Entity<FAQ>().HasData(
                new FAQ { Id = 1,  Answer = "What service do you offer", Question = "We offer a wide range of services, including company registration, guaranteed business banking account, obtaining necessary licenses, residence visas and permits, legal documentation, corporate structuring, business planning, and ongoing support for compliance and administrative tasks.", heading = "headingOne", collapse = "collapseOne" }
 
                );
                                               modelBuilder.Entity<AboutUs>().HasData(
                new AboutUs { Id = 1, Title1 = " About Us ", Title2 = " The Ultimate Guide Towards Business Success in Dubai ", Title3 = " Our Team will get back to you within 24 hours\r\nFrom anywhere in the world ", Description = "IAdvise of the top business setup consultants in UAE for Business Setup in Dubai. If you are looking for a place to start or expand your business, Dubai might be the perfect destination for you. Dubai is one of the most dynamic and diverse cities in the world, offering a range of opportunities and benefits for entrepreneurs and investors. In this blog post, we will guide you through the steps to set up a business in Dubai, whether you choose to operate in the mainland or in a free zone.", Image1 = "  ", Image2 = " ", }
 
                );
                                               modelBuilder.Entity<Package>().HasData(
                new Package { Id = 1, Title = " Premium Package ",  TitleHTML = " Premium Package ", Description = "The essentials for starting your business. ", Content = " Launch "}
 
                );

                                               modelBuilder.Entity<ServicePointFeatures>().HasData(
                new ServicePointFeatures { Id = 1, Title = " Expertise:", Description = "Guide you through the essential steps for setting up a successful business.", Icon = " <i class='bx bx-atom'></i> ",iconserviceId = 1 }
 
                );
                                               modelBuilder.Entity<servicefeature>().HasData(
                new servicefeature { Id = 1, Title = " Expertise:", Description = "We advise our clients on the most suitable business activity that aligns with their plans and needs, helping them to achieve their goals more effectively.", Icon = "    <i class='bx bxs-doughnut-chart'></i>" }
 
                );
                                                           modelBuilder.Entity<PackageContent>().HasData(
                new PackageContent { Id = 1, Title = " Expertise:",  Icon = "    <i class='bx bxs-doughnut-chart'></i>", packagetId = 1, }
 
                );

                   modelBuilder.Entity<IconService>().HasData(
            new IconService
            {
                Id = 1,
                HomePageTitle = "\tFree Consultancy",
                HomePageDescription = "Guide you through the essential steps for setting up a successful business andDiscuss legal and financial considerations tailored to your specific needs.",
                HomePageIcon = "  <i class='bx bxs-check-shield'></i>  ",

                BannerTitle = "Our Services",
                Bannerimg = " ",

                MainTitle = "Free Consultancy ",
                MainDescription = "Lay the foundation for your entrepreneurial journey. ",

                ContentTitle = "Free Consultancy: ",
                ContentDescription = "Are you looking to start your own business but not sure where to begin? We’re here to help! We’re offering a complimentary business setup consultation to assist you in laying the foundation for your entrepreneurial journey ",
                ContentQuestion = "Why iAdvise for your company registration? ",
                Contentimg = " ",
                ContentDescriptionfooter = "Let us handle the paperwork and regulatory maze while you focus on growing your business. Contact us today to ensure your company operates with all the necessary licenses and permits! ",

                sectionTitle = "Free Consultancy ",
                sectionDescription = "Get the Expert Advice You Need to Start Your Business. ",

                sectionTitle1 = "Free Consultancy ",
                sectionDescription1 = "Guide you through the essential steps for setting up a successful business. ",
                sectionimg1 = " ",

                sectionTitle2 = "Free Consultancy ",
                sectionDescription2 = "Offer strategies to help you grow and thrive in your chosen industry and Analyze your business idea and provide valuable insights. ",
                sectionimg2 = " ",

                sectionTitle3 = "Free Consultancy ",
                sectionDescription3 = "Provide guidance and assistance with bank account opening. ",
                sectionimg3 = " ",




            }

          );






        }





     }
}
