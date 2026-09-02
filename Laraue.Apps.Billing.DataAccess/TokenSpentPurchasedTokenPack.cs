namespace Laraue.Apps.Billing.DataAccess;

public class TokenSpentPurchasedTokenPack
{
    public long Id { get; set; }
    
    public Guid PurchasedTokenPackId { get; set; }
    public PurchasedTokenPack? PurchasedTokenPack { get; set; }
    
    public long Amount { get; set; }
}