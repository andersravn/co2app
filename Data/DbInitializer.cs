using System.Globalization;
using co2app.Models;
using CsvHelper;
using CsvHelper.Configuration;

namespace co2app.Data;

public class DbInitializer
{
    public static void Initialize(FoodContext context)
    {
        if (context.Foods.Any() && context.FoodCategories.Any())
        {
            return;
        }

        var foods = new List<Food>();

        var config = new CsvConfiguration(new CultureInfo("da-Dk", false))
        {
            Delimiter = ";",
        };

        using (var reader = new StreamReader($"Data{Path.DirectorySeparatorChar}FoodData{Path.DirectorySeparatorChar}food.csv"))
        using (var csv = new CsvReader(reader, config))
        {
            csv.Read();
            csv.ReadHeader();
            while (csv.Read())
            {
                var record = csv.GetRecord<BaseFoodData>();
                if (record is not null)
                {
                    var category = context.FoodCategories.Find(record.Category);
                    if (category is null)
                    {
                        category = new FoodCategory { Name = record.Category };
                        context.FoodCategories.Add(category);
                    }

                    var food = new Food
                    {
                        ExternalId = record.Id,
                        Name = record.Name,
                        DisplayName = record.Name,
                        Category = category,
                        Unit = record.Unit,
                        EmissionAgriculture = record.Agriculture,
                        EmissionFoodProcessing = record.FoodProcessing,
                        EmissionILUC = record.ILUC,
                        EmissionPackaging = record.Packaging,
                        EmissionRetail = record.Retail,
                        EmissionTotal = record.Total,
                        EmissionTransport = record.Transport,
                    };

                    foods.Add(food);
                }
            }
        }
        context.Foods.AddRange(foods);
        context.SaveChanges();
    }
}