using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate;
using BuberDinner.Domain.MenuAggregate.ValueObjects;

namespace BuberDinner.Infrastructure.Persistence.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly BuberDinnerDbContext _dbContext;

    public MenuRepository(BuberDinnerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Menu menu)
    {
        _dbContext.Add(menu);
        _dbContext.SaveChanges();
    }

    public bool Exists(MenuId menuId)
    {
        // Amichai of the future = the equals below is problamatic
        return _dbContext.Menus.Any(menu => menu.Id == menuId);
    }

    public List<Menu> List(HostId hostId)
    {
        return _dbContext.Menus.Where(menu => menu.HostId == hostId).ToList();
    }
}