namespace Laraue.Apps.Billing.DataAccess.LaraueBoards;

public class LaraueBoardsTeamTariff : BaseTeamTariff<LaraueBoardsTariffCode>
{
    public int? LimitIssuesPerMonth { get; set; }
}