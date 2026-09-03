namespace Laraue.Apps.Billing.Internal.Contracts.Subscription;

public abstract record GetActiveSubscriptionRequest
{
    public Guid ServiceId { get; set; }
}