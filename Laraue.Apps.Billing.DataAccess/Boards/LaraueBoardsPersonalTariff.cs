namespace Laraue.Apps.Billing.DataAccess.Boards;

public class LaraueBoardsPersonalTariff : BasePersonalTariff<LaraueBoardsTariffCode>
{
    public int? LimitIssuesPerMonth { get; set; }
    public int? LimitFreeTeamOrganizationsCount { get; set; }
}