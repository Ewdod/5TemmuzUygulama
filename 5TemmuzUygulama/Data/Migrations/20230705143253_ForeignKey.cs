using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _5TemmuzUygulama.Data.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParaBaglantisi",
                table: "Semesters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TotalMoney",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalMoney", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_ParaBaglantisi",
                table: "Semesters",
                column: "ParaBaglantisi",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_TotalMoney_ParaBaglantisi",
                table: "Semesters",
                column: "ParaBaglantisi",
                principalTable: "TotalMoney",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_TotalMoney_ParaBaglantisi",
                table: "Semesters");

            migrationBuilder.DropTable(
                name: "TotalMoney");

            migrationBuilder.DropIndex(
                name: "IX_Semesters_ParaBaglantisi",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "ParaBaglantisi",
                table: "Semesters");
        }
    }
}
