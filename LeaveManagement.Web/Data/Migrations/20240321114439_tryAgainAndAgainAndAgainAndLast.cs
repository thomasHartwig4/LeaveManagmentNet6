using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class tryAgainAndAgainAndAgainAndLast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33c43a6e-f7bb-4448-baa4-1add431c6aa2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baa4-1add431ccbbf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33c43a6e-f7bb-4448-baa4-1add431c6aa1", null, "User", "USER" },
                    { "cac43a6e-f7bb-4448-baa4-1add431ccbb1", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d840",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15a5ddfe-d323-4493-b7bd-391313cc87b7", "AQAAAAIAAYagAAAAELDbmSN+eNG+p+Pjt7QAppdVI8/FdXGdKpPmavKIyakOXtzJTrURPJVPS0Uxw99poQ==", "d47c4569-2e93-44fc-b43e-7669a6ce339a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "326e5ac1-d3d7-47cc-a8f7-2a63129eb6a1", "AQAAAAIAAYagAAAAEFW5NWpEGq+y6ig4kg/1JEGeUivmuLFgdDnsvmNdX0jQaWlm8JXFAjx9AVU9jVpkGg==", "54e4d171-193a-45b3-9371-34c7005ef140" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33c43a6e-f7bb-4448-baa4-1add431c6aa1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baa4-1add431ccbb1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33c43a6e-f7bb-4448-baa4-1add431c6aa2", null, "User", "USER" },
                    { "cac43a6e-f7bb-4448-baa4-1add431ccbbf", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d840",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ade9ff25-997a-470d-b25e-e37b1fe2c70c", "AQAAAAIAAYagAAAAED0u7mKMJhbs6lV8JQFaH46FAMUuZlDixr6w7EtUWcgCVTxd5iAXehil78zEjk5AzA==", "a2e722c5-3581-4eea-923d-86465dc52b3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f7cf825-1695-4304-b3a4-9355f44ade55", "AQAAAAIAAYagAAAAENv3TfwU6Q8FzEKEK50KpgbPVHrFR/axylcMFWj3u3n1UzMVqzC8qPz0+zN5KpQ7Yw==", "7450c49b-5b40-44cb-9c34-b719d4cfdabb" });
        }
    }
}
