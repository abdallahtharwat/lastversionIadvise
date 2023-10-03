using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class addwhyustable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "whyus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_whyus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "whyus",
                columns: new[] { "Id", "Description1", "ImageUrl", "TextArea", "Title1", "Title2" },
                values: new object[] { 1, "Your Trusted Partner for Setting Up Your Company in the United Arab Emirates! Choosing the right partner for company setup is crucial, and we offer compelling reasons why you should go for iAdvise", " ", " Launch ", " Why To Choose Us? ", " Best solution for your business " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "whyus");
        }
    }
}
