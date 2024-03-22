using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class tryAgainAndAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d848",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d987d485-a80a-4744-8b71-c8d0d4f5b4f4", "AQAAAAIAAYagAAAAEKf47ebLi2IivJiDjln+9mBtpvspsSI918l1qOrGy17Xq6btHlVk62HFj0n2umV0Yg==", "96b940ac-7050-4396-b988-5ff67b70d05c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e99c9471-e933-41b9-ac24-dc2a4423fb30", "AQAAAAIAAYagAAAAEH1e0koRstA+7un9yc83xy0cRAu/zFTKnnPWRkVb/gcAqchDfdVZDgySLFb0ocdu4A==", "a6d16510-269e-4caa-bf43-33e3412b8df3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
