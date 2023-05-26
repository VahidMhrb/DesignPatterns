namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Subsystem1 subsystem1 = new();
            Subsystem2 subsystem2 = new();
            Facade facade = new(subsystem1, subsystem2);
            Client.ClientCode(facade);
            Console.ReadKey();
        }
    }
}