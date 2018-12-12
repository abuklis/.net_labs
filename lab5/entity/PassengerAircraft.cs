using System;

namespace lab5.by.bsu.airline.entity
{
    public class PassengerAircraft : BaseAircraft
    {
        public int PassengerCapacity { get; set; }
        public int LuggageBayCapacity { get; set; }

        public override void Fly()
        {
            Console.WriteLine("Passenger airplane is flying!");
        }

        public override void Land()
        {
            Console.WriteLine("Passenger airplane is landing!");
        }

        public PassengerAircraft(string id, string model, int cruisingSpeed, int enginesAmount, double fuelConsumption, double maxDistance, int passengerCapacity, int luggageBayCapacity) :
            base(id, model, cruisingSpeed, enginesAmount, fuelConsumption, maxDistance)
        {
            PassengerCapacity = passengerCapacity;
            LuggageBayCapacity = luggageBayCapacity;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(PassengerCapacity)}: {PassengerCapacity}, {nameof(LuggageBayCapacity)}: {LuggageBayCapacity}";
        }
    }
}