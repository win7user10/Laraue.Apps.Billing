namespace Laraue.Apps.Billing.DataAccess.MarkdownTranslator;

public class MarkdownTranslatorPersonalTariff : BasePersonalTariff<MarkdownTranslatorTariffCode>
{
    public long IncludedDailyFreeTokensCount { get; set; }
}