﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DataAccesss.Data;

#nullable disable

namespace Project.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230827121123_addtestimo")]
    partial class addtestimo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project.Models.Models.AboutUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("aboutus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "IAdvise of the top business setup consultants in UAE for Business Setup in Dubai. If you are looking for a place to start or expand your business, Dubai might be the perfect destination for you. Dubai is one of the most dynamic and diverse cities in the world, offering a range of opportunities and benefits for entrepreneurs and investors. In this blog post, we will guide you through the steps to set up a business in Dubai, whether you choose to operate in the mainland or in a free zone.",
                            Image1 = "  ",
                            Image2 = " ",
                            Title1 = " About Us ",
                            Title2 = " The Ultimate Guide Towards Business Success in Dubai ",
                            Title3 = " Our Team will get back to you within 24 hours\r\nFrom anywhere in the world "
                        });
                });

            modelBuilder.Entity("Project.Models.Models.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerTile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormTitle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("contactus");
                });

            modelBuilder.Entity("Project.Models.Models.FAQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("collapse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("heading")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FAQ");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "What service do you offer",
                            Question = "We offer a wide range of services, including company registration, guaranteed business banking account, obtaining necessary licenses, residence visas and permits, legal documentation, corporate structuring, business planning, and ongoing support for compliance and administrative tasks.",
                            collapse = "collapseOne",
                            heading = "headingOne"
                        });
                });

            modelBuilder.Entity("Project.Models.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                            Title = " Responsive"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                            Title = "Retina Ready"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                            Title = "Awesome Display"
                        });
                });

            modelBuilder.Entity("Project.Models.Models.Header", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("headers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eaque quia sequi eius. Quas, totam aliquid. Repudiandae reiciendis vel excepturi ipsa voluptate dicta!",
                            ImageUrl = " ",
                            Title = " Launch  your business"
                        });
                });

            modelBuilder.Entity("Project.Models.Models.IconService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BannerTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bannerimg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentDescriptionfooter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contentimg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePageIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionDescription1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionDescription2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionDescription3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionTitle1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionTitle3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionimg1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionimg2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionimg3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("iconServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BannerTitle = "Our Services",
                            Bannerimg = " ",
                            ContentDescription = "Are you looking to start your own business but not sure where to begin? We’re here to help! We’re offering a complimentary business setup consultation to assist you in laying the foundation for your entrepreneurial journey ",
                            ContentDescriptionfooter = "Let us handle the paperwork and regulatory maze while you focus on growing your business. Contact us today to ensure your company operates with all the necessary licenses and permits! ",
                            ContentQuestion = "Why iAdvise for your company registration? ",
                            ContentTitle = "Free Consultancy: ",
                            Contentimg = " ",
                            HomePageDescription = "Guide you through the essential steps for setting up a successful business andDiscuss legal and financial considerations tailored to your specific needs.",
                            HomePageIcon = "  <i class='bx bxs-check-shield'></i>  ",
                            HomePageTitle = "	Free Consultancy",
                            MainDescription = "Lay the foundation for your entrepreneurial journey. ",
                            MainTitle = "Free Consultancy ",
                            sectionDescription = "Get the Expert Advice You Need to Start Your Business. ",
                            sectionDescription1 = "Guide you through the essential steps for setting up a successful business. ",
                            sectionDescription2 = "Offer strategies to help you grow and thrive in your chosen industry and Analyze your business idea and provide valuable insights. ",
                            sectionDescription3 = "Provide guidance and assistance with bank account opening. ",
                            sectionTitle = "Free Consultancy ",
                            sectionTitle1 = "Free Consultancy ",
                            sectionTitle2 = "Free Consultancy ",
                            sectionTitle3 = "Free Consultancy ",
                            sectionimg1 = " ",
                            sectionimg2 = " ",
                            sectionimg3 = " "
                        });
                });

            modelBuilder.Entity("Project.Models.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleHTML")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("packages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = " Launch ",
                            Description = "The essentials for starting your business. ",
                            Title = " Premium Package ",
                            TitleHTML = " Premium Package "
                        });
                });

            modelBuilder.Entity("Project.Models.Models.PackageContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("packagetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("packagetId");

                    b.ToTable("packageContents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "    <i class='bx bxs-doughnut-chart'></i>",
                            Title = " Expertise:",
                            packagetId = 1
                        });
                });

            modelBuilder.Entity("Project.Models.Models.servicefeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("servicefeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "We advise our clients on the most suitable business activity that aligns with their plans and needs, helping them to achieve their goals more effectively.",
                            Icon = "    <i class='bx bxs-doughnut-chart'></i>",
                            Title = " Expertise:"
                        });
                });

            modelBuilder.Entity("Project.Models.Models.ServicePointFeatures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("iconserviceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("iconserviceId");

                    b.ToTable("servicePoints");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Guide you through the essential steps for setting up a successful business.",
                            Icon = " <i class='bx bx-atom'></i> ",
                            Title = " Expertise:",
                            iconserviceId = 1
                        });
                });

            modelBuilder.Entity("Project.Models.Models.testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("testimonials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Feedback = "It has been a pleasure working with I Advise I appreciate your dedication to the projects that you and your team are on It's nice to be able to contact you at any time",
                            MainTitle = "What Our Clients Say",
                            Name = " Olivia Benjamin",
                            img = " "
                        });
                });

            modelBuilder.Entity("Project.Models.Models.WhyUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("whyus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description1 = "Your Trusted Partner for Setting Up Your Company in the United Arab Emirates! Choosing the right partner for company setup is crucial, and we offer compelling reasons why you should go for iAdvise",
                            ImageUrl = " ",
                            TextArea = " Launch ",
                            Title1 = " Why To Choose Us? ",
                            Title2 = " Best solution for your business "
                        });
                });

            modelBuilder.Entity("Project.Models.Models.PackageContent", b =>
                {
                    b.HasOne("Project.Models.Models.Package", "package")
                        .WithMany()
                        .HasForeignKey("packagetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("package");
                });

            modelBuilder.Entity("Project.Models.Models.ServicePointFeatures", b =>
                {
                    b.HasOne("Project.Models.Models.IconService", "IconService")
                        .WithMany("ServicePointFeatures")
                        .HasForeignKey("iconserviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IconService");
                });

            modelBuilder.Entity("Project.Models.Models.IconService", b =>
                {
                    b.Navigation("ServicePointFeatures");
                });
#pragma warning restore 612, 618
        }
    }
}
