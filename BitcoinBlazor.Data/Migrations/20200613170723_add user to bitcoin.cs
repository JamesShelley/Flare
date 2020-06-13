using Microsoft.EntityFrameworkCore.Migrations;

namespace BitcoinBlazor.Data.Migrations
{
    public partial class addusertobitcoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserBitcoinAddresses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserBitcoinAddresses_UserId",
                table: "UserBitcoinAddresses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBitcoinAddresses_AspNetUsers_UserId",
                table: "UserBitcoinAddresses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBitcoinAddresses_AspNetUsers_UserId",
                table: "UserBitcoinAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserBitcoinAddresses_UserId",
                table: "UserBitcoinAddresses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserBitcoinAddresses");
        }
    }
}
