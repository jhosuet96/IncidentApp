using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentApp.Model.Migrations
{
    public partial class Config_FluentApi_Model01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 274, DateTimeKind.Local).AddTicks(1015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 682, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 325, DateTimeKind.Local).AddTicks(1508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 729, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 264, DateTimeKind.Local).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 674, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 326, DateTimeKind.Local).AddTicks(5543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 731, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 329, DateTimeKind.Local).AddTicks(3727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 734, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 262, DateTimeKind.Local).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 672, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CreadoPor",
                table: "Usuario",
                column: "CreadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ModificadoPor",
                table: "Usuario",
                column: "ModificadoPor");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Usuario_CreadoPor",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Usuario_ModificadoPor",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_CreadoPor",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_ModificadoPor",
                table: "Usuario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 682, DateTimeKind.Local).AddTicks(781),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 274, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 729, DateTimeKind.Local).AddTicks(9212),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 325, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 674, DateTimeKind.Local).AddTicks(6732),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 264, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 731, DateTimeKind.Local).AddTicks(3249),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 326, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 734, DateTimeKind.Local).AddTicks(1623),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 329, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 27, 23, 32, 41, 672, DateTimeKind.Local).AddTicks(2020),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 262, DateTimeKind.Local).AddTicks(3590));
        }
    }
}
