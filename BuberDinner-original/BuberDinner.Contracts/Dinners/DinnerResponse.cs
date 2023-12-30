namespace BuberDinner.Contracts.Dinners;

public record DinnerResponse(
    string Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime? StartedDateTime,
    DateTime? EndedDateTime,
    DinnerStatus Status,
    int MaxGuests,
    bool IsPublic,
    Price Price,
    string MenuId,
    string HostId,
    Uri ImageUrl,
    Location Location,
    DateTime CreatedDateTime,
    DateTime UpdatedDateTime);

public enum DinnerStatus
{
    Upcoming,
    InProgress,
    Ended,
    Cancelled,
}

public record Price(
    decimal Amount,
    string Currency);

public record Location(
    string Name,
    string Address,
    string Latitude,
    string Longitude);