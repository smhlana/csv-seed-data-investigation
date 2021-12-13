using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelSeedData.Migrations
{
    public partial class AddSeedDataTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Icd10Codes",
                columns: new[] { "Id", "AgeRangeMax", "AgeRangeMin", "Chapter", "ChapterDescription", "Comment", "Gender", "GroupCode", "GroupDescription", "Icd103Code", "Icd103CodeDescription", "Icd10Code", "Number", "SaEndDate", "SaRevisionHistory", "SaStartDate", "Status", "ValidIcd10Asterix", "ValidIcd10ClinicalUse", "ValidIcd10Dagger", "ValidIcd10Primary", "ValidIcd10Sequelae", "WhoEndDate", "WhoFullDescription", "WhoRevisionHistory", "WhoStartDate" },
                values: new object[] { "bb314dc3-1d0e-4e70-b2d3-7fae76f09233", 0, 0, "Chapter 1", null, null, null, null, null, null, null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Icd10Codes",
                keyColumn: "Id",
                keyValue: "bb314dc3-1d0e-4e70-b2d3-7fae76f09233");
        }
    }
}
