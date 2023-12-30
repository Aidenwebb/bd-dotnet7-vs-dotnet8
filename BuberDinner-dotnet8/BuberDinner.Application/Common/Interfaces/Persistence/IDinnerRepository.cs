using BuberDinner.Domain.DinnerAggregate;
using BuberDinner.Domain.HostAggregate.ValueObjects;

namespace BuberDinner.Application.Common.Interfaces.Persistence;

public interface IDinnerRepository
{
    void Add(Dinner dinner);
    List<Dinner> List(HostId hostId);
}