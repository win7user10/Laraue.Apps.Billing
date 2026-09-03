namespace Laraue.Apps.Billing.Internal.Contracts.Subscription;

// `Apps.Boards`
// --> "Do I have active personal subscription?"
// --> `Apps.Billing`
// --> "Yes, you have. It has these parameters"
// --> | Returns typed subscription parameters |
public interface ISubscriptionService
{
    public Task<LaraueBoardsActiveSubscriptionResponse> GetActivePersonalSubscription(
        GetActivePersonalSubscriptionRequest request,
        CancellationToken cancellationToken);
}

public interface ILaraueBoardsSubscriptionService
{
    public Task<LaraueBoardsActiveSubscriptionResponse> GetActivePersonalSubscription(
        GetActivePersonalSubscriptionRequest request,
        CancellationToken cancellationToken);
}

public record LaraueBoardsActiveSubscriptionResponse : ActiveSubscriptionResponse
{
    public int LimitIssuesPerMonth { get; set; }
    public int LimitFreeTeamOrganizationsCount { get; set; }
}