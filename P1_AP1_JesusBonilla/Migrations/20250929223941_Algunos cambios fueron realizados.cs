using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P1_AP1_JesusBonilla.Migrations
{
    /// <inheritdoc />
    public partial class Algunoscambiosfueronrealizados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EntradasId",
                table: "EntradasHuacales",
                newName: "EntradaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EntradaId",
                table: "EntradasHuacales",
                newName: "EntradasId");
        }
    }
}
