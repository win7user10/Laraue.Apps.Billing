namespace Laraue.Apps.Billing.DataAccess.Entities;

public class LaraueBoardsPersonalTariff
{
    public required LaraueBoardsPersonalTariffId Id { get; set; }
    
    public int? LimitIssuesPerMonth { get; set; }
    public int? LimitFreeTeamOrganizationsCount { get; set; }
    
    public Guid TariffId { get; set; }
    public Tariff? Tariff { get; set; }
}

public enum LaraueBoardsPersonalTariffId
{
    PersonalFree = 1,
    PersonalPlus = 2,
}