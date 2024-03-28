using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AddSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { "0e2286fe-816d-4a8a-9a0f-253781d4d4bd", "projecto1", "Projecto1" },
                    { "5e8323d5-0de5-4425-a7ef-9edca21e1aff", "projecto4", "Projecto4" },
                    { "6691f1be-cea2-4716-85ef-afeeb7d9f999", "projecto2", "Projecto2" },
                    { "ac404f54-5654-4aba-8929-abdb08fab53d", "projecto3", "Projecto3" },
                    { "e1a23b85-8e9b-43bb-8c1b-e337d96fbdae", "projecto5", "Projecto5" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { "0b55c083-955d-4047-bc6f-14ccc1a7c56f", "Usuario5", "" },
                    { "21136259-c972-4611-a9a3-52eab8ee91c6", "Usuario4", "" },
                    { "22848509-4524-4b2d-9f9c-654eb1efae9c", "Usuario1", "" },
                    { "3e29e257-0472-4811-b1dc-2a00e99e9b31", "Usuario3", "" },
                    { "692989f9-4308-441a-a861-18a9133162eb", "Usuario2", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "0e2286fe-816d-4a8a-9a0f-253781d4d4bd");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "5e8323d5-0de5-4425-a7ef-9edca21e1aff");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "6691f1be-cea2-4716-85ef-afeeb7d9f999");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "ac404f54-5654-4aba-8929-abdb08fab53d");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "e1a23b85-8e9b-43bb-8c1b-e337d96fbdae");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0b55c083-955d-4047-bc6f-14ccc1a7c56f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21136259-c972-4611-a9a3-52eab8ee91c6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22848509-4524-4b2d-9f9c-654eb1efae9c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3e29e257-0472-4811-b1dc-2a00e99e9b31");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "692989f9-4308-441a-a861-18a9133162eb");
        }
    }
}
