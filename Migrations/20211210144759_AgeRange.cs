using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelSeedData.Migrations
{
    public partial class AgeRange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeRangeMax",
                table: "Icd10Codes");

            migrationBuilder.DropColumn(
                name: "AgeRangeMin",
                table: "Icd10Codes");

            migrationBuilder.AddColumn<string>(
                name: "AgeRange",
                table: "Icd10Codes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeRange",
                table: "Icd10Codes");

            migrationBuilder.AddColumn<int>(
                name: "AgeRangeMax",
                table: "Icd10Codes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgeRangeMin",
                table: "Icd10Codes",
                type: "int",
                nullable: true);
        }
    }
}
