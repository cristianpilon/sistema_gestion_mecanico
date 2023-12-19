using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_gestion_mecanico.Migrations
{
    /// <inheritdoc />
    public partial class IdMotorChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Motores",
                table: "Motores");

            migrationBuilder.AlterColumn<string>(
                name: "NroMotor",
                table: "Motores",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Motores",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motores",
                table: "Motores",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Motores",
                table: "Motores");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Motores");

            migrationBuilder.AlterColumn<string>(
                name: "NroMotor",
                table: "Motores",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motores",
                table: "Motores",
                column: "NroMotor");
        }
    }
}
