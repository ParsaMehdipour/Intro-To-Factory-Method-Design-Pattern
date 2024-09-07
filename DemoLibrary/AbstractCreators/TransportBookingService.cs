using DemoLibrary.ProductInterfaces;

namespace DemoLibrary.AbstractCreators;

/// <summary>
/// The Creator class declares the factory method that is supposed to return
/// an object of a Product class. The Creator's subclasses usually provide
/// the implementation of this method.
/// </summary>

public abstract class TransportBookingService
{
    // Note that the Creator may also provide some default implementation of
    // the factory method.
    public abstract ITransport CreateTransport();

    // Also note that, despite its name, the Creator's primary
    // responsibility is not creating products. Usually, it contains some
    // core business logic that relies on Product objects, returned by the
    // factory method. Subclasses can indirectly change that business logic
    // by overriding the factory method and returning a different type of
    // product from it.
    public void BookTransport()
    {
        // Call the factory method to create a product object.
        ITransport transport = CreateTransport();

        // Now use the product.
        transport.Reserve();
        transport.Confirm();
        transport.DispatchVehicle();
    }
}
