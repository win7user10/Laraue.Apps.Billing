namespace Laraue.Apps.Billing.DataAccess.Entities;

public class LaraueBoardsPersonalTariff
{
    public required TariffId Id { get; set; }
    public required int? LimitIssuesPerMonth { get; set; }
    public required int? LimitFreeTeamOrganizationsCount { get; set; }
}