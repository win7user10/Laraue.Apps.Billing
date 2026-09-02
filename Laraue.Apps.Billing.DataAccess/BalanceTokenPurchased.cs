namespace Laraue.Apps.Billing.DataAccess;

/// <summary>
/// Materialized token balances for purchased token packs.
/// </summary>
public class BalanceTokenPurchased
{
    /// <summary>
    ///  User or organization id.
    /// </summary>
    public Guid PaidEntityId { get; set; }
    
    /// <summary>
    /// Current tokens remained.
    /// </summary>
    public long Balance { get; set; }
}