using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerformansTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddOgretmenTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgretmenId",
                table: "Siniflar",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ogretmenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullaniciAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Sifre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmenler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Siniflar_OgretmenId",
                table: "Siniflar",
                column: "OgretmenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Siniflar_Ogretmenler_OgretmenId",
                table: "Siniflar",
                column: "OgretmenId",
                principalTable: "Ogretmenler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siniflar_Ogretmenler_OgretmenId",
                table: "Siniflar");

            migrationBuilder.DropTable(
                name: "Ogretmenler");

            migrationBuilder.DropIndex(
                name: "IX_Siniflar_OgretmenId",
                table: "Siniflar");

            migrationBuilder.DropColumn(
                name: "OgretmenId",
                table: "Siniflar");
        }
    }
}
