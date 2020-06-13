using Microsoft.EntityFrameworkCore.Migrations;

namespace BitcoinBlazor.Data.Migrations
{
    public partial class Init_Database_Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BitcoinAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BitcoinPublicKey = table.Column<string>(nullable: true),
                    BitcoinPrivateKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitcoinAddress", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitcoinAddress");
        }
    }
}
