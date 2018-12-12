using System.Collections.Generic;
using System.Linq;

namespace lab5.by.bsu.airline.entity
{
    public class AirCompany
    {
        public string Title { get; }
        public List<BaseAircraft> Aircrafts { get; set; }

        public AirCompany(string title)
        {
            Title = title;
            Aircrafts = new List<BaseAircraft>();
        }

        public void AddAircraftToFleet(BaseAircraft aircraft)
        {
            Aircrafts.Add(aircraft);
        }

        public long CalculateSummaryPassengerCapacity()
        {
            return Aircrafts
                .Where(aircraft => aircraft.GetType() == typeof(PassengerAircraft))
                .Cast<PassengerAircraft>()
                .Sum(air => air.PassengerCapacity);
        }

        public double CalculateSummaryLoadCapacity()
        {
            var passengerCapacity = Aircrafts.Where(aircraft => aircraft.GetType() == typeof(PassengerAircraft))
                .Cast<PassengerAircraft>()
                .Sum(air => air.LuggageBayCapacity);

            var cargoCapacity = Aircrafts.Where(aircraft => aircraft.GetType() == typeof(CargoAircraft))
                .Cast<CargoAircraft>()
                .Sum(air => air.CargoBayCapacity);
            return passengerCapacity + cargoCapacity;
        }

        public void SortAircraftByMaxDistance() => Aircrafts = Aircrafts.OrderBy(aircraft => aircraft.MaxDistance).ToList();
        
        public List<BaseAircraft> SearchAircraftByFuelConsumption(int MinFuelConsumption, int MaxFuelConsumption) {
            return Aircrafts.Where(aircraft => aircraft.FuelConsumption >= MinFuelConsumption && aircraft.FuelConsumption <= MaxFuelConsumption).ToList();
        }
    }
}