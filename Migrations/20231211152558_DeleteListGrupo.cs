using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_gestion_mecanico.Migrations
{
    /// <inheritdoc />
    public partial class DeleteListGrupo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Grupos_GrupoId",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_GrupoId",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Grupos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Grupos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_GrupoId",
                table: "Grupos",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Grupos_GrupoId",
                table: "Grupos",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id");
        }
    }
}
