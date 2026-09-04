namespace Laraue.Apps.Billing.DataAccess.Entities;

/// <summary>
/// Materialized token balances for service subscriptions.
/// </summary>
public class BalanceSubscriptionToken
{
    public Guid SubscriptionId { get; set; }
    public Subscription? Subscription { get; set; }
    
    public long FreeTokensCount { get; set; }
    public long SubscriptionTokensCount { get; set; }
}