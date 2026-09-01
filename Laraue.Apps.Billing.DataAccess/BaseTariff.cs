namespace Laraue.Apps.Billing.DataAccess;

public class BaseTariff
{
    public required Guid Id { get; set; }
    public required string Code { get; set; }
    public int Price { get; set; }
    public required BillingPeriod BillingPeriod { get; set; }
    public long IncludedTokensCount { get; set; }
    public required bool IsActive { get; set; }
}

public enum BillingPeriod
{
    Monthly,
}