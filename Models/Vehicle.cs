namespace Parking.Models;

public abstract class Vehicle
{
    public string NumberPlate { get; set; }
    public string Brand { get; set; }

    public Vehicle(string numberPlate, string brand)
    {
        NumberPlate = numberPlate;
        Brand = brand;
    }

    public abstract void ShowDescription();
}