using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_gestion_mecanico.Migrations
{
    /// <inheritdoc />
    public partial class Modulo_Seguridad_Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_Grupos_GrupoId",
                table: "Permisos");

            migrationBuilder.DropIndex(
                name: "IX_Permisos_GrupoId",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Permisos");

            migrationBuilder.CreateTable(
                name: "GrupoPermiso",
                columns: table => new
                {
                    GruposId = table.Column<int>(type: "int", nullable: false),
                    PermisosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoPermiso", x => new { x.GruposId, x.PermisosId });
                    table.ForeignKey(
                        name: "FK_GrupoPermiso_Grupos_GruposId",
                        column: x => x.GruposId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoPermiso_Permisos_PermisosId",
                        column: x => x.PermisosId,
                        principalTable: "Permisos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupoPermiso_PermisosId",
                table: "GrupoPermiso",
                column: "PermisosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupoPermiso");

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Permisos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_GrupoId",
                table: "Permisos",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_Grupos_GrupoId",
                table: "Permisos",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
