namespace Laraue.Apps.Billing.DataAccess;

public class TokenTransactionPurchasedTokenPack
{
    public long Id { get; set; }
    
    public Guid PurchasedTokenPackId { get; set; }
    public PurchasedTokenPack? PurchasedTokenPack { get; set; }
    
    public long ChargedAmount { get; set; }
    public long BalanceAfter { get; set; }
}