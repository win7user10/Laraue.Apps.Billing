using Laraue.Apps.Billing.DataAccess.Data;
using Laraue.Apps.Billing.DataAccess.LaraueBoards;
using Laraue.Apps.Billing.DataAccess.MarkdownTranslator;
using Microsoft.EntityFrameworkCore;

namespace Laraue.Apps.Billing.DataAccess;

public class DatabaseContext : DbContext
{
    public required DbSet<LaraueBoardsPersonalTariff> LaraueBoardsPersonalTariffs { get; set; }
    public required DbSet<LaraueBoardsTeamTariff> LaraueBoardsTeamTariffs { get; set; }
    public required DbSet<MarkdownTranslatorPersonalTariff> MarkdownTranslatorPersonalTariffs { get; set; }
    public required DbSet<TokenPack> TokenPacks { get; set; }
    public required DbSet<CurrencyRate> CurrencyRates { get; set; }
    public required DbSet<Service> Services { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

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