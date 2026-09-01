namespace Laraue.Apps.Billing.DataAccess.LaraueBoards;

public static class LaraueBoardsTariffs
{
    private static readonly LaraueBoardsPersonalTariff PersonalFree = new()
    {
        Id = new Guid("D249838E-40A5-42DD-850E-6BB040DBD8D4"),
        BillingPeriod = BillingPeriod.Monthly,
        LimitIssuesPerMonth = 500,
        LimitFreeTeamOrganizationsCount = 1,
        IsActive = true,
        Code = LaraueBoardsTariffCode.PersonalFree,
    };

    private static readonly LaraueBoardsPersonalTariff PersonalPlus = new()
    {
        Id = new Guid("3D6F8907-7091-4F3D-82F3-4DA626F3BEE8"),
        BillingPeriod = BillingPeriod.Monthly,
        Price = 4_00,
        LimitIssuesPerMonth = 50_000,
        IncludedTokensCount = 300_000,
        IsActive = true,
        Code = LaraueBoardsTariffCode.PersonalPlus,
    };

    private static readonly LaraueBoardsTeamTariff TeamFree = new()
    {
        Id = new Guid("39D48998-7911-4227-A6F8-4EB9BBD0C194"),
        BillingPeriod = BillingPeriod.Monthly,
        LimitIssuesPerMonth = 500,
        IsActive = true,
        Code = LaraueBoardsTariffCode.TeamFree,
    };

    private static readonly LaraueBoardsTeamTariff Team = new()
    {
        Id = new Guid("A6981754-EB8D-4CDE-BEA6-F47C7890F291"),
        Price = 6_00,
        BillingPeriod = BillingPeriod.Monthly,
        IncludedTokensCount = 750_000,
        LimitIssuesPerMonth = 50_000,
        IsActive = true,
        Code = LaraueBoardsTariffCode.Team,
    };

    private static readonly LaraueBoardsTeamTariff TeamBusiness = new()
    {
        Id = new Guid("AC3EE4FC-2D8E-4E34-8A0A-F6B60E0F0B3A"),
        Price = 14_00,
        BillingPeriod = BillingPeriod.Monthly,
        IncludedTokensCount = 2_500_000,
        LimitIssuesPerMonth = 200_000,
        IsActive = true,
        Code = LaraueBoardsTariffCode.TeamBusiness,
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