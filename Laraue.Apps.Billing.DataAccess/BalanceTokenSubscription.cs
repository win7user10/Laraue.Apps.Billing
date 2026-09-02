namespace Laraue.Apps.Billing.DataAccess;

/// <summary>
/// Materialized token balances for service subscriptions.
/// </summary>
public class BalanceTokenSubscription
{
    public Guid SubscriptionId { get; set; }
    public Subscription? Subscription { get; set; }
    
    public long FreeTokensCount { get; set; }
    public long SubscriptionTokensCount { get; set; }
}