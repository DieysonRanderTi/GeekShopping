using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.CouponAPI.Migrations
{
    public partial class IncludeCouponOnTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "id", "coupon-code", "discount-amount" },
                values: new object[] { 1L, "ERUDIO_2022_10", 10m });

            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "id", "coupon-code", "discount-amount" },
                values: new object[] { 2L, "ERUDIO_2022_15", 15m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
