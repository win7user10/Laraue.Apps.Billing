namespace Laraue.Apps.Billing.Internal.Contracts.Subscription;

public abstract record GetActivePersonalSubscriptionRequest : GetActiveSubscriptionRequest
{
    public Guid UserId { get; set; }
}