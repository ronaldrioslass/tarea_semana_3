using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea_semana_3.Migrations
{
    public partial class AgregarCamposCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Clientes",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Clientes",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Clientes",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Clientes",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LimiteCredito",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "LimiteCredito",
                table: "Clientes");
        }
    }
}
