using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamsSystem.Data.Migrations
{
    public partial class AddExamDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxPoint",
                table: "ExamResults");

            migrationBuilder.DropColumn(
                name: "Percent",
                table: "ExamResults");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "ExamResults");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Exams");

            migrationBuilder.AddColumn<int>(
                name: "MaxPoint",
                table: "ExamResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Percent",
                table: "ExamResults",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "ExamResults",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
