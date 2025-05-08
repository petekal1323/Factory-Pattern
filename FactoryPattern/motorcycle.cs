namespace FactoryPattern;

public class motorcycle : IVehicle
{   
    public motorcycle()
    {
    }
    public void Drive()
    {
        ConsoleLogger.VehicleStartUpDialogue();
        Console.WriteLine("The motorcycle is revving");
        Console.WriteLine("Vrooooooom");
    }
}