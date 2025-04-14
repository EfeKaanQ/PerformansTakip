using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerformansTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddTcToOgretmenAddTcToOgretmen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TC",
                table: "Ogretmenler",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TC",
                table: "Ogretmenler");
        }
    }
}
