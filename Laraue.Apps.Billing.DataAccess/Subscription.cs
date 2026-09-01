namespace Laraue.Apps.Billing.DataAccess;

public class Subscription
{
    public required Guid Id { get; set; }
    
    public Guid ServiceId { get; set; }
    public Service? Service { get; set; }
    
    public Guid TariffId { get; set; }
    public Tariff? Tariff { get; set; }
}