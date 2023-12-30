using System.Data;

using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.DinnerAggregate;
using BuberDinner.Domain.HostAggregate.ValueObjects;

using Microsoft.EntityFrameworkCore.Internal;

namespace BuberDinner.Infrastructure.Persistence.Repositories;

public class DinnerRepository : IDinnerRepository
{
    private readonly BuberDinnerDbContext _dbContext;

    public DinnerRepository(BuberDinnerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Dinner dinner)
    {
        _dbContext.Add(dinner);

        _dbContext.SaveChanges();
    }

    public List<Dinner> List(HostId hostId)
    {
        return _dbContext.Dinners.Where(dinner => dinner.HostId == hostId).ToList();
    }
}