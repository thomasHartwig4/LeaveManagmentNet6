using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d848",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8783e7b4-b829-49af-b852-fd0e82cc4951", "AQAAAAIAAYagAAAAEHLS26MwAqphvq3Yf/gTWa4wdOefzKVhApORalVHg47xWyXlplfON6CXOdCYRj/5mw==", "b8b9e898-a4c1-4243-adcf-8cc567ea62cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "067c278d-54a6-43e5-a472-73168d52d24b", "AQAAAAIAAYagAAAAEMoxAuY1pS0h4z95Lir92HvrkzZp9GCV3XVJt8eYmVAMPbkOO8PfIfGr4bF3SR2WaQ==", "fbaca687-09ba-4a22-9585-03ac2c3d9991" });
        }
    }
}
