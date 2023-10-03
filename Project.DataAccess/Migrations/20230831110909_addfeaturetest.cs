using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class addfeaturetest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "featuretests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_featuretests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "featuretests",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "we use after-sales support as a business strategy as it typically leads to higher customer satisfaction and even word-of-mouth-marketing After-sales service is any support provided to a customer after the service has already been purchased..", " Awesome Display" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "featuretests");
        }
    }
}
