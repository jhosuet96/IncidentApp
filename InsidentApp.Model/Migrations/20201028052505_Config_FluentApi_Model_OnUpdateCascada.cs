using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentApp.Model.Migrations
{
    public partial class Config_FluentApi_Model_OnUpdateCascada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 36, DateTimeKind.Local).AddTicks(9574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 274, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 90, DateTimeKind.Local).AddTicks(8465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 325, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 28, DateTimeKind.Local).AddTicks(5059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 264, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 92, DateTimeKind.Local).AddTicks(2537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 326, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 96, DateTimeKind.Local).AddTicks(3600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 329, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 26, DateTimeKind.Local).AddTicks(606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 262, DateTimeKind.Local).AddTicks(3590));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 274, DateTimeKind.Local).AddTicks(1015),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 36, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 325, DateTimeKind.Local).AddTicks(1508),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 90, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 264, DateTimeKind.Local).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 28, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 326, DateTimeKind.Local).AddTicks(5543),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 92, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 329, DateTimeKind.Local).AddTicks(3727),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 96, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 28, 0, 32, 45, 262, DateTimeKind.Local).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 28, 1, 25, 5, 26, DateTimeKind.Local).AddTicks(606));
        }
    }
}
