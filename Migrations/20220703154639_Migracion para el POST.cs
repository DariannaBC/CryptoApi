using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoApi.Migrations
{
    public partial class MigracionparaelPOST : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 1, "Bitcoin Cash", "https://cdn.icon-icons.com/icons2/3369/PNG/512/bitcoin_cryptocurrency_coin_money_icon_210978.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 2, "Dai", "https://cdn.icon-icons.com/icons2/2130/PNG/512/dai_cryptocurrency_logo_icon_131454.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 3, "Polygon", "https://cdn.icon-icons.com/icons2/3373/PNG/512/polygon_icon_211236.png", 8100.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "MonedaId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 1, "Bitcoin Cash", "https://cdn.icon-icons.com/icons2/3369/PNG/512/bitcoin_cryptocurrency_coin_money_icon_210978.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 2, "Dai", "https://cdn.icon-icons.com/icons2/2130/PNG/512/dai_cryptocurrency_logo_icon_131454.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 3, "Polygon", "https://cdn.icon-icons.com/icons2/3373/PNG/512/polygon_icon_211236.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 4, "Litecoin", "https://cdn.icon-icons.com/icons2/2699/PNG/512/litecoin_logo_icon_170221.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 5, "WEMIX", "https://cdn.icon-icons.com/icons2/2699/PNG/512/bitcoin_logo_icon_170476.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 6, "Flow", "https://cdn-icons.flaticon.com/png/512/2601/premium/2601535.png?token=exp=1656192376~hmac=fe1377a44af00e7bc10b4642a96e1747", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 7, "IOTA", "https://cdn-icons.flaticon.com/png/512/1185/premium/1185864.png?token=exp=1656192556~hmac=4a205f45f1ea45a43f96d79ee2993407", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 8, "Neo", "https://cdn.icon-icons.com/icons2/1386/PNG/512/neo-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95816.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 9, "Nexo", "https://cdn.icon-icons.com/icons2/2130/PNG/512/nexo_cryptocurrency_logo_icon_131417.png", 8100.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 10, "NEM", "https://cdn-icons-png.flaticon.com/512/7745/7745718.png", 8100.0 });
        }
    }
}
