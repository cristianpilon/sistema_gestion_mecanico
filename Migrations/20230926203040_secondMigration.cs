using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_gestion_mecanico.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NroMotorId",
                table: "Motores",
                newName: "NroMotor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NroMotor",
                table: "Motores",
                newName: "NroMotorId");
        }
    }
}
