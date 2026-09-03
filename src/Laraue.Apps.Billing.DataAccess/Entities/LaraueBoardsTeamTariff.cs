namespace Laraue.Apps.Billing.DataAccess.Entities;

public class LaraueBoardsTeamTariff
{
    public required LaraueBoardsTeamTariffId Id { get; set; }
    public int? LimitIssuesPerMonth { get; set; }
    
    public Guid TariffId { get; set; }
    public Tariff? Tariff { get; set; }
}

public enum LaraueBoardsTeamTariffId
{
    TeamFree = 1,
    Team = 2,
    Business = 3,
}