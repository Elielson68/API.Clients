using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Clients.Migrations
{
    public partial class NovosCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AlertStreamer",
                table: "Client",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HaveAnimal",
                table: "Client",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NumberComputer",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlertStreamer",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "HaveAnimal",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "NumberComputer",
                table: "Client");
        }
    }
}
