namespace Laraue.Apps.Billing.DataAccess.Data;

public static class TariffsSource
{
    public static BoardTariff PersonalFree = new()
    {
        Id = BoardTariffId.PersonalFree,
        Tariff = new Tariff
        {
            Id = new Guid("D249838E-40A5-42DD-850E-6BB040DBD8D4"),
            Service = ServicesSource.Boards,
            SeatBased = false,
            PriceCents = 0,
            BillingPeriod = BillingPeriod.Monthly,
            IncludedTokens = 0,
            DailyFreeTokens = null,
            IsActive = true
        },
        Limits = new BoardLimits
        {
            IssuesPerMonth = 1200,
            FreeOrganizationsPerOwner = 1,
        },
    };
    
    public static BoardTariff PersonalPlus = new()
    {
        Id = BoardTariffId.PersonalPlus,
        Tariff = new Tariff
        {
            Id = new Guid("3D6F8907-7091-4F3D-82F3-4DA626F3BEE8"),
            Service = ServicesSource.Boards,
            SeatBased = false,
            PriceCents = 500,
            BillingPeriod = BillingPeriod.Monthly,
            IncludedTokens = 300_000,
            DailyFreeTokens = null,
            IsActive = true
        }
    };
}