using BuberDinner.Domain.BillAggregate.ValueObjects;
using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.DinnerAggregate.Enums;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.GuestAggregate.ValueObjects;

namespace BuberDinner.Domain.DinnerAggregate.Entities;

public sealed class Reservation : Entity<ReservationId>
{
    public int GuestCount { get; private set; }
    public GuestId GuestId { get; private set; }
    public BillId? BillId { get; private set; }
    public ReservationStatus Status { get; private set; }
    public DateTime? ArrivalDateTime { get; private set; }
    public DateTime CreatedDateTime { get; private set; }
    public DateTime UpdatedDateTime { get; private set; }

    private Reservation(
        GuestId guestId,
        int guestCount,
        DateTime? arrivalDateTime,
        BillId? billId,
        ReservationStatus status)
        : base(ReservationId.CreateUnique())
    {
        GuestId = guestId;
        GuestCount = guestCount;
        ArrivalDateTime = arrivalDateTime;
        BillId = billId;
        Status = status;
    }

    public static Reservation Create(
        GuestId guestId,
        int guestCount,
        ReservationStatus status,
        BillId? billId = null,
        DateTime? arrivalDateTime = null)
    {
        // TODO: Enforce invariants
        return new Reservation(
            guestId,
            guestCount,
            arrivalDateTime,
            billId,
            status);
    }

#pragma warning disable CS8618
    private Reservation()
    {
    }
#pragma warning restore CS8618
}