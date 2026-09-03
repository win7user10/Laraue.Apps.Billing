using Laraue.Apps.Billing.DataAccess.Data;
using Laraue.Apps.Billing.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Laraue.Apps.Billing.DataAccess;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) 
        : base(options)
    {
    }
    
    #region Tariffs

    public required DbSet<LaraueBoardsPersonalTariff> LaraueBoardsPersonalTariffs { get; set; }
    public required DbSet<LaraueBoardsTeamTariff> LaraueBoardsTeamTariffs { get; set; }
    public required DbSet<MarkdownTranslatorPersonalTariff> MarkdownTranslatorPersonalTariffs { get; set; }
    public required DbSet<TokenPack> TokenPacks { get; set; }
    public required DbSet<CurrencyRate> CurrencyRates { get; set; }
    public required DbSet<Service> Services { get; set; }

    #endregion

    #region Balance & Transactions

    public required DbSet<Subscription> Subscriptions { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>()
            .HasData(ServicesData.Services);

        modelBuilder.Entity<LaraueBoardsPersonalTariff>()
            .HasData(LaraueBoardsTariffsData.PersonalTariffs);
        
        modelBuilder.Entity<LaraueBoardsTeamTariff>()
            .HasData(LaraueBoardsTariffsData.TeamTariffs);
        
        modelBuilder.Entity<MarkdownTranslatorPersonalTariff>()
            .HasData(MarkdownTranslatorTariffsData.PersonalTariffs);
        
        modelBuilder.Entity<TokenPack>()
            .HasData(TokenPacksData.Packs);
        
        modelBuilder.Entity<CurrencyRate>()
            .HasData(CurrencyRatesData.CurrencyRates);
    }
}