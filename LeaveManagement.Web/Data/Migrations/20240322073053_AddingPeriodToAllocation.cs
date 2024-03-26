using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d840",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9edd6e0b-1b12-44a2-ac9e-82a14b28babd", "AQAAAAIAAYagAAAAEMK0D8NO30ctZo0+vhr+ECIkxTsNuFSvihmDLsR6V9v/GE6MRXYyVpfTT9JG3E3rbA==", "50130e89-96c5-46ae-b2ca-adcd98fdf946" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11c5513d-51ed-4eef-86a4-51938beaf78e", "AQAAAAIAAYagAAAAEDsbcOFhHtPPeOag4x9EebmrGNO3pxpvvec8CyVGRvdLMMsawn/SsZPkXwI5sgpYNw==", "1413fee0-0025-4cd7-89e4-d2ce516db031" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
    }
}
