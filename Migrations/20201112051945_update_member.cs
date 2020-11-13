using Microsoft.EntityFrameworkCore.Migrations;

namespace coreApi.Migrations
{
    public partial class update_member : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "members",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "members",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "members",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "members",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "members",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "members",
                newName: "Body");
        }
    }
}
