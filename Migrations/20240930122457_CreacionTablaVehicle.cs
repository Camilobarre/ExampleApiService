using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleApiService.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTablaVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
