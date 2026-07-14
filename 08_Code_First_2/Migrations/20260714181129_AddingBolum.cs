using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _08_Code_First_2.Migrations
{
    /// <inheritdoc />
    public partial class AddingBolum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BolumId",
                table: "Siniflar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Bolumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Siniflar_BolumId",
                table: "Siniflar",
                column: "BolumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Siniflar_Bolumler_BolumId",
                table: "Siniflar",
                column: "BolumId",
                principalTable: "Bolumler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siniflar_Bolumler_BolumId",
                table: "Siniflar");

            migrationBuilder.DropTable(
                name: "Bolumler");

            migrationBuilder.DropIndex(
                name: "IX_Siniflar_BolumId",
                table: "Siniflar");

            migrationBuilder.DropColumn(
                name: "BolumId",
                table: "Siniflar");
        }
    }
}
