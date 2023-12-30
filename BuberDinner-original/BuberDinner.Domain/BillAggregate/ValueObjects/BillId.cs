using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.GuestAggregate.ValueObjects;

namespace BuberDinner.Domain.BillAggregate.ValueObjects;

public sealed class BillId : AggregateRootId<string>
{
    public override string Value { get; protected set; }

    private BillId(string value)
    {
        Value = value;
    }

    private BillId(DinnerId dinnerId, GuestId guestId)
    {
        Value = $"Bill_{dinnerId.Value}_{guestId.Value}";
    }

    public static BillId Create(DinnerId dinnerId, GuestId guestId)
    {
        return new BillId(dinnerId, guestId);
    }

    public static BillId Create(string value)
    {
        return new BillId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

#pragma warning disable CS8618
    private BillId()
    {
    }
#pragma warning restore CS8618
}