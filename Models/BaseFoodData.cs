using CsvHelper.Configuration.Attributes;

public class BaseFoodData
{
    [Index(0)]
    public string Id { get; set; }
    [Index(1)]
    public string Navn { get; set; }
    [Index(3)]
    public string Name { get; set; }
    [Index(2)]
    public string Kategori { get; set; }
    [Index(4)]
    public string Category { get; set; }
    [Index(5)]
    public string Unit { get; set; }
    [Index(6)]
    public float Agriculture { get; set; }
    [Index(7)]
    public float ILUC { get; set; }
    [Index(8)]
    public float FoodProcessing { get; set; }
    [Index(9)]
    public float Packaging { get; set; }
    [Index(10)]
    public float Transport { get; set; }
    [Index(11)]
    public float Retail { get; set; }
    [Index(12)]
    public float Total { get; set; }
    [Index(13)]
    public float Energi { get; set; }
    [Index(14)]
    public float Fedt { get; set; }
    [Index(15)]
    public float Kulhydrat { get; set; }
    [Index(16)]
    public float Protein { get; set; }
}