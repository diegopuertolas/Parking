namespace Parking.Models;
public class Motorbike : Vehicle
{
    public int MaxSpeed { get; set; }

    public Motorbike(string numberPlate, string brand, int maxSpeed)
        : base(numberPlate, brand)
    {
        MaxSpeed = maxSpeed;
    }

    public override void ShowDescription()
    {
        Console.WriteLine($"{NumberPlate} | {Brand} | {MaxSpeed}");
    }
}