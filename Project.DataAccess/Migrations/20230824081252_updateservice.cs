using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class updateservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "iconServices",
                newName: "sectionimg3");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "iconServices",
                newName: "sectionimg2");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "iconServices",
                newName: "sectionimg1");

            migrationBuilder.AddColumn<string>(
                name: "BannerTitle",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bannerimg",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentDescription",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentDescriptionfooter",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentQuestion",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentTitle",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Contentimg",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HomePageDescription",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HomePageIcon",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HomePageTitle",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainDescription",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainTitle",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sectionDescription",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sectionDescription1",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sectionDescription2",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sectionDescription3",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sectionTitle",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sectionTitle1",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sectionTitle2",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sectionTitle3",
                table: "iconServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "iconServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BannerTitle", "Bannerimg", "ContentDescription", "ContentDescriptionfooter", "ContentQuestion", "ContentTitle", "Contentimg", "HomePageDescription", "HomePageIcon", "HomePageTitle", "MainDescription", "MainTitle", "sectionDescription", "sectionDescription1", "sectionDescription2", "sectionDescription3", "sectionTitle", "sectionTitle1", "sectionTitle2", "sectionTitle3", "sectionimg1", "sectionimg2", "sectionimg3" },
                values: new object[] { "Our Services", " ", "Are you looking to start your own business but not sure where to begin? We’re here to help! We’re offering a complimentary business setup consultation to assist you in laying the foundation for your entrepreneurial journey ", "Let us handle the paperwork and regulatory maze while you focus on growing your business. Contact us today to ensure your company operates with all the necessary licenses and permits! ", "Why iAdvise for your company registration? ", "Free Consultancy: ", " ", "Guide you through the essential steps for setting up a successful business andDiscuss legal and financial considerations tailored to your specific needs.", "  <i class='bx bxs-check-shield'></i>  ", "	Free Consultancy", "Lay the foundation for your entrepreneurial journey. ", "Free Consultancy ", "Get the Expert Advice You Need to Start Your Business. ", "Guide you through the essential steps for setting up a successful business. ", "Offer strategies to help you grow and thrive in your chosen industry and Analyze your business idea and provide valuable insights. ", "Provide guidance and assistance with bank account opening. ", "Free Consultancy ", "Free Consultancy ", "Free Consultancy ", "Free Consultancy ", " ", " ", " " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerTitle",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "Bannerimg",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "ContentDescription",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "ContentDescriptionfooter",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "ContentQuestion",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "ContentTitle",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "Contentimg",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "HomePageDescription",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "HomePageIcon",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "HomePageTitle",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "MainDescription",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "sectionDescription",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "sectionDescription1",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "sectionDescription2",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "sectionDescription3",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "sectionTitle",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "sectionTitle1",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "sectionTitle2",
                table: "iconServices");

            migrationBuilder.DropColumn(
                name: "sectionTitle3",
                table: "iconServices");

            migrationBuilder.RenameColumn(
                name: "sectionimg3",
                table: "iconServices",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "sectionimg2",
                table: "iconServices",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "sectionimg1",
                table: "iconServices",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "iconServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Icon", "Title" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eaque quia sequi eius. Quas, totam aliquid. Repudiandae reiciendis vel excepturi ipsa voluptate dicta!", " <i class='bx bxs-check-shield'></i>", " Service" });
        }
    }
}
