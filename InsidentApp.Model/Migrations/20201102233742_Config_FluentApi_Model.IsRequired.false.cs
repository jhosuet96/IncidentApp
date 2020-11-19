using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentApp.Model.Migrations
{
    public partial class Config_FluentApi_ModelIsRequiredfalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 718, DateTimeKind.Local).AddTicks(166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 73, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 760, DateTimeKind.Local).AddTicks(188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 115, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 709, DateTimeKind.Local).AddTicks(5264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 66, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 761, DateTimeKind.Local).AddTicks(4742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 116, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 764, DateTimeKind.Local).AddTicks(3985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 119, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 706, DateTimeKind.Local).AddTicks(4923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 63, DateTimeKind.Local).AddTicks(7299));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 73, DateTimeKind.Local).AddTicks(9738),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 718, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 115, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 760, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 66, DateTimeKind.Local).AddTicks(2570),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 709, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 116, DateTimeKind.Local).AddTicks(5863),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 761, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 119, DateTimeKind.Local).AddTicks(4157),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 764, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 33, 48, 63, DateTimeKind.Local).AddTicks(7299),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 37, 42, 706, DateTimeKind.Local).AddTicks(4923));
        }
    }
}
