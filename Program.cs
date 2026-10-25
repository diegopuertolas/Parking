using Parking.Models;

var ferrari = new Car("1234ABC", "Ferrari", 2);
var ducati = new Motorbike("4321DPR", "Ducati", 320);
var hymer = new Van("9876FGC", "Hymer", true);

var vehicles = new List<Vehicle>
{
    ferrari, 
    ducati, 
    hymer
};

AppMenu.DisplayMenu(vehicles);