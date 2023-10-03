using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class addketbetweenpackagecontentandpackagetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "packagetId",
                table: "packageContents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "packageContents",
                keyColumn: "Id",
                keyValue: 1,
                column: "packagetId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_packageContents_packagetId",
                table: "packageContents",
                column: "packagetId");

            migrationBuilder.AddForeignKey(
                name: "FK_packageContents_packages_packagetId",
                table: "packageContents",
                column: "packagetId",
                principalTable: "packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_packageContents_packages_packagetId",
                table: "packageContents");

            migrationBuilder.DropIndex(
                name: "IX_packageContents_packagetId",
                table: "packageContents");

            migrationBuilder.DropColumn(
                name: "packagetId",
                table: "packageContents");
        }
    }
}
