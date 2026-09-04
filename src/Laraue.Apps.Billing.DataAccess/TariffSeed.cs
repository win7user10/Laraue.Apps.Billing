using Laraue.Apps.Billing.DataAccess.Entities;

namespace Laraue.Apps.Billing.DataAccess;

public class TariffSeed<TSeedEntity>(Tariff tariff, TSeedEntity entity)
{
    public Tariff Tariff { get; } = tariff;
    public TSeedEntity Entity { get; } = entity;
}