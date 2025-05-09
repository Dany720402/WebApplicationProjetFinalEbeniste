using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationProjetFinal.Migrations
{
    /// <inheritdoc />
    public partial class suiteinitiale2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MotdePasse",
                table: "Clients",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MotdePasse",
                table: "Clients");
        }
    }
}
