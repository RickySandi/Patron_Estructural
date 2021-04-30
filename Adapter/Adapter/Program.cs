using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget Itarget = new VehicleAdapter();
            Client client = new Client(Itarget);
            client.ShowVehiclesList();

            Console.ReadKey();

        }
    }
}
