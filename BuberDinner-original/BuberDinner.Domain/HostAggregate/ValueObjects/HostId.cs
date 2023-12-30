using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.UserAggregate.ValueObjects;

namespace BuberDinner.Domain.HostAggregate.ValueObjects;

public sealed class HostId : AggregateRootId<string>
{
    public override string Value { get; protected set; }

    private HostId(string value)
    {
        Value = value;
    }

    public static HostId Create(UserId userId)
    {
        // TODO: enforce invariants
        return new HostId($"Host_{userId.Value}");
    }

    public static HostId Create(string hostId)
    {
        // TODO: enforce invariants
        return new HostId(hostId);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

#pragma warning disable CS8618
    private HostId()
    {
    }
#pragma warning restore CS8618
}