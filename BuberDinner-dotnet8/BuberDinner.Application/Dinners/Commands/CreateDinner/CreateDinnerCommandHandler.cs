using System.Reflection.PortableExecutable;

using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Common.DomainErrors;
using BuberDinner.Domain.DinnerAggregate;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate.ValueObjects;

using ErrorOr;

using MediatR;

namespace BuberDinner.Application.Dinners;

public class CreateDinnerCommandHandler : IRequestHandler<CreateDinnerCommand, ErrorOr<Dinner>>
{
    private readonly IDinnerRepository _dinnerRepository;
    private readonly IMenuRepository _menuRepository;

    public CreateDinnerCommandHandler(IDinnerRepository dinnerRepository, IMenuRepository menuRepository)
    {
        _dinnerRepository = dinnerRepository;
        _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<Dinner>> Handle(CreateDinnerCommand command, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var createMenuIdResult = MenuId.Create(command.MenuId);

        if (createMenuIdResult.IsError)
        {
            return createMenuIdResult.Errors;
        }

        if (!_menuRepository.Exists(createMenuIdResult.Value))
        {
            return Errors.Menu.NotFound;
        }

        var dinner = Dinner.Create(
            command.Name,
            command.Description,
            command.StartDateTime,
            command.EndDateTime,
            command.IsPublic,
            command.MaxGuests,
            Price.Create(
                command.Price.Amount,
                command.Price.Currency),
            createMenuIdResult.Value,
            HostId.Create(command.HostId),
            command.ImageUrl,
            Location.Create(
                command.Location.Name,
                command.Location.Address,
                command.Location.Latitude,
                command.Location.Longitude));

        _dinnerRepository.Add(dinner);

        return dinner;
    }
}