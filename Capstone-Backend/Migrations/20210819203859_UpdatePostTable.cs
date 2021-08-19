using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_Backend.Migrations
{
    public partial class UpdatePostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostName",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostName",
                table: "Posts");
        }
    }
}
