namespace Laraue.Apps.Billing.DataAccess;

public class PurchasedTokenPack
{
    public Guid Id { get; set; }
    
    public Guid PaidEntityId { get; set; }
    
    public Guid TokenPackId { get; set; }
    public TokenPack? TokenPack { get; set; }
    
    public DateTime PurchasedAt { get; set; }
    public DateTime ExpiredAt { get; set; }
}