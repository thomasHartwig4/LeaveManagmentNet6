using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class tryAgainAndAgainAndAgainAndLastAndAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33c43a6e-f7bb-4448-baa4-1add431c6aa2", "408aa945-3d84-4421-8342-7269ec64d848" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baa4-1add431ccbbf", "408aa945-3d84-4421-8342-7269ec64d949" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "33c43a6e-f7bb-4448-baa4-1add431c6aa1", "408aa945-3d84-4421-8342-7269ec64d840" },
                    { "cac43a6e-f7bb-4448-baa4-1add431ccbb1", "408aa945-3d84-4421-8342-7269ec64d940" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d840",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ff6b30c-a337-4a7d-b1e7-c4a3e14b4928", "AQAAAAIAAYagAAAAEANnrbe2zPxIvpxLJh7RMGXu6BCq7/Qn2aW9/yVtvE29P0+pFKQ21AM93en6CuxD7A==", "e11ff529-7cc2-4341-a869-8130eca1a113" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48904688-d3a2-4460-88db-3cbadf843794", "AQAAAAIAAYagAAAAENswxr0oWZ57Mf4fphRiZxmyy7B22ZVLmtixcpgiV3fQPQo+4PfsyEPTqrPF8Ve1iw==", "f8ee45d6-8221-422b-a432-c69e77985a8f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33c43a6e-f7bb-4448-baa4-1add431c6aa1", "408aa945-3d84-4421-8342-7269ec64d840" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baa4-1add431ccbb1", "408aa945-3d84-4421-8342-7269ec64d940" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "33c43a6e-f7bb-4448-baa4-1add431c6aa2", "408aa945-3d84-4421-8342-7269ec64d848" },
                    { "cac43a6e-f7bb-4448-baa4-1add431ccbbf", "408aa945-3d84-4421-8342-7269ec64d949" }
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
    }
}
