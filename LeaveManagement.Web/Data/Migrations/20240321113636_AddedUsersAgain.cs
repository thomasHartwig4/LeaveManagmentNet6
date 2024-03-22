using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedUsersAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d848",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a82986f-8a02-4ed8-9eb4-d47518622d3e", "AQAAAAIAAYagAAAAELC5OpC1kJC+/uvmczw7KCK9TW4ZYBROozGE34W7EU1VB/Ydns66MnwRzMTu/71L7A==", "df83b4e1-f964-4287-8baa-19427961970c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd6f1992-7a1c-4d45-a34b-2c34a27d1339", "AQAAAAIAAYagAAAAEGa3waK44TqMhMQtqWiYRAMmncpVjuUubx1PXiA9n2L0S3qlwTJBd3Fn+dj8+yhbOA==", "1a3bbd23-9e1d-424a-a2d3-903a9d1a17b3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d848",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e2d9072-f624-4a0d-b672-a5cdbb29f546", "AQAAAAIAAYagAAAAEKiySiGOoDcDGBL298ftTzksP661fJ8IOUFMk3dQiw589Bf576gOiJTLp2knophf/g==", "2257bf58-3dcd-42fb-b93b-84a9252da54f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edcbe183-88e0-4ba4-8b11-5ea012490468", "AQAAAAIAAYagAAAAEDG0cOPFThrRYiG00UPmn1W6H2/8Lmp6iojTPuFdDvMFqw+72eeqjRUdJnBHOoSyKA==", "05b1925f-757a-4998-9d08-601c6f7b6739" });
        }
    }
}
