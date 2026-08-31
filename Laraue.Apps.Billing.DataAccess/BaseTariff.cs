namespace Laraue.Apps.Billing.DataAccess;

public class BaseTariff<TTariffCode> where TTariffCode : struct, Enum
{
    public Guid Id { get; set; }
    public TTariffCode Code { get; set; }
    
    public Guid ServiceId { get; set; }
    public Service? Service { get; set; }
    public int Price { get; set; }
    public BillingPeriod BillingPeriod { get; set; }
    public long IncludedTokensCount { get; set; }
    public bool IsActive { get; set; }
}

public enum BillingPeriod
{
    Monthly,
}

public enum TariffType
{
    Personal,
    Team,
}