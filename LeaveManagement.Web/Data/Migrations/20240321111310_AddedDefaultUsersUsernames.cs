using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersUsernames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d848",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8783e7b4-b829-49af-b852-fd0e82cc4951", true, "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHLS26MwAqphvq3Yf/gTWa4wdOefzKVhApORalVHg47xWyXlplfON6CXOdCYRj/5mw==", "b8b9e898-a4c1-4243-adcf-8cc567ea62cf", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "067c278d-54a6-43e5-a472-73168d52d24b", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMoxAuY1pS0h4z95Lir92HvrkzZp9GCV3XVJt8eYmVAMPbkOO8PfIfGr4bF3SR2WaQ==", "fbaca687-09ba-4a22-9585-03ac2c3d9991", "admin@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d848",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5eefd651-367e-4655-a7b0-4fd116de9caf", false, null, "AQAAAAIAAYagAAAAEJq5AAoKEWJTZ3062jCAJjT8l2RB6ASs2hD808aE0/4WrDuKJXNdjKH3FZ6Q1JxR6g==", "761a1e57-9823-4258-bd24-9032d4a795da", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "54b0af1a-57c7-4c8a-8607-c99e4a845faa", false, null, "AQAAAAIAAYagAAAAECJhDkjVJuazayVYOSM/nbD/2xox8TrqJsS+pwdHvvjUfnd5rpdok0H7+uPN+/qREQ==", "79710a78-9c4b-42c4-b5a7-01fa424d5f81", null });
        }
    }
}
