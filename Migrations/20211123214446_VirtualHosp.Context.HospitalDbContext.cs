using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualHosp.Migrations
{
    public partial class VirtualHospContextHospitalDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    TipoDocumento = table.Column<int>(nullable: false),
                    NumeroDocumento = table.Column<int>(nullable: false),
                    EstadoCivil = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Nacionalidad = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    CodigoPostal = table.Column<int>(nullable: true),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Especialidad = table.Column<int>(nullable: true),
                    NumeroMatricula = table.Column<int>(nullable: true),
                    HistorialMedico = table.Column<string>(nullable: true),
                    Medicamentos = table.Column<string>(nullable: true),
                    AntecedentesMedicos = table.Column<string>(nullable: true),
                    PlanMedico = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicoId = table.Column<int>(nullable: false),
                    pacienteId = table.Column<int>(nullable: false),
                    HorarioInicio = table.Column<float>(nullable: false),
                    HorarioFinal = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultas_Usuarios_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Usuarios_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_medicoId",
                table: "Consultas",
                column: "medicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_pacienteId",
                table: "Consultas",
                column: "pacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
