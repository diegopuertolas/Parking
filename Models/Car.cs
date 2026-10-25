namespace Parking.Models;

public class Car : Vehicle
{
    public int Seats { get; set; }

    public Car(string numberPlate, string brand, int seats)
        : base(numberPlate, brand)
    {
        Seats = seats;
    }

    public override void ShowDescription()
    {
        Console.WriteLine($"{ NumberPlate } | { Brand } | { Seats }");
    }
}