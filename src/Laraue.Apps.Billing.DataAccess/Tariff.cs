using System.ComponentModel.DataAnnotations;

namespace Laraue.Apps.Billing.DataAccess;

public class Tariff
{
    public required Guid Id { get; set; }
    
    [MaxLength(16)]
    public required string Code { get; set; }
    public int Price { get; set; }
    public required BillingPeriod BillingPeriod { get; set; }
    public long IncludedTokensCount { get; set; }
    public required bool IsActive { get; set; }
    
    public TariffType Type { get; set; }
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