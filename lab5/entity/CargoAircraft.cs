using System;

namespace lab5.by.bsu.airline.entity
{
    public class CargoAircraft : BaseAircraft
    {
        public double CargoBayCapacity { get; }

        public CargoAircraft(string id, string model, int cruisingSpeed, int enginesAmount, double fuelConsumption,
            double maxDistance, double cargoBayCapacity) : base(id, model, cruisingSpeed, enginesAmount,
            fuelConsumption, maxDistance)
        {
            CargoBayCapacity = cargoBayCapacity;
        }

        public override void Fly()
        {
            Console.WriteLine("Cargo airplane is landing!");
        }

        public override void Land()
        {
            Console.WriteLine("Cargo airplane is landing!");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(CargoBayCapacity)}: {CargoBayCapacity}";
        }
    }
}