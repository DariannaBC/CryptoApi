using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoApi.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    MonedaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<double>(type: "REAL", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.MonedaId);
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 1, "Bitcoin", "https://cdn.icon-icons.com/icons2/1487/PNG/512/8369-bitcoin_102502.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 2, "Ethereum", "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 3, "Litecoin", "https://cdn.icon-icons.com/icons2/2648/PNG/512/finance_litecoin_icon_160836.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 4, "Ripple", "https://cdn.icon-icons.com/icons2/3392/PNG/512/ripple_icon_213731.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 5, "Stellar", "https://cdn.icon-icons.com/icons2/3350/PNG/512/cryptocurrencies_stellar_coin_money_icon_210245.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 6, "Tether", "https://iconape.com/wp-content/files/ac/209643/png/tether-usdt-logo.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 7, "EOS", "https://cdn.icon-icons.com/icons2/1384/PNG/512/eos-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95175.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 8, "Cardano", "https://cdn.icon-icons.com/icons2/3279/PNG/512/cardano_ada_coin_icon_208056.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 9, "Dash", "https://cdn.icon-icons.com/icons2/1386/PNG/512/dash-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95627.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 10, "Zcash", "https://cdn.icon-icons.com/icons2/2699/PNG/512/zcash_logo_icon_169679.png", 8100.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coins");
        }
    }
}
