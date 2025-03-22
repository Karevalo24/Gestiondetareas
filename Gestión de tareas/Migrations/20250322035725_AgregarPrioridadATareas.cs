using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestióndetareas.Migrations
{
    /// <inheritdoc />
    public partial class AgregarPrioridadATareas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Prioridad",
                table: "Tareas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Tareas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prioridad",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Tareas");
        }
    }
}
