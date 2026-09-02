namespace Laraue.Apps.Billing.DataAccess;

public class TokenSpent
{
    public Guid Id { get; set; }
    
    public Guid PaidEntityId { get; set; }
    public Guid OwnerId { get; set; }
    
    public TokenSpentStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? FinishedAt { get; set; }
    public long TotalAmount { get; set; }
    
    public TokenSpentSubscriptionTokenPack? SubscriptionTokensSpent { get; set; }
    public IList<TokenSpentPurchasedTokenPack>? PurchasedTokensSpent { get; set; }
}

public enum TokenSpentStatus
{
    Started,
    Canceled,
    Confirmed,
}