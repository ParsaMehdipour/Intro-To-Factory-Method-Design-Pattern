using DemoLibrary.ProductInterfaces;

namespace DemoLibrary.ConcreteProducts;

/// <summary>
/// Concrete Products provide various implementations of the Product
/// interface.
/// </summary>
public class TaxiTransport : ITransport
{
    public void Reserve()
    {
        Console.WriteLine("Reserving the nearest available taxi");
    }

    public void Confirm()
    {
        Console.WriteLine("Confirming taxi booking and payment method");
    }

    public void DispatchVehicle()
    {
        Console.WriteLine("Dispatching taxi to your location");
    }
}
