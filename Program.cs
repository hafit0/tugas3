using System;


namespace Taxi 
{ 
    class Program
    {
      static void Main(string[] args) {

            Taxi taxi = new Taxi();

            taxi.DriverName = "Hafit";
            taxi.OnDuty = true;
            taxi.NumPassenger = 13;


            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();

          
       }
    }
}
