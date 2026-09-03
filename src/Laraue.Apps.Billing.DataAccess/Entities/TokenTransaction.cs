namespace Laraue.Apps.Billing.DataAccess.Entities;

public class TokenTransaction
{
    public Guid Id { get; set; }
    
    public Guid PaidEntityId { get; set; }
    public Guid OwnerId { get; set; }
    
    public TokenSpentStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? FinishedAt { get; set; }
    public long Delta { get; set; }
    
    public TokenTransactionReason Reason { get; set; }
    
    public TokenTransactionSubscriptionTokenPack? SubscriptionTokensSpent { get; set; }
    public IList<TokenTransactionPurchasedTokenPack>? PurchasedTokensSpent { get; set; }
}

public enum TokenSpentStatus
{
    Started,
    Canceled,
    Confirmed,
}

public enum TokenTransactionReason
{
    /// <summary>
    /// Tariff has been bought and included tokens added.
    /// </summary>
    TariffGrant,
    
    /// <summary>
    /// Free daily tokens added.
    /// </summary>
    DailyGrant,
    
    /// <summary>
    /// Tokens have been bought manually.
    /// </summary>
    Purchase,
    
    /// <summary>
    /// Tokens have been expired.
    /// </summary>
    Expiry,
}