namespace Laraue.Apps.Billing.DataAccess;

public class TokenLedger
{
    public Guid Id { get; set; }
    
    public TokenLedgerStatus Status { get; set; }
    
    public long Amount { get; set; }
}

public enum TokenLedgerStatus
{
    Started,
    Canceled,
    Confirmed,
}