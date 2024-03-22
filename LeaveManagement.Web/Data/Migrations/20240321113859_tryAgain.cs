using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class tryAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d848",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e828682-f552-4a6a-aa53-274cf34d21ae", "AQAAAAIAAYagAAAAEIuUtMmZOn628STaLuLXFpGRBPi/vlmeB1NGYaidSop52C37cIrAoQ/+uR28LCeu+Q==", "0373d0e9-063d-41fa-a58e-25281473e02d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86bcc739-80de-4a25-863f-1e57ac304bbc", "AQAAAAIAAYagAAAAEKmSjJEzJEZzdp3x6HpVaPZ/EOpSumOQOHOy2MET1EQQrRJ33o+zsY3WYkFFq0G9/g==", "7056f284-bb84-494a-8bca-f5bf5d1677a2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
