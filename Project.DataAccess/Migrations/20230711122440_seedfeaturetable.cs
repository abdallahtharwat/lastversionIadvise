using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class seedfeaturetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "features",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.", " Responsive" });

            migrationBuilder.InsertData(
                table: "features",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.", "Retina Ready" });

            migrationBuilder.InsertData(
                table: "features",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.", "Awesome Display" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "features",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
