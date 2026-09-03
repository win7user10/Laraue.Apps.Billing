namespace Laraue.Apps.Billing.Internal.Contracts.Tokens;

public interface ITokenService
{
    Task<ReservationResult> TryReserveTokens(
        ReserveTokensRequest request,
        CancellationToken cancellationToken);
}

public record ReserveTokensRequest
{
    public int InputTokensCount { get; init; }
    public int OutputTokensCount { get; init; }
}

public record ReservationResult
{
    public Guid TokenTransactionId { get; set; }
    public ReservationStatus Status { get; set; }
}

public enum ReservationStatus
{
    Success,
    Failed,
}