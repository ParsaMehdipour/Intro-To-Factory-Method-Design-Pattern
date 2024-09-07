namespace DemoLibrary.ProductInterfaces;

// The Product interface declares the operations that all concrete products
// must implement.
public interface ITransport
{
    void Reserve();
    void Confirm();
    void DispatchVehicle();
}
