using System;
using System.Collections.Generic;

namespace Adapter
{
    public class Client
    {
        private ITarget _vehicleSource;

        public Client(ITarget vehicleSource)
        {
            this._vehicleSource = vehicleSource;
        }

        public void ShowVehiclesList()
        {
            List<string> vehicle = _vehicleSource.GetVehiclesList();
            

            Console.WriteLine("*** Vehicles List ***");
            foreach (var item in vehicle)
            {
                Console.Write(item);
            }

        }
    }
}
