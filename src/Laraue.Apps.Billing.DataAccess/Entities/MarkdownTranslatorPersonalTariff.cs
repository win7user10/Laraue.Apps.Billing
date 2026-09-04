namespace Laraue.Apps.Billing.DataAccess.Entities;

public class MarkdownTranslatorPersonalTariff
{
    public required TariffId Id { get; set; }
    public required long IncludedDailyFreeTokensCount { get; set; }
}