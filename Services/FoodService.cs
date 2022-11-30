using co2app.Data;

namespace co2app.Services;

public class FoodService
{
    private readonly FoodContext _context;

    public FoodService(FoodContext context)
    {
        _context = context;
    }
}