using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate;

using ErrorOr;

using MediatR;

namespace BuberDinner.Application.Menus.Queries.ListMenus;

public class ListMenusQueryHandler : IRequestHandler<ListMenusQuery, ErrorOr<List<Menu>>>
{
    private readonly IMenuRepository _menuRepository;

    public ListMenusQueryHandler(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<List<Menu>>> Handle(ListMenusQuery query, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var hostId = HostId.Create(query.HostId);

        return _menuRepository.List(hostId);
    }
}