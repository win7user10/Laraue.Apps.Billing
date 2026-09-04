namespace Laraue.Apps.Billing.DataAccess.Entities;

public class TokenTransactionSubscriptionTokenPack
{
    public Guid Id { get; set; }
    
    public Guid SubscriptionId { get; set; }
    public Subscription? Subscription { get; set; }
    
    public long? ChargedFreeAmount { get; set; }
    public long? ChargedAmount { get; set; }
}