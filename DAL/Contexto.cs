using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<coin> Coins { get; set; }
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<coin>().HasData(
            new coin { MonedaId = 1, Descripcion = "Bitcoin Cash", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/bitcoin_cryptocurrency_coin_money_icon_210978.png" },
            new coin { MonedaId = 2, Descripcion = "Dai", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/2130/PNG/512/dai_cryptocurrency_logo_icon_131454.png" },
            new coin { MonedaId = 3, Descripcion = "Polygon", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/3373/PNG/512/polygon_icon_211236.png" },
            new coin { MonedaId = 4, Descripcion = "Litecoin", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/2699/PNG/512/litecoin_logo_icon_170221.png" },
            new coin { MonedaId = 5, Descripcion = "WEMIX", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/2699/PNG/512/bitcoin_logo_icon_170476.png" },
            new coin { MonedaId = 6, Descripcion = "Flow", Valor = 8100, ImageUrl = "https://cdn-icons.flaticon.com/png/512/2601/premium/2601535.png?token=exp=1656192376~hmac=fe1377a44af00e7bc10b4642a96e1747" },
            new coin { MonedaId = 7, Descripcion = "IOTA", Valor = 8100, ImageUrl = "https://cdn-icons.flaticon.com/png/512/1185/premium/1185864.png?token=exp=1656192556~hmac=4a205f45f1ea45a43f96d79ee2993407" },
            new coin { MonedaId = 8, Descripcion = "Neo", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/neo-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95816.png" },
            new coin { MonedaId = 9, Descripcion = "Nexo", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/2130/PNG/512/nexo_cryptocurrency_logo_icon_131417.png" },
            new coin { MonedaId = 10, Descripcion = "NEM", Valor = 8100, ImageUrl = "https://cdn-icons-png.flaticon.com/512/7745/7745718.png" }
        );
    }
}