using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneBackend.Migrations
{
    public partial class FixingTopicTableNameToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62bb033b-ce66-4b2b-99f1-c688febe8396");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "636151f9-fb92-4fe9-a30b-69b25b0c49a0");

            migrationBuilder.AlterColumn<string>(
                name: "TopicName",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d47926d-489b-48e4-aaef-4463f58dfa07", "ff301b62-5602-458a-9228-76938e9a118d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbc5a36a-2f49-4c3c-a455-9f9d1a3e01e9", "bf328318-5648-4e1a-aff5-5b6d52767763", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d47926d-489b-48e4-aaef-4463f58dfa07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbc5a36a-2f49-4c3c-a455-9f9d1a3e01e9");

            migrationBuilder.AlterColumn<int>(
                name: "TopicName",
                table: "Topics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "636151f9-fb92-4fe9-a30b-69b25b0c49a0", "69bb11aa-8c95-40fc-9583-525fc0cca923", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62bb033b-ce66-4b2b-99f1-c688febe8396", "1639eb12-16d6-4bc4-9583-3340d54d4b89", "Admin", "ADMIN" });
        }
    }
}
