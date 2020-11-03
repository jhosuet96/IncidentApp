using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentApp.Model.Migrations
{
    public partial class Config_FluentApi_Model1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Puesto_PuestoID",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PuestoID",
                table: "Usuario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 960, DateTimeKind.Local).AddTicks(8625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 171, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 994, DateTimeKind.Local).AddTicks(3158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 210, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 956, DateTimeKind.Local).AddTicks(3206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 166, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 996, DateTimeKind.Local).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 211, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 21, 1, DateTimeKind.Local).AddTicks(1213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 215, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 954, DateTimeKind.Local).AddTicks(2376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 164, DateTimeKind.Local).AddTicks(8880));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 171, DateTimeKind.Local).AddTicks(4372),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 960, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Sla",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 210, DateTimeKind.Local).AddTicks(1260),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 994, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Puesto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 166, DateTimeKind.Local).AddTicks(9695),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 956, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Prioridad",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 211, DateTimeKind.Local).AddTicks(5695),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 996, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Incidente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 215, DateTimeKind.Local).AddTicks(4287),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 21, 1, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Departamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 2, 19, 16, 49, 164, DateTimeKind.Local).AddTicks(8880),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 2, 19, 19, 20, 954, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PuestoID",
                table: "Usuario",
                column: "PuestoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Puesto_PuestoID",
                table: "Usuario",
                column: "PuestoID",
                principalTable: "Puesto",
                principalColumn: "PuestoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
