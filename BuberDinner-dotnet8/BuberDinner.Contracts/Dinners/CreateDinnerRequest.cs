namespace BuberDinner.Contracts.Dinners;

public record CreateDinnerRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    int MaxGuests,
    bool IsPublic,
    DinnerPrice Price,
    string MenuId,
    Uri ImageUrl,
    DinnerLocation Location);

public record DinnerPrice(
    decimal Amount,
    string Currency);

public record DinnerLocation(
    string Name,
    string Address,
    double Latitude,
    double Longitude);