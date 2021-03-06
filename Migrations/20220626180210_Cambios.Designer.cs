// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220626180210_Cambios")]
    partial class Cambios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("coin", b =>
                {
                    b.Property<int>("MonedaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("MonedaId");

                    b.ToTable("Coins");

                    b.HasData(
                        new
                        {
                            MonedaId = 1,
                            Descripcion = "Bitcoin Cash",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/bitcoin_cryptocurrency_coin_money_icon_210978.png",
                            Valor = 8100.0
                        },
                        new
                        {
                            MonedaId = 2,
                            Descripcion = "Dai",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/2130/PNG/512/dai_cryptocurrency_logo_icon_131454.png",
                            Valor = 8100.0
                        },
                        new
                        {
                            MonedaId = 3,
                            Descripcion = "Polygon",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/3373/PNG/512/polygon_icon_211236.png",
                            Valor = 8100.0
                        },
                        new
                        {
                            MonedaId = 4,
                            Descripcion = "Litecoin",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/2699/PNG/512/litecoin_logo_icon_170221.png",
                            Valor = 8100.0
                        },
                        new
                        {
                            MonedaId = 5,
                            Descripcion = "WEMIX",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/2699/PNG/512/bitcoin_logo_icon_170476.png",
                            Valor = 8100.0
                        },
                        new
                        {
                            MonedaId = 6,
                            Descripcion = "Flow",
                            ImageUrl = "https://cdn-icons.flaticon.com/png/512/2601/premium/2601535.png?token=exp=1656192376~hmac=fe1377a44af00e7bc10b4642a96e1747",
                            Valor = 8100.0
                        },
                        new
                        {
                            MonedaId = 7,
                            Descripcion = "IOTA",
                            ImageUrl = "https://cdn-icons.flaticon.com/png/512/1185/premium/1185864.png?token=exp=1656192556~hmac=4a205f45f1ea45a43f96d79ee2993407",
                            Valor = 8100.0
                        },
                        new
                        {
                            MonedaId = 8,
                            Descripcion = "Neo",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/neo-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95816.png",
                            Valor = 8100.0
                        },
                        new
                        {
                            MonedaId = 9,
                            Descripcion = "Nexo",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/2130/PNG/512/nexo_cryptocurrency_logo_icon_131417.png",
                            Valor = 8100.0
                        },
                        new
                        {
                            MonedaId = 10,
                            Descripcion = "NEM",
                            ImageUrl = "https://cdn-icons-png.flaticon.com/512/7745/7745718.png",
                            Valor = 8100.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
