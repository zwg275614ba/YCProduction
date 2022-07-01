using Microsoft.EntityFrameworkCore.Migrations;

namespace YCProduction.IRepository.Migrations
{
    public partial class createdepartmentfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Base_Department",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Base_Department");
        }
    }
}
