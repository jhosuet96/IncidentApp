using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentApp.Model.Migrations
{
    public partial class Config_FluentApi_ModelUsuarioPuesto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 73, DateTimeKind.Local).AddTicks(9738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 399, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 115, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 431, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 66, DateTimeKind.Local).AddTicks(2570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 391, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 116, DateTimeKind.Local).AddTicks(5863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 433, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 119, DateTimeKind.Local).AddTicks(4157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 436, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 63, DateTimeKind.Local).AddTicks(7299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 389, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CreadoPor",
                table: "Usuario",
                column: "CreadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ModificadoPor",
                table: "Usuario",
                column: "ModificadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PuestoID",
                table: "Usuario",
                column: "PuestoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Usuario_CreadoPor",
                table: "Usuario",
                column: "CreadoPor",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Usuario_ModificadoPor",
                table: "Usuario",
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
                name: "FK_Usuario_Usuario_CreadoPor",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Usuario_ModificadoPor",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Puesto_PuestoID",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_CreadoPor",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_ModificadoPor",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PuestoID",
                table: "Usuario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 399, DateTimeKind.Local).AddTicks(1374),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 73, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 431, DateTimeKind.Local).AddTicks(8698),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 115, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 391, DateTimeKind.Local).AddTicks(8399),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 66, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 433, DateTimeKind.Local).AddTicks(4393),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 116, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 436, DateTimeKind.Local).AddTicks(3839),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 119, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 389, DateTimeKind.Local).AddTicks(1041),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 63, DateTimeKind.Local).AddTicks(7299));
        }
    }
}
