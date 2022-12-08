using co2app.Data;
using co2app.Models;

namespace co2app.Services;

public class FoodService
{
    private readonly FoodContext _context;

    public FoodService(FoodContext context)
    {
        _context = context;
    }

    public IEnumerable<Food> GetAll()
    {
        return _context.Foods.ToArray();
    }

    public Food? Get(int Id)
    {
        return _context.Foods.Find(Id);
    }
}