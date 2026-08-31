using Laraue.Apps.Billing.DataAccess.Boards;
using Laraue.Apps.Billing.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Laraue.Apps.Billing.DataAccess;

public class DatabaseContext : DbContext
{
    public required DbSet<LaraueBoardsPersonalTariff> LaraueBoardsPersonalTariffs { get; set; }
    public required DbSet<LaraueBoardsTeamTariff> LaraueBoardsTeamTariffs { get; set; }
    public required DbSet<Service> Services { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Service>()
            .HasData(
                ServicesSource.Boards,
                ServicesSource.MarkdownTranslator);

        modelBuilder.Entity<LaraueBoardsPersonalTariff>()
            .HasData(LaraueBoardsTariffs.PersonalTariffs);
        
        modelBuilder.Entity<LaraueBoardsTeamTariff>()
            .HasData(LaraueBoardsTariffs.TeamTariffs);
    }
}