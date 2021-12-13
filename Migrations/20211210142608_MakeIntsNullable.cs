using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelSeedData.Migrations
{
    public partial class MakeIntsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Icd10Codes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AgeRangeMin",
                table: "Icd10Codes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AgeRangeMax",
                table: "Icd10Codes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Icd10Codes",
                keyColumn: "Id",
                keyValue: "bb314dc3-1d0e-4e70-b2d3-7fae76f09233",
                columns: new[] { "AgeRangeMax", "AgeRangeMin" },
                values: new object[] { null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Icd10Codes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgeRangeMin",
                table: "Icd10Codes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgeRangeMax",
                table: "Icd10Codes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Icd10Codes",
                keyColumn: "Id",
                keyValue: "bb314dc3-1d0e-4e70-b2d3-7fae76f09233",
                columns: new[] { "AgeRangeMax", "AgeRangeMin" },
                values: new object[] { 0, 0 });
        }
    }
}
