using Microsoft.EntityFrameworkCore.Migrations;

namespace BitcoinBlazor.Data.Migrations
{
    public partial class addbitcoinpublickeyandnetworkaddresstypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BitcoinPrivateKey",
                table: "BitcoinAddress");

            migrationBuilder.AddColumn<string>(
                name: "LegacyBitcoinMainNetAddress",
                table: "BitcoinAddress",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LegacyBitcoinTestNetAddress",
                table: "BitcoinAddress",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegWitBitcoinMainNetAddress",
                table: "BitcoinAddress",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegWitBitcoinTestNetAddress",
                table: "BitcoinAddress",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegWitP2SHBitcoinMainNetAddress",
                table: "BitcoinAddress",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegWitP2SHBitcoinTestNetAddress",
                table: "BitcoinAddress",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LegacyBitcoinMainNetAddress",
                table: "BitcoinAddress");

            migrationBuilder.DropColumn(
                name: "LegacyBitcoinTestNetAddress",
                table: "BitcoinAddress");

            migrationBuilder.DropColumn(
                name: "SegWitBitcoinMainNetAddress",
                table: "BitcoinAddress");

            migrationBuilder.DropColumn(
                name: "SegWitBitcoinTestNetAddress",
                table: "BitcoinAddress");

            migrationBuilder.DropColumn(
                name: "SegWitP2SHBitcoinMainNetAddress",
                table: "BitcoinAddress");

            migrationBuilder.DropColumn(
                name: "SegWitP2SHBitcoinTestNetAddress",
                table: "BitcoinAddress");

            migrationBuilder.AddColumn<string>(
                name: "BitcoinPrivateKey",
                table: "BitcoinAddress",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
