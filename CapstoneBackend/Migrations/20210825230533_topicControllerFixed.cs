using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneBackend.Migrations
{
    public partial class topicControllerFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d47926d-489b-48e4-aaef-4463f58dfa07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbc5a36a-2f49-4c3c-a455-9f9d1a3e01e9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb198760-97ee-41cb-84d1-6dcb06db8265", "b966bed0-3649-4101-8a3b-327ab6c8e71b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b9e80651-d395-404b-825c-f23d841f146a", "2533687c-1f46-48b9-b3f5-7febd7d498c6", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9e80651-d395-404b-825c-f23d841f146a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb198760-97ee-41cb-84d1-6dcb06db8265");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d47926d-489b-48e4-aaef-4463f58dfa07", "ff301b62-5602-458a-9228-76938e9a118d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbc5a36a-2f49-4c3c-a455-9f9d1a3e01e9", "bf328318-5648-4e1a-aff5-5b6d52767763", "Admin", "ADMIN" });
        }
    }
}
