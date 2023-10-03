using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class addfaqtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FAQ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQ", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FAQ",
                columns: new[] { "Id", "Answer", "Question", "Title" },
                values: new object[] { 1, "What service do you offer", "We offer a wide range of services, including company registration, guaranteed business banking account, obtaining necessary licenses, residence visas and permits, legal documentation, corporate structuring, business planning, and ongoing support for compliance and administrative tasks.", "Our Team will get back to you within 24 hours\r\nFrom anywhere in the world" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQ");
        }
    }
}
