using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _5TemmuzUygulama.Data.Migrations
{
    public partial class EkleYeniSutun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tur",
                table: "Semesters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_Tur",
                table: "Semesters",
                column: "Tur",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Semesters_Tur",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "Tur",
                table: "Semesters");
        }
    }
}
