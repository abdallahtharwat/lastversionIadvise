using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class addkeyservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "iconserviceId",
                table: "servicePoints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "servicePoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "iconserviceId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_servicePoints_iconserviceId",
                table: "servicePoints",
                column: "iconserviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_servicePoints_iconServices_iconserviceId",
                table: "servicePoints",
                column: "iconserviceId",
                principalTable: "iconServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_servicePoints_iconServices_iconserviceId",
                table: "servicePoints");

            migrationBuilder.DropIndex(
                name: "IX_servicePoints_iconserviceId",
                table: "servicePoints");

            migrationBuilder.DropColumn(
                name: "iconserviceId",
                table: "servicePoints");
        }
    }
}
