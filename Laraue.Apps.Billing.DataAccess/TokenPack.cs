namespace Laraue.Apps.Billing.DataAccess;

public class TokenPack
{
    public Guid Id { get; set; }
    public required string Code { get; set; }
    public long TokensCount { get; set; }
    public int Price { get; set; }
    public bool IsActive { get; set; }
}