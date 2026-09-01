namespace Laraue.Apps.Billing.DataAccess.MarkdownTranslator;

public class MarkdownTranslatorPersonalTariff
{
    public MarkdownTranslatorPersonalTariffId Id { get; set; }
    public long IncludedDailyFreeTokensCount { get; set; }
    
    public Guid TariffId { get; set; }
    public Tariff? Tariff { get; set; }
}

public enum MarkdownTranslatorPersonalTariffId
{
    Free = 1,
    Plus = 2,
    Pro = 3,
}