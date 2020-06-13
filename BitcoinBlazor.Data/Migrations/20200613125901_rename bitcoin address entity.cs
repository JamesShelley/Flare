using Microsoft.EntityFrameworkCore.Migrations;

namespace BitcoinBlazor.Data.Migrations
{
    public partial class renamebitcoinaddressentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitcoinAddress");

            migrationBuilder.CreateTable(
                name: "UserBitcoinAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressNickname = table.Column<string>(nullable: true),
                    BitcoinPublicKey = table.Column<string>(nullable: true),
                    LegacyBitcoinTestNetAddress = table.Column<string>(nullable: true),
                    LegacyBitcoinMainNetAddress = table.Column<string>(nullable: true),
                    SegWitBitcoinTestNetAddress = table.Column<string>(nullable: true),
                    SegWitBitcoinMainNetAddress = table.Column<string>(nullable: true),
                    SegWitP2SHBitcoinTestNetAddress = table.Column<string>(nullable: true),
                    SegWitP2SHBitcoinMainNetAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBitcoinAddresses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBitcoinAddresses");

            migrationBuilder.CreateTable(
                name: "BitcoinAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressNickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BitcoinPublicKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegacyBitcoinMainNetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegacyBitcoinTestNetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegWitBitcoinMainNetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegWitBitcoinTestNetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegWitP2SHBitcoinMainNetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegWitP2SHBitcoinTestNetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitcoinAddress", x => x.Id);
                });
        }
    }
}
