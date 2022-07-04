using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoApi.Migrations
{
    public partial class Cambios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 1,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Bitcoin Cash", "https://cdn.icon-icons.com/icons2/3369/PNG/512/bitcoin_cryptocurrency_coin_money_icon_210978.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 2,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Dai", "https://cdn.icon-icons.com/icons2/2130/PNG/512/dai_cryptocurrency_logo_icon_131454.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 3,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Polygon", "https://cdn.icon-icons.com/icons2/3373/PNG/512/polygon_icon_211236.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 4,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Litecoin", "https://cdn.icon-icons.com/icons2/2699/PNG/512/litecoin_logo_icon_170221.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 5,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "WEMIX", "https://cdn.icon-icons.com/icons2/2699/PNG/512/bitcoin_logo_icon_170476.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 6,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Flow", "https://cdn-icons.flaticon.com/png/512/2601/premium/2601535.png?token=exp=1656192376~hmac=fe1377a44af00e7bc10b4642a96e1747" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 7,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "IOTA", "https://cdn-icons.flaticon.com/png/512/1185/premium/1185864.png?token=exp=1656192556~hmac=4a205f45f1ea45a43f96d79ee2993407" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 8,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Neo", "https://cdn.icon-icons.com/icons2/1386/PNG/512/neo-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95816.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 9,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Nexo", "https://cdn.icon-icons.com/icons2/2130/PNG/512/nexo_cryptocurrency_logo_icon_131417.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 10,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "NEM", "https://cdn-icons-png.flaticon.com/512/7745/7745718.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 1,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Bitcoin", "https://cdn.icon-icons.com/icons2/1487/PNG/512/8369-bitcoin_102502.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 2,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Ethereum", "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 3,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Litecoin", "https://cdn.icon-icons.com/icons2/2648/PNG/512/finance_litecoin_icon_160836.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 4,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Ripple", "https://cdn.icon-icons.com/icons2/3392/PNG/512/ripple_icon_213731.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 5,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Stellar", "https://cdn.icon-icons.com/icons2/3350/PNG/512/cryptocurrencies_stellar_coin_money_icon_210245.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 6,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Tether", "https://iconape.com/wp-content/files/ac/209643/png/tether-usdt-logo.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 7,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "EOS", "https://cdn.icon-icons.com/icons2/1384/PNG/512/eos-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95175.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 8,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Cardano", "https://cdn.icon-icons.com/icons2/3279/PNG/512/cardano_ada_coin_icon_208056.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 9,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Dash", "https://cdn.icon-icons.com/icons2/1386/PNG/512/dash-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95627.png" });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 10,
                columns: new[] { "Descripcion", "ImageUrl" },
                values: new object[] { "Zcash", "https://cdn.icon-icons.com/icons2/2699/PNG/512/zcash_logo_icon_169679.png" });
        }
    }
}
