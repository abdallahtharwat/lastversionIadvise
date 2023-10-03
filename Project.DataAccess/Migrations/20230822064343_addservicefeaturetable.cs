using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class addservicefeaturetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "servicefeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicefeatures", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "servicefeatures",
                columns: new[] { "Id", "Description", "Icon", "Title" },
                values: new object[] { 1, "We advise our clients on the most suitable business activity that aligns with their plans and needs, helping them to achieve their goals more effectively.", "    <i class='bx bxs-doughnut-chart'></i>", " Expertise:" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "servicefeatures");
        }
    }
}
