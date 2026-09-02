namespace Laraue.Apps.Billing.DataAccess;

public class TokenSpentSubscriptionTokenPack
{
    public Guid Id { get; set; }
    
    public long SubscriptionId { get; set; }
    public Subscription? Subscription { get; set; }
    
    public long? FreeAmount { get; set; }
    public long? Amount { get; set; }
}