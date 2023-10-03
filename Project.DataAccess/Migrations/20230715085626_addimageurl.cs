using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class addimageurl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "headers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_headers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "headers",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eaque quia sequi eius. Quas, totam aliquid. Repudiandae reiciendis vel excepturi ipsa voluptate dicta!", " ", " Launch  your business" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "headers");
        }
    }
}
