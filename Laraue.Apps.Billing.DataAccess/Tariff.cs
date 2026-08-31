namespace Laraue.Apps.Billing.DataAccess;

public class Tariff
{
    public Guid Id { get; set; }
    
    public Guid ServiceId { get; set; }
    public Service? Service { get; set; }
    
    public bool SeatBased { get; set; }
    
    public int PriceCents { get; set; }
    public BillingPeriod BillingPeriod { get; set; }
    
    public long IncludedTokens { get; set; }
    public long? DailyFreeTokens { get; set; }
    
    public bool IsActive { get; set; } 
}

public enum BillingPeriod
{
    Monthly,
}