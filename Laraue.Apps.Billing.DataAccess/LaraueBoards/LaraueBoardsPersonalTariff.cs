namespace Laraue.Apps.Billing.DataAccess.LaraueBoards;

public class LaraueBoardsPersonalTariff : BasePersonalTariff
{
    public int? LimitIssuesPerMonth { get; set; }
    public int? LimitFreeTeamOrganizationsCount { get; set; }
}