namespace Laraue.Apps.Billing.DataAccess;

public class BoardTariff
{
    public BoardTariffId Id { get; set; }
    
    public Guid TariffId { get; set; }
    public Tariff? Tariff { get; set; }
    
    public BoardLimits? Limits { get; set; }
}

public enum BoardTariffId
{
    PersonalFree,
    PersonalPlus,
    TeamFree,
    TeamBusiness,
}

public class BoardLimits
{
    public int IssuesPerMonth { get; set; }
    public int FreeOrganizationsPerOwner { get; set; }
}