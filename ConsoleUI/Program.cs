using DemoLibrary.AbstractCreators;
using DemoLibrary.ConcreteCreators;
using static System.Console;

WriteLine("Enter your desired transportation type (taxi/bus): ");
string type = ReadLine().ToString();

if (type == "taxi")
{
    WriteLine("Booking a Taxi:");
    TransportBookingService taxiService = new TaxiBookingService();
    taxiService.BookTransport();
}
else if (type == "bus")
{

    WriteLine("\nBooking a Bus:");
    TransportBookingService busService = new BusBookingService();
    busService.BookTransport();
}

else
{
    WriteLine("Service is not in our support");
}

