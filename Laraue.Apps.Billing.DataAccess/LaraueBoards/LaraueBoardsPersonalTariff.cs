namespace Laraue.Apps.Billing.DataAccess.LaraueBoards;

public class LaraueBoardsPersonalTariff : BasePersonalTariff<LaraueBoardsTariffCode>
{
    public int? LimitIssuesPerMonth { get; set; }
    public int? LimitFreeTeamOrganizationsCount { get; set; }
}