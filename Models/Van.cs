namespace Parking.Models;

public class Van : Vehicle
{
    public bool IsHabitable { get; set; }

    public Van(string numberPlate, string brand, bool isHabitable)
        : base(numberPlate, brand)
    {
        IsHabitable = isHabitable;
    }

    public override void ShowDescription()
    {
        Console.WriteLine($"{NumberPlate} | {Brand} | { (IsHabitable ? "Habitable" : "No habitable") }");
    }
}