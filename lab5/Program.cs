using System;
using lab5.by.bsu.airline.entity;

namespace lab5.by.bsu.airline
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cargoAircraft1 = new CargoAircraft("12LPW2", "Boing 137", 300, 4, 45, 8000, 700);
            var cargoAircraft2 = new CargoAircraft("132U4I", "Airbus 98", 200, 7, 87, 10000, 560);
            
            var passengerAircraft1 = new PassengerAircraft("92LPI2", "Boing 873", 250, 4, 54, 8500, 56, 200);
            var passengerAircraft2 = new PassengerAircraft("900935U65", "Airbus 98", 250, 6, 69, 5000, 150, 400);
            
            var belavia = new AirCompany("Belavia");
            belavia.AddAircraftToFleet(cargoAircraft1);
            belavia.AddAircraftToFleet(cargoAircraft2);
            belavia.AddAircraftToFleet(passengerAircraft1);
            belavia.AddAircraftToFleet(passengerAircraft2);

            Console.WriteLine("Summary passenger capacity : " + belavia.CalculateSummaryPassengerCapacity());
          
            Console.WriteLine("Summary load capacity : " + belavia.CalculateSummaryLoadCapacity());

            belavia.SortAircraftByMaxDistance();

            Console.WriteLine("Aircrafts with fuel consumption between 50 and 60");
            belavia.SearchAircraftByFuelConsumption(50, 60).ForEach(aircraft => Console.WriteLine(aircraft.Id));
        }
    }
}