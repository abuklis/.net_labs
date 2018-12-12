using System;
using System.Collections.Generic;

namespace lab6.by.bsu.lab6.entity
{
    public class BluRay : StorableBluRayEntity
    {
        public BluRay(string manufacturer, double storage)
        {
            Manufacturer = manufacturer;
            Storage = storage;
        }

        private string Manufacturer { get; set; }
        private double Storage { get; set; }

        public BluRay(List<Record> records, List<Catalog> catalogs, string manufacturer, double storage) : base(records,
            catalogs)
        {
            Manufacturer = manufacturer;
            Storage = storage;
        }

        public class Catalog : StorableBluRayEntity
        {
            public string Name { get; set; }
            private DateTime CreationTime { get; set; }

            public Catalog(string name, DateTime creationTime)
            {
                Name = name;
                CreationTime = creationTime;
            }

            public Catalog(List<Record> records, List<Catalog> catalogs, string name, DateTime creationTime) : base(
                records, catalogs)
            {
                Name = name;
                CreationTime = creationTime;
            }

            public override string ToString()
            {
                return $"{nameof(Name)}: {Name}, {nameof(CreationTime)}: {CreationTime}, {base.ToString()} ";
            }
        }

        public class Record : BaseBluRayEntity
        {
            public string Name { get; set; }
            private DateTime CreationTime { get; set; }
            private double Length { get; set; }

            public Record(string name, DateTime creationTime, double length) : base(name, creationTime)
            {
                Name = name;
                CreationTime = creationTime;
                Length = length;
            }

            public override string ToString()
            {
                return $"{base.ToString()}, {nameof(Length)}: {Length}";
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Manufacturer)}: {Manufacturer}, {nameof(Storage)}: {Storage}";
        }
    }
}