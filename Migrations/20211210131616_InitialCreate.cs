using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelSeedData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Icd10Codes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icd103Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icd103CodeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icd10Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhoFullDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidIcd10ClinicalUse = table.Column<bool>(type: "bit", nullable: false),
                    ValidIcd10Primary = table.Column<bool>(type: "bit", nullable: false),
                    ValidIcd10Asterix = table.Column<bool>(type: "bit", nullable: false),
                    ValidIcd10Dagger = table.Column<bool>(type: "bit", nullable: false),
                    ValidIcd10Sequelae = table.Column<bool>(type: "bit", nullable: false),
                    AgeRangeMin = table.Column<int>(type: "int", nullable: false),
                    AgeRangeMax = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhoStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WhoEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WhoRevisionHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaRevisionHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icd10Codes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Icd10Codes");
        }
    }
}
