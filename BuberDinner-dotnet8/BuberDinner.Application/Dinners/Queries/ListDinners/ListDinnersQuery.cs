using BuberDinner.Domain.DinnerAggregate;

using ErrorOr;

using MediatR;

namespace BuberDinner.Application.Dinners.Queries.ListDinners;

public record ListDinnersQuery(string HostId) : IRequest<ErrorOr<List<Dinner>>>;