using Laraue.Apps.Billing.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Laraue.Apps.Billing.DataAccess;

public class DatabaseContext : DbContext
{
    public required DbSet<Tariff> Tariffs { get; set; }
    public required DbSet<Service> Services { get; set; }
    public required DbSet<BoardTariff> BoardTariffs { get; set; }
    public required DbSet<MarkdownTranslatorTariff> MarkdownTranslatorTariffs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Service>()
            .HasData(
                ServicesSource.Boards,
                ServicesSource.MarkdownTranslator);
    }
}