using BuberDinner.Application.Dinners;
using BuberDinner.Application.Dinners.Queries.ListDinners;
using BuberDinner.Contracts.Dinners;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[Route("hosts/{hostId}/dinners")]
public class DinnersController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _mediator;

    public DinnersController(IMapper mapper, ISender mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateDinner(CreateDinnerRequest request, string hostId)
    {
        var command = _mapper.Map<CreateDinnerCommand>((request, hostId));

        var createDinnerResult = await _mediator.Send(command);

        return createDinnerResult.Match(
            dinner => Ok(_mapper.Map<DinnerResponse>(dinner)),
            errors => Problem(errors));
    }

    [HttpGet]
    public async Task<IActionResult> ListDinners(string hostId)
    {
        var query = _mapper.Map<ListDinnersQuery>(hostId);

        var listDinnersQuery = await _mediator.Send(query);

        return listDinnersQuery.Match(
            dinners => Ok(dinners.Select(dinner => _mapper.Map<DinnerResponse>(dinner))),
            errors => Problem(errors));
    }
}