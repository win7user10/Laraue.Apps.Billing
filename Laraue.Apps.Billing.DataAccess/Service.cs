using System.ComponentModel.DataAnnotations;

namespace Laraue.Apps.Billing.DataAccess;

public class Service
{
    public Guid Id { get; set; }
    
    [MaxLength(16)]
    public required string Code { get; set; }
    
    [MaxLength(32)]
    public required string Name { get; set; }
}