namespace Laraue.Apps.Billing.Internal.Contracts.Subscription;

public abstract record GetActiveOrganizationSubscriptionRequest : GetActiveSubscriptionRequest
{
    public Guid OrganizationId { get; set; }
}