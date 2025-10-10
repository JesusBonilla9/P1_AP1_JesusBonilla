using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P1_AP1_JesusBonilla.Migrations
{
    /// <inheritdoc />
    public partial class Cambios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntradasHuacalesDetalles_TiposHuacales_TipoId",
                table: "EntradasHuacalesDetalles");

            migrationBuilder.DropIndex(
                name: "IX_EntradasHuacalesDetalles_TipoId",
                table: "EntradasHuacalesDetalles");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "EntradasHuacales",
                newName: "Importe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Importe",
                table: "EntradasHuacales",
                newName: "Precio");

            migrationBuilder.CreateIndex(
                name: "IX_EntradasHuacalesDetalles_TipoId",
                table: "EntradasHuacalesDetalles",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntradasHuacalesDetalles_TiposHuacales_TipoId",
                table: "EntradasHuacalesDetalles",
                column: "TipoId",
                principalTable: "TiposHuacales",
                principalColumn: "TipoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
