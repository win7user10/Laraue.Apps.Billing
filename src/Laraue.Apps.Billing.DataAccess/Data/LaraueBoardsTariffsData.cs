using Laraue.Apps.Billing.DataAccess.Entities;

namespace Laraue.Apps.Billing.DataAccess.Data;

public static class LaraueBoardsTariffsData
{
    private static readonly LaraueBoardsPersonalTariff PersonalFree = new()
    {
        Id = LaraueBoardsPersonalTariffId.PersonalFree,
        Tariff = new Tariff
        {
            Id = new Guid("D249838E-40A5-42DD-850E-6BB040DBD8D4"),
            BillingPeriod = BillingPeriod.Monthly,
            IsActive = true,
            Code = "personal_free",
        },
        LimitIssuesPerMonth = 500,
        LimitFreeTeamOrganizationsCount = 1,
    };

    private static readonly LaraueBoardsPersonalTariff PersonalPlus = new()
    {
        Id = LaraueBoardsPersonalTariffId.PersonalPlus,
        Tariff = new Tariff
        {
            Id = new Guid("3D6F8907-7091-4F3D-82F3-4DA626F3BEE8"),
            BillingPeriod = BillingPeriod.Monthly,
            Price = 4_00,
            IncludedTokensCount = 300_000,
            IsActive = true,
            Code = "personal_plus",
        },
        LimitIssuesPerMonth = 50_000,
    };

    private static readonly LaraueBoardsTeamTariff TeamFree = new()
    {
        Id = LaraueBoardsTeamTariffId.TeamFree,
        Tariff = new Tariff
        {
            Id = new Guid("39D48998-7911-4227-A6F8-4EB9BBD0C194"),
            BillingPeriod = BillingPeriod.Monthly,
            IsActive = true,
            Code = "team_free",
        },
        LimitIssuesPerMonth = 500,
    };

    private static readonly LaraueBoardsTeamTariff Team = new()
    {
        Id = LaraueBoardsTeamTariffId.Team,
        Tariff = new Tariff
        {
            Id = new Guid("A6981754-EB8D-4CDE-BEA6-F47C7890F291"),
            Price = 6_00,
            BillingPeriod = BillingPeriod.Monthly,
            IncludedTokensCount = 750_000,
            IsActive = true,
            Code = "team",
        },
        LimitIssuesPerMonth = 50_000,
    };

    private static readonly LaraueBoardsTeamTariff TeamBusiness = new()
    {
        Id = LaraueBoardsTeamTariffId.Business,
        Tariff = new Tariff
        {
            Id = new Guid("AC3EE4FC-2D8E-4E34-8A0A-F6B60E0F0B3A"),
            Price = 14_00,
            BillingPeriod = BillingPeriod.Monthly,
            IncludedTokensCount = 2_500_000,
            IsActive = true,
            Code = "team_business",
        },
        LimitIssuesPerMonth = 200_000,
    };

    public static readonly LaraueBoardsTeamTariff[] TeamTariffs =
    [
        TeamFree,
        Team,
        TeamBusiness
    ];
    

    public static readonly LaraueBoardsPersonalTariff[] PersonalTariffs =
    [
        PersonalFree,
        PersonalPlus,
    ];
}