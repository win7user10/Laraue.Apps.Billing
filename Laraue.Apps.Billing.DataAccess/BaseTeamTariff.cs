namespace Laraue.Apps.Billing.DataAccess;

public abstract class BaseTeamTariff<TLocalId> : BaseTariff<TLocalId>
    where TLocalId : struct, Enum 
{
}