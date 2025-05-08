namespace FactoryPattern;

public class ThreeWheeler : IVehicle
{
    public ThreeWheeler()
    {
    }

    public void Drive()
    {
        ConsoleLogger.VehicleStartUpDialogue();
        Console.WriteLine("Driving a three wheeler");
    }
}