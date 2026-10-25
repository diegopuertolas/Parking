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

var option = -1;

do
{
    ShowMenu();
    option = ChooseOption();
    
    switch (option)
    {
        case 1:
            Console.WriteLine();
            ShowVehicles(vehicles);
            break;
        case 2:
            Console.WriteLine();
            SearchByNumberPlate(vehicles);
            break;
        case 3:
            Console.WriteLine();
            ShowCars(vehicles);
            break;
        case 0:
            Console.WriteLine("\nSaliendo del programa...");
            break;
        default: 
            Console.WriteLine("\nOpción no válida. Incluya un número del 0 al 3.");
            break;
    }

} while (option != 0);

static void ShowMenu()
{
    Console.WriteLine("\n=== PARKING ===");
    Console.WriteLine("1. Ver vehículos");
    Console.WriteLine("2. Buscar por matrícula");
    Console.WriteLine("3. Mostrar coches");
    Console.WriteLine("0. Salir");
    Console.Write("\nIntroduzca una opción: ");
}

static int ChooseOption()
{
    var input = Console.ReadLine();

    if (!int.TryParse(input, out var decision))
    {
        return -1;
    }

    return decision;
}

static void ShowVehicles(List<Vehicle> vehicles)
{
    foreach (var vehicle in vehicles)
    {
        vehicle.ShowDescription();
    }
}

static void SearchByNumberPlate(List<Vehicle> vehicles)
{
    Console.Write("Introduzca la mátricula a buscar: ");
    var numberPlate = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(numberPlate))
    {
        Console.WriteLine("\nMatricula incorrecta");
        return;
    }

    foreach (var vehicle in vehicles)
    {
        if (vehicle.NumberPlate.Contains(numberPlate))
        {
            vehicle.ShowDescription();
        }
    }
}

static void ShowCars(List<Vehicle> vehicles)
{
    foreach (var vehicle in vehicles)
    {
        if (vehicle is Car)
        {
            vehicle.ShowDescription();
        }
    }
}