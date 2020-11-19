using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentApp.Model.Migrations
{
    public partial class Config_FluentApi_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incidente",
                columns: table => new
                {
                    IncidenteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioReportaId = table.Column<int>(nullable: false),
                    UsuarioAsignadoId = table.Column<int>(nullable: false),
                    PrioridadId = table.Column<int>(nullable: false),
                    DepartamentoId = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(max)", nullable: true),
                    FechaCierre = table.Column<DateTime>(nullable: false),
                    CoemntarioCierrre = table.Column<string>(maxLength: 500, nullable: true),
                    Estatus = table.Column<string>(maxLength: 2, nullable: false),
                    Borrado = table.Column<bool>(nullable: false, defaultValue: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 215, DateTimeKind.Local).AddTicks(4287)),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    CreadoPor = table.Column<int>(nullable: false),
                    ModificadoPor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidente", x => x.IncidenteId);
                });

            migrationBuilder.CreateTable(
                name: "HistorialIncidente",
                columns: table => new
                {
                    HistorialIncidenteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidenteId = table.Column<int>(nullable: false),
                    Comentario = table.Column<string>(nullable: true),
                    Estatus = table.Column<string>(nullable: true),
                    Borrado = table.Column<bool>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    CreadoPor = table.Column<int>(nullable: false),
                    ModificadoPor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialIncidente", x => x.HistorialIncidenteId);
                    table.ForeignKey(
                        name: "FK_HistorialIncidente_Incidente_IncidenteId",
                        column: x => x.IncidenteId,
                        principalTable: "Incidente",
                        principalColumn: "IncidenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PuestoID = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(maxLength: 100, nullable: false),
                    Cedula = table.Column<string>(maxLength: 11, nullable: false),
                    Correo = table.Column<string>(maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(maxLength: 15, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    NombreUsuario = table.Column<string>(maxLength: 100, nullable: false),
                    Contraseña = table.Column<string>(maxLength: 500, nullable: false),
                    Estatus = table.Column<string>(maxLength: 2, nullable: false),
                    Borrado = table.Column<bool>(nullable: false, defaultValue: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 171, DateTimeKind.Local).AddTicks(4372)),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    CreadoPor = table.Column<int>(nullable: false),
                    ModificadoPor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Estatus = table.Column<string>(maxLength: 2, nullable: false),
                    Borrado = table.Column<bool>(nullable: false, defaultValue: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 164, DateTimeKind.Local).AddTicks(8880)),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    CreadoPor = table.Column<int>(nullable: false),
                    ModificadoPor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DepartamentoId);
                    table.ForeignKey(
                        name: "FK_Departamento_Usuario_CreadoPor",
                        column: x => x.CreadoPor,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departamento_Usuario_ModificadoPor",
                        column: x => x.ModificadoPor,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Puesto",
                columns: table => new
                {
                    PuestoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartamentoId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Estatus = table.Column<string>(maxLength: 2, nullable: false),
                    Borrado = table.Column<bool>(nullable: false, defaultValue: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 166, DateTimeKind.Local).AddTicks(9695)),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    CreadoPor = table.Column<int>(nullable: false),
                    ModificadoPor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puesto", x => x.PuestoId);
                    table.ForeignKey(
                        name: "FK_Puesto_Usuario_CreadoPor",
                        column: x => x.CreadoPor,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Puesto_Usuario_ModificadoPor",
                        column: x => x.ModificadoPor,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Sla",
                columns: table => new
                {
                    SlaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: false),
                    CantdadHoras = table.Column<int>(nullable: false),
                    Estatus = table.Column<string>(maxLength: 2, nullable: false),
                    Borrado = table.Column<bool>(nullable: false, defaultValue: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 210, DateTimeKind.Local).AddTicks(1260)),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    CreadoPor = table.Column<int>(nullable: false),
                    ModificadoPor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sla", x => x.SlaId);
                    table.ForeignKey(
                        name: "FK_Sla_Usuario_CreadoPor",
                        column: x => x.CreadoPor,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sla_Usuario_ModificadoPor",
                        column: x => x.ModificadoPor,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Prioridad",
                columns: table => new
                {
                    PrioridadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlaId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Estatus = table.Column<string>(maxLength: 2, nullable: false),
                    Borrado = table.Column<bool>(nullable: false, defaultValue: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 211, DateTimeKind.Local).AddTicks(5695)),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    CreadoPor = table.Column<int>(nullable: false),
                    ModificadoPor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioridad", x => x.PrioridadId);
                    table.ForeignKey(
                        name: "FK_Prioridad_Usuario_CreadoPor",
                        column: x => x.CreadoPor,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prioridad_Usuario_ModificadoPor",
                        column: x => x.ModificadoPor,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                    table.ForeignKey(
                        name: "FK_Prioridad_Sla_SlaId",
                        column: x => x.SlaId,
                        principalTable: "Sla",
                        principalColumn: "SlaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_CreadoPor",
                table: "Departamento",
                column: "CreadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_ModificadoPor",
                table: "Departamento",
                column: "ModificadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialIncidente_CreadoPor",
                table: "HistorialIncidente",
                column: "CreadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialIncidente_IncidenteId",
                table: "HistorialIncidente",
                column: "IncidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialIncidente_ModificadoPor",
                table: "HistorialIncidente",
                column: "ModificadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_CreadoPor",
                table: "Incidente",
                column: "CreadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_DepartamentoId",
                table: "Incidente",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_ModificadoPor",
                table: "Incidente",
                column: "ModificadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_PrioridadId",
                table: "Incidente",
                column: "PrioridadId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_UsuarioAsignadoId",
                table: "Incidente",
                column: "UsuarioAsignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_UsuarioReportaId",
                table: "Incidente",
                column: "UsuarioReportaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prioridad_CreadoPor",
                table: "Prioridad",
                column: "CreadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Prioridad_ModificadoPor",
                table: "Prioridad",
                column: "ModificadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Prioridad_SlaId",
                table: "Prioridad",
                column: "SlaId");

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_CreadoPor",
                table: "Puesto",
                column: "CreadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_ModificadoPor",
                table: "Puesto",
                column: "ModificadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Sla_CreadoPor",
                table: "Sla",
                column: "CreadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Sla_ModificadoPor",
                table: "Sla",
                column: "ModificadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PuestoID",
                table: "Usuario",
                column: "PuestoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Usuario_CreadoPor",
                table: "Incidente",
                column: "CreadoPor",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Usuario_ModificadoPor",
                table: "Incidente",
                column: "ModificadoPor",
                principalTable: "Usuario",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Usuario_UsuarioAsignadoId",
                table: "Incidente",
                column: "UsuarioAsignadoId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Usuario_UsuarioReportaId",
                table: "Incidente",
                column: "UsuarioReportaId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Departamento_DepartamentoId",
                table: "Incidente",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Prioridad_PrioridadId",
                table: "Incidente",
                column: "PrioridadId",
                principalTable: "Prioridad",
                principalColumn: "PrioridadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialIncidente_Usuario_CreadoPor",
                table: "HistorialIncidente",
                column: "CreadoPor",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialIncidente_Usuario_ModificadoPor",
                table: "HistorialIncidente",
                column: "ModificadoPor",
                principalTable: "Usuario",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Puesto_PuestoID",
                table: "Usuario",
                column: "PuestoID",
                principalTable: "Puesto",
                principalColumn: "PuestoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_Usuario_CreadoPor",
                table: "Puesto");

            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_Usuario_ModificadoPor",
                table: "Puesto");

            migrationBuilder.DropTable(
                name: "HistorialIncidente");

            migrationBuilder.DropTable(
                name: "Incidente");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Prioridad");

            migrationBuilder.DropTable(
                name: "Sla");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Puesto");
        }
    }
}
