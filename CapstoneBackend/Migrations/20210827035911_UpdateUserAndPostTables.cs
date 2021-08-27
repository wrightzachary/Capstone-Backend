using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneBackend.Migrations
{
    public partial class UpdateUserAndPostTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9e80651-d395-404b-825c-f23d841f146a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb198760-97ee-41cb-84d1-6dcb06db8265");

            migrationBuilder.DropColumn(
                name: "PostName",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "Topic",
                table: "Posts",
                newName: "PostContext");

            migrationBuilder.AddColumn<string>(
                name: "BranchServed",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentLocation",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DutyStation",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c1d5ab57-21df-4c34-bc3c-a68c308b8732", "f49260a1-0169-4f33-b817-bee339ed6691", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de55f5a1-0ab6-49b0-ba8a-7fd236779d62", "217d23d8-859f-43c5-8e73-ce9797ea8f8e", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1d5ab57-21df-4c34-bc3c-a68c308b8732");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de55f5a1-0ab6-49b0-ba8a-7fd236779d62");

            migrationBuilder.DropColumn(
                name: "BranchServed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CurrentLocation",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DutyStation",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "PostContext",
                table: "Posts",
                newName: "Topic");

            migrationBuilder.AddColumn<string>(
                name: "PostName",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb198760-97ee-41cb-84d1-6dcb06db8265", "b966bed0-3649-4101-8a3b-327ab6c8e71b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b9e80651-d395-404b-825c-f23d841f146a", "2533687c-1f46-48b9-b3f5-7febd7d498c6", "Admin", "ADMIN" });
        }
    }
}
