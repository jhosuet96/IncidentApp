using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentApp.Model.Migrations
{
    public partial class Config_FluentApi_ModelPuestoDepartamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 399, DateTimeKind.Local).AddTicks(1374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 960, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 431, DateTimeKind.Local).AddTicks(8698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 994, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 391, DateTimeKind.Local).AddTicks(8399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 956, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 433, DateTimeKind.Local).AddTicks(4393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 996, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 436, DateTimeKind.Local).AddTicks(3839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 21, 1, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 389, DateTimeKind.Local).AddTicks(1041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 954, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_DepartamentoId",
                table: "Puesto",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Puesto_Departamento_DepartamentoId",
                table: "Puesto",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "DepartamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_Departamento_DepartamentoId",
                table: "Puesto");

            migrationBuilder.DropIndex(
                name: "IX_Puesto_DepartamentoId",
                table: "Puesto");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 960, DateTimeKind.Local).AddTicks(8625),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 399, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 994, DateTimeKind.Local).AddTicks(3158),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 431, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 956, DateTimeKind.Local).AddTicks(3206),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 391, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 996, DateTimeKind.Local).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 433, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 21, 1, DateTimeKind.Local).AddTicks(1213),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 436, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 954, DateTimeKind.Local).AddTicks(2376),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 26, 23, 389, DateTimeKind.Local).AddTicks(1041));
        }
    }
}
