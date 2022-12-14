using APIBdPickTheWinner.Domain;
using Microsoft.EntityFrameworkCore;

namespace APIBdPickTheWinner.Contexts;

public class Context : DbContext
{
    public virtual DbSet<User> User { get; set; }

    public virtual DbSet<CupMatch> CupMatch { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasData(
                new User
                {
                    IdUser = 1,
                    Name = "admin",
                    Email = "admin@gmail.com",
                    Password = "admin",
                    FavoriteCountry = "Brasil"
                },
                new User
                {
                    IdUser = 2,
                    Name = "Usuário 2",
                    Email = "cliente@gmail.com",
                    Password = "cliente",
                    FavoriteCountry = "Croatia"
                });

            entity.HasIndex(u => u.Email).IsUnique();
        });

        modelBuilder.Entity<CupMatch>().HasData(
        new CupMatch
        {
            IdMatch = 1,
            FirstCountry = "Brazil",
            FirstCountryScore = 1,
            SecondCountry = "Croácia",
            SecondCountryScore = 1
        },
        new CupMatch
        {
            IdMatch = 2,
            FirstCountry = "Portugal",
            FirstCountryScore = 0,
            SecondCountry = "Marrocos",
            SecondCountryScore = 1
        });

        base.OnModelCreating(modelBuilder);
    }
}
