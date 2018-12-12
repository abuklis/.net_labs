namespace lab5.by.bsu.airline.entity
{
    public abstract class BaseAircraft : IFlyingObject
    {
        public string Id { get; set; }
        public string Model { get; set; }
        public int CruisingSpeed { get; set; }
        public int EnginesAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double MaxDistance { get; set; }

        public abstract void Fly();
        public abstract void Land();

        protected BaseAircraft(string id, string model, int cruisingSpeed, int enginesAmount, double fuelConsumption,
            double maxDistance)
        {
            Id = id;
            Model = model;
            CruisingSpeed = cruisingSpeed;
            EnginesAmount = enginesAmount;
            FuelConsumption = fuelConsumption;
            MaxDistance = maxDistance;
        }

        public override string ToString()
        {
            return
                $"{nameof(Id)}: {Id}, {nameof(Model)}: {Model}, {nameof(CruisingSpeed)}: {CruisingSpeed}, {nameof(EnginesAmount)}: {EnginesAmount}, {nameof(FuelConsumption)}: {FuelConsumption}, {nameof(MaxDistance)}: {MaxDistance}";
        }
    }
}