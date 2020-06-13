using Microsoft.EntityFrameworkCore.Migrations;

namespace BitcoinBlazor.Data.Migrations
{
    public partial class Addbitcoinaddressnickname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressNickname",
                table: "BitcoinAddress",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNickname",
                table: "BitcoinAddress");
        }
    }
}
