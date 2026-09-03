using System.ComponentModel.DataAnnotations;

namespace Laraue.Apps.Billing.DataAccess;

public class Service
{
    public ServiceId Id { get; set; }
    
    [MaxLength(16)]
    public required string Code { get; set; }
    
    [MaxLength(32)]
    public required string Name { get; set; }
}

public enum ServiceId
{
    LaraueBoards = 1,
    MarkdownTranslator = 2,
}