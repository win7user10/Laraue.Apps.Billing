namespace Laraue.Apps.Billing.DataAccess;

public class MarkdownTranslatorTariff
{
    public MarkdownTranslatorTariffId Id { get; set; }
    
    public Guid TariffId { get; set; }
    public Tariff? Tariff { get; set; }
}

public enum MarkdownTranslatorTariffId
{
    Free,
    Plus,
    Pro,
}