using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class addaboutustable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aboutus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aboutus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "aboutus",
                columns: new[] { "Id", "Description", "Image1", "Image2", "Title1", "Title2", "Title3" },
                values: new object[] { 1, "IAdvise of the top business setup consultants in UAE for Business Setup in Dubai. If you are looking for a place to start or expand your business, Dubai might be the perfect destination for you. Dubai is one of the most dynamic and diverse cities in the world, offering a range of opportunities and benefits for entrepreneurs and investors. In this blog post, we will guide you through the steps to set up a business in Dubai, whether you choose to operate in the mainland or in a free zone.", "  ", " ", " About Us ", " The Ultimate Guide Towards Business Success in Dubai ", " Our Team will get back to you within 24 hours\r\nFrom anywhere in the world " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aboutus");
        }
    }
}
