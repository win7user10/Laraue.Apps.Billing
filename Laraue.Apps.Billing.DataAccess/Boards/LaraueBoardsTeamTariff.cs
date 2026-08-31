namespace Laraue.Apps.Billing.DataAccess.Boards;

public class LaraueBoardsTeamTariff : BaseTeamTariff<LaraueBoardsTariffCode>
{
    public int? LimitIssuesPerMonth { get; set; }
}