using DemoLibrary.ProductInterfaces;

namespace DemoLibrary.ConcretePriducts;
/// <summary>
/// Concrete Products provide various implementations of the Product
/// interface.
/// </summary>
public class BusTransport : ITransport
{
    public void Reserve()
    {
        Console.WriteLine("Checking available seats on the bus");
    }

    public void Confirm()
    {
        Console.WriteLine("Confirming bus ticket purchase");
    }

    public void DispatchVehicle()
    {
        Console.WriteLine("Bus will arrive at the designated stop");
    }
}
