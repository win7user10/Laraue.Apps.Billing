namespace Laraue.Apps.Billing.Internal.Contracts.Subscription;

public abstract record ActiveSubscriptionResponse
{
    public required string Code { get; set; }
}