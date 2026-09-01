using Laraue.Apps.Billing.DataAccess.MarkdownTranslator;

namespace Laraue.Apps.Billing.DataAccess.Data;

public static class MarkdownTranslatorTariffsData
{
    private const long IncludedDailyFreeTokensCount = 10_000;
    
    private static readonly MarkdownTranslatorPersonalTariff Free = new()
    {
        Id = new Guid("76ABD692-C450-4CD6-80E4-B9C012D91610"),
        BillingPeriod = BillingPeriod.Monthly,
        IsActive = true,
        Code = "free",
        IncludedDailyFreeTokensCount = IncludedDailyFreeTokensCount,
    };
    
    private static readonly MarkdownTranslatorPersonalTariff Plus = new()
    {
        Id = new Guid("03F6F9C3-C068-4AFF-9ACD-4499994D6874"),
        BillingPeriod = BillingPeriod.Monthly,
        IsActive = true,
        Code = "plus",
        IncludedDailyFreeTokensCount = IncludedDailyFreeTokensCount,
        IncludedTokensCount = 300_000,
        Price = 4_00,
    };
    
    private static readonly MarkdownTranslatorPersonalTariff Pro = new()
    {
        Id = new Guid("F639FC54-9F6F-4E4F-8F5C-834176700495"),
        BillingPeriod = BillingPeriod.Monthly,
        IsActive = true,
        Code = "pro",
        IncludedDailyFreeTokensCount = IncludedDailyFreeTokensCount,
        IncludedTokensCount = 1_200_000,
        Price = 10_00,
    };

    public static readonly MarkdownTranslatorPersonalTariff[] PersonalTariffs =
    [
        Free,
        Plus,
        Pro,
    ];
}