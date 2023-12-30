using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.DinnerAggregate;
using BuberDinner.Domain.HostAggregate.ValueObjects;

using ErrorOr;

using MediatR;

namespace BuberDinner.Application.Dinners.Queries.ListDinners;

public class ListDinnersQueryHandler : IRequestHandler<ListDinnersQuery, ErrorOr<List<Dinner>>>
{
    private readonly IDinnerRepository _dinnerRepository;

    public ListDinnersQueryHandler(IDinnerRepository dinnerRepository)
    {
        _dinnerRepository = dinnerRepository;
    }

    public async Task<ErrorOr<List<Dinner>>> Handle(ListDinnersQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var hostId = HostId.Create(request.HostId);
        return _dinnerRepository.List(hostId);
    }
}