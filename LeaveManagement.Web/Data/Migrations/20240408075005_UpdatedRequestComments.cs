using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d840",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08e1cde0-5720-4712-99e1-b911b2f0ad26", "AQAAAAIAAYagAAAAEIAXwJfqGA+DReL/lUQS5D/e5DsSkIfrvwNcXbhFofHQSOHvo7Zo3Z7UIArrPNxUbw==", "eea2dd38-576f-4158-b79c-a4dd707ca5c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f825472b-bc8e-46e9-802c-52b68b2e341d", "AQAAAAIAAYagAAAAEDAEhKzX/jY/TostmVuYeKFa254R4mkLJylltYVMf5TjSsO1FJaeIIl3j9wrOudrMg==", "26d0724f-4e66-450e-80a2-f14578d743d2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d840",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "679eb1e9-7bf1-4a98-9494-e5dcb92eefed", "AQAAAAIAAYagAAAAEHN46e3RHhrp9sTfVus4tCJ3LGvV65mvczE2TeFWx07jYrooS2WsX/HQ4DMWGYcSYg==", "879efcb5-4b70-4024-acf1-3c29bab1ca66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c9d9a24-bfae-4c8c-9cd0-7e6d46550661", "AQAAAAIAAYagAAAAECfPIBeQ6XtQDVnR+3/XXN9gtsiWT2JOAswm8ZVOC5yJN01/mq429GdP0Lzyrp+7EA==", "0a20988e-f134-43ff-9bd8-7fffb520b9bf" });
        }
    }
}
