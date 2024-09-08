using DemoLibrary.AbstractCreators;
using DemoLibrary.ConcreteProducts;
using DemoLibrary.ProductInterfaces;

namespace DemoLibrary.ConcreteCreators;

/// <summary>
/// Concrete Creators override the factory method in order to change the
/// resulting product's type.
/// </summary>
public class BusBookingService : TransportBookingService
{
    // Note that the signature of the method still uses the abstract product
    // type, even though the concrete product is actually returned from the
    // method. This way the Creator can stay independent of concrete product
    // classes.
    public override ITransport CreateTransport()
    {
        return new BusTransport();
    }
}
