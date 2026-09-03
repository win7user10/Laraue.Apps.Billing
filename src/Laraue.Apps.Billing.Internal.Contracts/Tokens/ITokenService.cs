using System.ComponentModel.DataAnnotations;

namespace Laraue.Apps.Billing.Internal.Contracts.Tokens;

// `Apps.Boards`
// --> "I want to reserve tokens for transaction"
// --> `Apps.Billing`
// --> "It's okay. Reservation is successful. Take the transaction Guid. Or error description."
// --> `Apps.Boards`
// --> "Okay. Money is reserved. I can start operation"
// --> | Execute operation |
// --> "We need to commit withdrawal. Actual spent: 720 of 2048 reserved"
// --> `Apps.Billing`
// --> "Commit the transaction: it changes status and updates balances in balances views"

public interface ITokenService
{
    Task<ReservationResult> TryReserveTokens(
        ReserveTokensRequest request,
        CancellationToken cancellationToken);
    
    Task CommitTokensSpent(
        CommitTokensSpentRequest request,
        CancellationToken cancellationToken);
    
    Task CancelTokensReservation(
        CancelTokensReservationRequest request,
        CancellationToken cancellationToken);
}

public record ReserveTokensRequest
{
    public int InputTokensCount { get; init; }
    public int MaxOutputTokensCount { get; init; }
}

public record ReservationResult
{
    public Guid? TokenTransactionId { get; set; }
    public string? Error { get; set; }
}

public record CommitTokensSpentRequest
{
    public Guid TokenTransactionId { get; set; }
    public int ActualOutputTokensCount { get; init; }
}

public record CancelTokensReservationRequest
{
    public Guid TokenTransactionId { get; set; }
    
    [MaxLength(32)]
    public required string Error { get; set; }
}
