using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerformansTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddAdSoyadToOgretmenler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siniflar_Ogretmenler_OgretmenId",
                table: "Siniflar");

            migrationBuilder.AlterColumn<int>(
                name: "OgretmenId",
                table: "Siniflar",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KullaniciAdi",
                table: "Ogretmenler",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "AdSoyad",
                table: "Ogretmenler",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Siniflar_Ogretmenler_OgretmenId",
                table: "Siniflar",
                column: "OgretmenId",
                principalTable: "Ogretmenler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siniflar_Ogretmenler_OgretmenId",
                table: "Siniflar");

            migrationBuilder.DropColumn(
                name: "AdSoyad",
                table: "Ogretmenler");

            migrationBuilder.AlterColumn<int>(
                name: "OgretmenId",
                table: "Siniflar",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "KullaniciAdi",
                table: "Ogretmenler",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Siniflar_Ogretmenler_OgretmenId",
                table: "Siniflar",
                column: "OgretmenId",
                principalTable: "Ogretmenler",
                principalColumn: "Id");
        }
    }
}
