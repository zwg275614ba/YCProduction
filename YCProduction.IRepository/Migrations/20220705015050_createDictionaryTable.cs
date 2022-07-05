using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace YCProduction.IRepository.Migrations
{
    public partial class createDictionaryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dic_IndustryCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IndustryCategoryId = table.Column<string>(maxLength: 50, nullable: true),
                    IndustryCategory = table.Column<string>(maxLength: 100, nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dic_IndustryCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dic_ProjectCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProjectCategoryId = table.Column<string>(maxLength: 100, nullable: true),
                    IndustryCategoryId = table.Column<string>(maxLength: 100, nullable: true),
                    ProjectCategory = table.Column<string>(maxLength: 100, nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dic_ProjectCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dic_ProjectResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ResultId = table.Column<string>(maxLength: 50, nullable: true),
                    Result = table.Column<string>(nullable: true),
                    Explain = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dic_ProjectResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dic_SetUpProjectCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<string>(maxLength: 50, nullable: true),
                    Category = table.Column<string>(maxLength: 50, nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dic_SetUpProjectCategory", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dic_IndustryCategory");

            migrationBuilder.DropTable(
                name: "Dic_ProjectCategory");

            migrationBuilder.DropTable(
                name: "Dic_ProjectResult");

            migrationBuilder.DropTable(
                name: "Dic_SetUpProjectCategory");
        }
    }
}
