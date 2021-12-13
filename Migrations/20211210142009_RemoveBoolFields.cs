using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelSeedData.Migrations
{
    public partial class RemoveBoolFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ValidIcd10Sequelae",
                table: "Icd10Codes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "ValidIcd10Primary",
                table: "Icd10Codes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "ValidIcd10Dagger",
                table: "Icd10Codes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "ValidIcd10ClinicalUse",
                table: "Icd10Codes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "ValidIcd10Asterix",
                table: "Icd10Codes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Icd10Codes",
                keyColumn: "Id",
                keyValue: "bb314dc3-1d0e-4e70-b2d3-7fae76f09233",
                columns: new[] { "ValidIcd10Asterix", "ValidIcd10ClinicalUse", "ValidIcd10Dagger", "ValidIcd10Primary", "ValidIcd10Sequelae" },
                values: new object[] { null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ValidIcd10Sequelae",
                table: "Icd10Codes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ValidIcd10Primary",
                table: "Icd10Codes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ValidIcd10Dagger",
                table: "Icd10Codes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ValidIcd10ClinicalUse",
                table: "Icd10Codes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ValidIcd10Asterix",
                table: "Icd10Codes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Icd10Codes",
                keyColumn: "Id",
                keyValue: "bb314dc3-1d0e-4e70-b2d3-7fae76f09233",
                columns: new[] { "ValidIcd10Asterix", "ValidIcd10ClinicalUse", "ValidIcd10Dagger", "ValidIcd10Primary", "ValidIcd10Sequelae" },
                values: new object[] { false, false, false, false, false });
        }
    }
}
