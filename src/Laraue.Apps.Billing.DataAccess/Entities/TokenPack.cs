using System.ComponentModel.DataAnnotations;

namespace Laraue.Apps.Billing.DataAccess.Entities;

public class TokenPack
{
    public Guid Id { get; set; }
    
    [MaxLength(16)]
    public required string Code { get; set; }
    public long TokensCount { get; set; }
    public int Price { get; set; }
    public bool IsActive { get; set; }
    
    public TimeSpan ExpirationDuration { get; set; }
}