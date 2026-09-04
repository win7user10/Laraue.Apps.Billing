namespace Laraue.Apps.Billing.DataAccess.Entities;

public class LaraueBoardsTeamTariff
{
    public required TariffId Id { get; set; }
    public required int? LimitIssuesPerMonth { get; set; }
}