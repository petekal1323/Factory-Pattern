namespace FactoryPattern;

public class ConsoleLogger
{
    public static void VehicleStartUpDialogue()
    {
        Console.WriteLine("Put the key in the ignition");
        Thread.Sleep(1000);
        Console.WriteLine("turn key and drive!!!");
        Thread.Sleep(1000);
    }
}