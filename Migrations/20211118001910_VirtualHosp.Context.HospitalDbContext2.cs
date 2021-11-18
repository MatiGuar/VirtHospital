using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualHosp.Migrations
{
    public partial class VirtualHospContextHospitalDbContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuarios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Especialidad",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroMatricula",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AntecedentesMedicos",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HistorialMedico",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Medicamentos",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "planMedico",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Especialidad",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "NumeroMatricula",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "AntecedentesMedicos",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "HistorialMedico",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Medicamentos",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "planMedico",
                table: "Usuarios");
        }
    }
}
