using System.ComponentModel.DataAnnotations;

namespace co2app.Models;

public class FoodCategory : IEquatable<FoodCategory>
{
    [Key]
    // TODO: i18n, dk, en
    public string? Name { get; set; }

    public bool Equals(FoodCategory? other)
    {
        if (other == null)
            return false;

        if (this.Name == other.Name)
            return true;
        else
            return false;
    }
}