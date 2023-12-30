using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.MenuAggregate.ValueObjects;

public sealed class MenuSectionId : ValueObject
{
    public MenuSectionId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; private set; }

    public static MenuSectionId CreateUnique()
    {
        // TODO: enforce invariants
        return new MenuSectionId(Guid.NewGuid());
    }

    public static MenuSectionId Create(Guid value)
    {
        // TODO: enforce invariants
        return new MenuSectionId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

#pragma warning disable CS8618
    private MenuSectionId()
    {
    }
#pragma warning restore CS8618
}