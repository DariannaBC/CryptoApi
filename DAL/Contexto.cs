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
            new coin { MonedaId = 3, Descripcion = "Polygon", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/3373/PNG/512/polygon_icon_211236.png" }
        );
    }
}