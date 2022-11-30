using Microsoft.EntityFrameworkCore;
using co2app.Models;

namespace co2app.Data;

public class FoodContext : DbContext
{
    // TODO: Hvad betyder ": base(options)"?
    public FoodContext(DbContextOptions<FoodContext> options) : base(options)
    {

    }

    public DbSet<Food> Foods => Set<Food>();
    public DbSet<FoodCategory> FoodCategories => Set<FoodCategory>();
}