using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccess.Migrations
{
    public partial class removekey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_whyus_servicefeatures_servicefeatureId",
                table: "whyus");

            migrationBuilder.DropIndex(
                name: "IX_whyus_servicefeatureId",
                table: "whyus");

            migrationBuilder.DropColumn(
                name: "servicefeatureId",
                table: "whyus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "servicefeatureId",
                table: "whyus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "whyus",
                keyColumn: "Id",
                keyValue: 1,
                column: "servicefeatureId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_whyus_servicefeatureId",
                table: "whyus",
                column: "servicefeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_whyus_servicefeatures_servicefeatureId",
                table: "whyus",
                column: "servicefeatureId",
                principalTable: "servicefeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
