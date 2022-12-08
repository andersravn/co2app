using CsvHelper.Configuration.Attributes;

namespace co2app.Models;

public class Food
{

    public Food()
    {
        Unit = "kg";
    }
    public int Id { get; set; }
    [Index(3)]
    public string? Name { get; set; }
    // TODO: i18n, dk, en
    [Index(3)]
    public string? DisplayName { get; set; }
    [Index(0)]
    public string? ExternalId { get; set; }

    public string? CategoryName { get; set; }
    public FoodCategory? Category { get; set; }
    [Index(5)]
    public string Unit { get; set; }
    [Index(6)]
    public float EmissionAgriculture { get; set; }
    [Index(7)]
    public float EmissionILUC { get; set; }
    [Index(8)]
    public float EmissionFoodProcessing { get; set; }
    [Index(9)]
    public float EmissionPackaging { get; set; }
    [Index(10)]
    public float EmissionTransport { get; set; }
    [Index(11)]
    public float EmissionRetail { get; set; }
    [Index(12)]
    public float? EmissionTotal { get; set; }
    [Index(13)]
    int MacroKilojoules { get; set; }
    [Index(14)]
    float MacroFat { get; set; }
    [Index(15)]
    float MacroCarbohydrates { get; set; }
    [Index(16)]
    float MacroProtein { get; set; }
}