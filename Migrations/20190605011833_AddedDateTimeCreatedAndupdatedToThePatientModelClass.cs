using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrugPrescriptionSystemVersion1.Migrations
{
    public partial class AddedDateTimeCreatedAndupdatedToThePatientModelClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Patients");
        }
    }
}
