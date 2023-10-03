using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class add2columinFAQtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "collapse",
                table: "FAQ",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "heading",
                table: "FAQ",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "FAQ",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "collapse", "heading" },
                values: new object[] { "collapseOne", "headingOne" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "collapse",
                table: "FAQ");

            migrationBuilder.DropColumn(
                name: "heading",
                table: "FAQ");
        }
    }
}
